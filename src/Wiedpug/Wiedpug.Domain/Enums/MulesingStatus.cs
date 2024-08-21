using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    /// <summary>
    /// Note: Blank will be transmitted if the certificate was issued prior to 21st July, 2008 or if the transmission was outside Australia.
    /// 
    /// From:
    /// 
    /// The current value that the Mulesing Status is to be changed from
    /// 
    /// To:
    ///
    /// The new value that the Mulesing Status is to be changed to.
    /// 
    /// To obtain the current code list please go to this URL: https://www.awex.com.au/standards/national-wool-declaration-nwd
    /// 
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MulesingStatus
    {
        [Description("NM: Non Mulesed")]
        NM,

        [Description("LN: Liquid Nitrogen")]
        LN,

        [Description("CM: Ceased Mulesing")]
        CM,

        [Description("AA: Mulesed with Analgesic &/or Anaesthetic")]
        AA,

        [Description("M: Mulesed")]
        M,

        [Description("ND: Not Declared")]
        ND
    }
}
