
#nullable enable

namespace Reve
{
    /// <summary>
    ///
    /// </summary>
    public enum EffectSource
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Preset,
        /// <summary>
        ///
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EffectSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EffectSource value)
        {
            return value switch
            {
                EffectSource.All => "all",
                EffectSource.Preset => "preset",
                EffectSource.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EffectSource? ToEnum(string value)
        {
            return value switch
            {
                "all" => EffectSource.All,
                "preset" => EffectSource.Preset,
                "project" => EffectSource.Project,
                _ => null,
            };
        }
    }
}