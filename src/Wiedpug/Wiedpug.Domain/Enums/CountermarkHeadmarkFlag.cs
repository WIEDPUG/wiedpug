using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [Description("A flag that indicates whether the mark is to be placed on the side or the end of the bale.")]
    public enum CountermarkHeadmarkFlag

    {
        [Description("1: Countermark is to be applied on the bale")]
        Countermark = 1,

        [Description("2: Headmark is to be applied on the bale")]
        Headmark = 2

    }
}
