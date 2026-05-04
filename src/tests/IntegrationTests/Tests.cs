namespace Reve.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ReveClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("REVE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("REVE_API_KEY environment variable is not found.");

        var client = new ReveClient(apiKey);
        
        return client;
    }

}
