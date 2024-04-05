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
    public enum CalibrationFlag
    {
        [Description("O: Old - The values for Colour X, Y, Z and Y-Z have been measured by an instrument calibrated to reference wool, based on illuminant C and 2º observer angle. Old calibration has been deactivated as at 1st January 2001.")]
        O,
        [Description("N: New - The values for Colour X, Y, Z and Y-Z have been measured by an instrument calibrated to certified tiles, based on illuminant D65 and 10º observer angle, and corrected for any glass effects")]
        N
    }
}
