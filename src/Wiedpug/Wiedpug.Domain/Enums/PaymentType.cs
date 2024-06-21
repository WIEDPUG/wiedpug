using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum PaymentType
    {
        [Description("0: Paid")]
        Paid=0,

        [Description("1: Withheld")]
        Withheld=1,

        [Description("2: Withheld pending credit")]
        WithheldPendingCredit=2
    }
}
