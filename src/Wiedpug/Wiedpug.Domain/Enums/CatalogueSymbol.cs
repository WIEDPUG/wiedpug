using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Wiedpug.Domain.Enums
{
    [Description("These are the symbols defined in the AWEX Wool Selling Rules. If this field has no value, it will indicate that there are no catalogue symbols for that lot" +
        "To obtain the current code list of values that may be used in this field please go to this URL: http://www.awex.com.au/standards/catalogue")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CatalogueSymbol
    {
        [Description("A: Dumped Bales")]
        A,
        [Description("C: Charity/Good Cause")]
        C,
        [Description("D: De-banded")]
        D,
        [Description("G: Lot offered under Trial Selling Status")]
        G,
        [Description("H: Classed Samples (bearing Classing House stencil)")]
        H,
        [Description("M: Machine processed (Decotted, crushed or blended)")]
        M,
        [Description("O: Fellmongered")]
        O,
        [Description("R: Reconditioned from wet")]
        R,
        [Description("S: Wool is unclassed")]
        S,
        [Description("T: Tested (where Test House is not AWTA)")]
        T,
        [Description("U: Unskirted or Not Skirted to Code of Practice requirements")]
        U,
        [Description("W: Broker (Re)classed (Classing House stencil - P cert. only)")]
        W,
        [Description("X: Contains Broker Inspected (Classing House stencil - I cert. only)")]
        X,
        [Description("Y: Pigmented and/or Medullated Fibre Risk (Run with or Black section)")]
        Y
    }
}
