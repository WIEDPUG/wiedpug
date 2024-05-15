using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeclaredWoolCategory
    {
        [Description("F: Fleece")]
        F,

        [Description("P: Pieces")]
        P,

        [Description("B: Bellies")]
        B,

        [Description("C: Crutchings")]
        C,

        [Description("Z: Locks")]
        Z
    }
}
