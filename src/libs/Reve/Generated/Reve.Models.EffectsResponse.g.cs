
#nullable enable

namespace Reve
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EffectsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effects")]
        public global::System.Collections.Generic.IList<global::Reve.Effect>? Effects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectsResponse" /> class.
        /// </summary>
        /// <param name="effects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectsResponse(
            global::System.Collections.Generic.IList<global::Reve.Effect>? effects)
        {
            this.Effects = effects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectsResponse" /> class.
        /// </summary>
        public EffectsResponse()
        {
        }
    }
}