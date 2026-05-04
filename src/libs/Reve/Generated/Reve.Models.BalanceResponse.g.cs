
#nullable enable

namespace Reve
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BalanceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_id")]
        public string? BudgetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_balance")]
        public double? NewBalance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponse" /> class.
        /// </summary>
        /// <param name="budgetId"></param>
        /// <param name="newBalance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BalanceResponse(
            string? budgetId,
            double? newBalance)
        {
            this.BudgetId = budgetId;
            this.NewBalance = newBalance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponse" /> class.
        /// </summary>
        public BalanceResponse()
        {
        }
    }
}