using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Enums
{
    [Description("Where a line/lot contains a Pack with a lower condition, the lower condition shall apply. The hierarchy from highest to lowest is N, M, R, X. " +
        "This field is optional in New Zealand transmissions.")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PackCondition
    {
        [Description("N: New Pack (not previously used)")]
        N,
        [Description("M: Marked (not previously cored and grabbed")]
        M,
        [Description("R: Repaired (previously core and/or grabbed and repaired)")]
        R,
        [Description("X: Not repaired (previously cored and/or grabbed) (excl reoffer")]
        X
    }
}
