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
    public enum LsCertType
    {
        [Description("Length & Strength tested")]
        LengthAndStrengthTested = 0,

        [Description("Length only test requested")]
        LengthOnlyTestRequested = 1,

        [Description("Insufficient staples")]
        InsufficientStaples = 3
    }
}
