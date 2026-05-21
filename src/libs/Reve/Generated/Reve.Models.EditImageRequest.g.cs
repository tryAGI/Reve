
#nullable enable

namespace Reve
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageRequest
    {
        /// <summary>
        /// Natural-language edit instruction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit_instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EditInstruction { get; set; }

        /// <summary>
        /// Base64-encoded source image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceImage { get; set; }

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
        /// Initializes a new instance of the <see cref="EditImageRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditImageRequest(
            string editInstruction,
            string referenceImage,
            global::Reve.AspectRatio? aspectRatio,
            string? version,
            int? testTimeScaling,
            global::System.Collections.Generic.IList<object>? postprocessing)
        {
            this.EditInstruction = editInstruction ?? throw new global::System.ArgumentNullException(nameof(editInstruction));
            this.ReferenceImage = referenceImage ?? throw new global::System.ArgumentNullException(nameof(referenceImage));
            this.AspectRatio = aspectRatio;
            this.Version = version;
            this.TestTimeScaling = testTimeScaling;
            this.Postprocessing = postprocessing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageRequest" /> class.
        /// </summary>
        public EditImageRequest()
        {
        }

    }
}