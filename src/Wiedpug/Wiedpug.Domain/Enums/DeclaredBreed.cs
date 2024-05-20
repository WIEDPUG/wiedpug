using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeclaredBreed
    {
        [Description("A: Australian Superfine")]
        A,

        [Description("M: Merino")]
        M,

        [Description("X: Crossbred")]
        X,

        [Description("D: Downs")]
        D,

        [Description("T: Carpet")]
        T,

        [Description("R: Sheds Fibres")]
        R
    }
}
