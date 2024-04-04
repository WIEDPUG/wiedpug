using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InvoiceMassFlag
    {
        [Description("G: Invoice Mass is a Gain")]
        G,

        [Description("L: Invoice Mass is a Loss")]
        L,
    }
}
