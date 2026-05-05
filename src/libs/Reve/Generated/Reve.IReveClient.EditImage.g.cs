#nullable enable

namespace Reve
{
    public partial interface IReveClient
    {
        /// <summary>
        /// Edit an image with a natural-language instruction.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reve.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> EditImageAsync(

            global::Reve.EditImageRequest request,
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit an image with a natural-language instruction.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reve.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> EditImageAsStreamAsync(

            global::Reve.EditImageRequest request,
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit an image with a natural-language instruction.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Reve.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Reve.AutoSDKHttpResponse<byte[]>> EditImageAsResponseAsync(

            global::Reve.EditImageRequest request,
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit an image with a natural-language instruction.
        /// </summary>
        /// <param name="editInstruction">
        /// Natural-language edit instruction.
        /// </param>
        /// <param name="referenceImage">
        /// Base64-encoded source image.
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
        global::System.Threading.Tasks.Task<byte[]> EditImageAsync(
            string editInstruction,
            string referenceImage,
            global::Reve.AspectRatio? aspectRatio = default,
            string? version = default,
            int? testTimeScaling = default,
            global::System.Collections.Generic.IList<object>? postprocessing = default,
            global::Reve.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}