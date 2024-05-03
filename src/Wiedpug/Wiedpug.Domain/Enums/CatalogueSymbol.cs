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
        [Description("DumpedBales: Code: A. Dumped Bales")]
        DumpedBales,

        [Description("CharityoRGoodCause: Code: C. Charity/Good Cause")]
        CharityoRGoodCause,

        [Description("Debanded: Code: D. De-banded")]
        Debanded,

        [Description("LotOfferedUnderTrialSellingStatus: Code: G. Lot offered under Trial Selling Status")]
        LotOfferedUnderTrialSellingStatus,

        [Description("ClassedSamples: Code: H. Classed Samples (bearing Classing House stencil)")]
        ClassedSamples,

        [Description("MachineProcessed: Code: M. Machine processed (Decotted, crushed or blended)")]
        MachineProcessed,

        [Description("Fellmongered: Code: O. Fellmongered")]
        Fellmongered,

        [Description("ReconditionedFromWet: Code: R. Reconditioned from wet")]
        ReconditionedFromWet,

        [Description("WoolIsUnclassed: Code: S. Wool is unclassed")]
        WoolIsUnclassed,

        [Description("Tested: Code: T. Tested (where Test House is not AWTA)")]
        Tested,

        [Description("Unskirted: Code: U. Unskirted or Not Skirted to Code of Practice requirements")]
        Unskirted,

        [Description("BrokerClassed: Code: W. Broker (Re)classed (Classing House stencil - P cert. only)")]
        BrokerClassed,

        [Description("ContainsBrokerInspected: Code: X. Contains Broker Inspected (Classing House stencil - I cert. only)")]
        ContainsBrokerInspected,

        [Description("PigmentedAndOrMedullatedFibreRisk: Code: Y. Pigmented and/or Medullated Fibre Risk (Run with or Black section)")]
        PigmentedAndOrMedullatedFibreRisk
    }
}
