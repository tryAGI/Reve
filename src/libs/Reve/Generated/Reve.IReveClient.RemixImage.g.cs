#nullable enable

namespace Reve
{
    public partial interface IReveClient
    {
        /// <summary>
        /// Generate a new image by remixing reference images with a text prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reve.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> RemixImageAsync(

            global::Reve.RemixImageRequest request,
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a new image by remixing reference images with a text prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reve.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> RemixImageAsStreamAsync(

            global::Reve.RemixImageRequest request,
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a new image by remixing reference images with a text prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reve.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reve.AutoSDKHttpResponse<byte[]>> RemixImageAsResponseAsync(

            global::Reve.RemixImageRequest request,
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a new image by remixing reference images with a text prompt.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt describing the desired output.
        /// </param>
        /// <param name="referenceImages">
        /// Base64-encoded reference images.
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
        global::System.Threading.Tasks.Task<byte[]> RemixImageAsync(
            string prompt,
            global::System.Collections.Generic.IList<string> referenceImages,
            global::Reve.AspectRatio? aspectRatio = default,
            string? version = default,
            int? testTimeScaling = default,
            global::System.Collections.Generic.IList<object>? postprocessing = default,
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}