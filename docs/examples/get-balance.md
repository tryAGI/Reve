# Get balance

Check the current Reve credit balance.

This example assumes `using Reve;` is in scope and `apiKey` contains your Reve API key.

```csharp
using var client = new ReveClient(apiKey);

var balance = await client.GetBalanceAsync();
```