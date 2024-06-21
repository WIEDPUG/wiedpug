using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum AmountType

    {
        [Description("0: Invoice")]
        Invoice = 0,

        [Description("1: Cheque")]
        Cheque = 1,

        [Description("2: CR Note")]
        CRNote = 2,

        [Description("3: DR Note")]
        DRNote = 3,

        [Description("4: CR Journal")]
        CRJournal = 4,

        [Description("5: DR Journal")]
        DRJournal = 5

    }
}
