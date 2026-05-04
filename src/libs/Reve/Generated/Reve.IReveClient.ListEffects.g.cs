#nullable enable

namespace Reve
{
    public partial interface IReveClient
    {
        /// <summary>
        /// List available image post-processing effects.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reve.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reve.EffectsResponse> ListEffectsAsync(
            global::Reve.EffectSource? source = default,
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}