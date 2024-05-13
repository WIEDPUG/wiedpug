using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum LsRetuftRequired
    {
        [Description("1: Length & Strength Retuft is required")]
        Required = 1,

        [Description("2: Length & Strength Retuft sample has been received in laboratory")]
        Received = 2
    }
}
