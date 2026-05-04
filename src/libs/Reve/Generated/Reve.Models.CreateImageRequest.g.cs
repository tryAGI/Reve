
#nullable enable

namespace Reve
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageRequest
    {
        /// <summary>
        /// Text description of the image to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Reve.JsonConverters.AspectRatioJsonConverter))]
        public global::Reve.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Reve model version, or latest.<br/>
        /// Default Value: latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Quality level from 1 to 5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_time_scaling")]
        public int? TestTimeScaling { get; set; }

        /// <summary>
        /// Optional post-processing operation descriptors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postprocessing")]
        public global::System.Collections.Generic.IList<object>? Postprocessing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageRequest(
            string prompt,
            global::Reve.AspectRatio? aspectRatio,
            string? version,
            int? testTimeScaling,
            global::System.Collections.Generic.IList<object>? postprocessing)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.AspectRatio = aspectRatio;
            this.Version = version;
            this.TestTimeScaling = testTimeScaling;
            this.Postprocessing = postprocessing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageRequest" /> class.
        /// </summary>
        public CreateImageRequest()
        {
        }
    }
}