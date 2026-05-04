# Create image

Generate an image from a text prompt.

This example assumes `using Reve;` is in scope and `apiKey` contains your Reve API key.

```csharp
using var client = new ReveClient(apiKey);

var image = await client.CreateImageAsync(new CreateImageRequest
{
    Prompt = "A crisp product photo of a matte white ceramic espresso cup on a walnut table.",
    AspectRatio = AspectRatio.x1_1,
    Version = "latest",
    TestTimeScaling = 1,
});
```