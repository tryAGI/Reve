
#nullable enable

namespace Reve
{
    /// <summary>
    ///
    /// </summary>
    public enum AspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x16_9,
        /// <summary>
        ///
        /// </summary>
        x1_1,
        /// <summary>
        ///
        /// </summary>
        x2_3,
        /// <summary>
        ///
        /// </summary>
        x3_2,
        /// <summary>
        ///
        /// </summary>
        x3_4,
        /// <summary>
        ///
        /// </summary>
        x4_3,
        /// <summary>
        ///
        /// </summary>
        x9_16,
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AspectRatio value)
        {
            return value switch
            {
                AspectRatio.x16_9 => "16:9",
                AspectRatio.x1_1 => "1:1",
                AspectRatio.x2_3 => "2:3",
                AspectRatio.x3_2 => "3:2",
                AspectRatio.x3_4 => "3:4",
                AspectRatio.x4_3 => "4:3",
                AspectRatio.x9_16 => "9:16",
                AspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => AspectRatio.x16_9,
                "1:1" => AspectRatio.x1_1,
                "2:3" => AspectRatio.x2_3,
                "3:2" => AspectRatio.x3_2,
                "3:4" => AspectRatio.x3_4,
                "4:3" => AspectRatio.x4_3,
                "9:16" => AspectRatio.x9_16,
                "auto" => AspectRatio.Auto,
                _ => null,
            };
        }
    }
}