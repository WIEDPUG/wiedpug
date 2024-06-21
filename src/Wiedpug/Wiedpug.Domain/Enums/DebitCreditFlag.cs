using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum DebitCreditFlag
    {
        [Description("1: Debit")]
        Debit = 1,

        [Description("2: Credit")]
        Credit = 2
    }
}
