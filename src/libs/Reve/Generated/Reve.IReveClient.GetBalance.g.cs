#nullable enable

namespace Reve
{
    public partial interface IReveClient
    {
        /// <summary>
        /// Get the current Reve credit balance.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reve.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reve.BalanceResponse> GetBalanceAsync(
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the current Reve credit balance.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reve.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reve.AutoSDKHttpResponse<global::Reve.BalanceResponse>> GetBalanceAsResponseAsync(
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}