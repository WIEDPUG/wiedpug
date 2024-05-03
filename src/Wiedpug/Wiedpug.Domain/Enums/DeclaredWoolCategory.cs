using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeclaredWoolCategory
    {
        [Description("Fleece: Code: F. Fleece")]
        Fleece,

        [Description("Pieces: Code: P. Pieces")]
        Pieces,

        [Description("Bellies: Code: B. Bellies")]
        Bellies,

        [Description("Crutchings: Code: C. Crutchings")]
        Crutchings,

        [Description("Locks: Code: Z. Locks")]
        Locks
    }
}
