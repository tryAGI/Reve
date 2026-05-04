/*
order: 10
title: Create image
slug: create-image

Generate an image from a text prompt.
*/

namespace Reve.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_CreateImage()
    {
        using var client = GetAuthenticatedClient();

        var image = await client.CreateImageAsync(new CreateImageRequest
        {
            Prompt = "A crisp product photo of a matte white ceramic espresso cup on a walnut table.",
            AspectRatio = AspectRatio.x1_1,
            Version = "latest",
            TestTimeScaling = 1,
        });

        image.Should().NotBeNullOrEmpty();
    }
}
