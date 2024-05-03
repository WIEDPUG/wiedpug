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
        [Description("Gain: Code: G. Invoice Mass is a Gain")]
        Gain,

        [Description("Loss: Code: L. Invoice Mass is a Loss")]
        Loss,
    }
}
