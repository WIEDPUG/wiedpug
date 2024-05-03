using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeclaredBreed
    {
        [Description("AustralianSuperfine: Code: A. Australian Superfine")]
        AustralianSuperfine,

        [Description("Merino: Code: M. Merino")]
        Merino,

        [Description("Crossbred: Code: X. Crossbred")]
        Crossbred,

        [Description("Downs: Code: D. Downs")]
        Downs,

        [Description("Carpet: Code: T. Carpet")]
        Carpet,

        [Description("ShedsFibres: Code: R. Sheds Fibres")]
        ShedsFibres
    }
}
