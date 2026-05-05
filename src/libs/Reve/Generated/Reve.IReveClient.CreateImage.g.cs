#nullable enable

namespace Reve
{
    public partial interface IReveClient
    {
        /// <summary>
        /// Generate an image from a text prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reve.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateImageAsync(

            global::Reve.CreateImageRequest request,
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image from a text prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reve.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateImageAsStreamAsync(

            global::Reve.CreateImageRequest request,
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image from a text prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reve.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reve.AutoSDKHttpResponse<byte[]>> CreateImageAsResponseAsync(

            global::Reve.CreateImageRequest request,
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image from a text prompt.
        /// </summary>
        /// <param name="prompt">
        /// Text description of the image to generate.
        /// </param>
        /// <param name="aspectRatio"></param>
        /// <param name="version">
        /// Reve model version, or latest.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="testTimeScaling">
        /// Quality level from 1 to 5.
        /// </param>
        /// <param name="postprocessing">
        /// Optional post-processing operation descriptors.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateImageAsync(
            string prompt,
            global::Reve.AspectRatio? aspectRatio = default,
            string? version = default,
            int? testTimeScaling = default,
            global::System.Collections.Generic.IList<object>? postprocessing = default,
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}