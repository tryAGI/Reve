/*
order: 20
title: Get balance
slug: get-balance

Check the current Reve credit balance.
*/

namespace Reve.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GetBalance()
    {
        using var client = GetAuthenticatedClient();

        var balance = await client.GetBalanceAsync();

        balance.NewBalance.Should().NotBeNull();
    }
}
