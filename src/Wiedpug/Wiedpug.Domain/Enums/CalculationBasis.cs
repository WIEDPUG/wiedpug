using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [Description("This is used to identify the method used to calculate the post sale charge. " +
        "The post sale charge may be a per bale, per kilogram or percentage of the price of the wool. " +
        "Calculation Basis is always per bale in Australia.")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CalculationBasis
    {
        [Description("B: Post sale charge is levied per bale")]
        B,

        [Description("K: The post sale charge is a charge per kil")]
        K,

        [Description("P: The post sale charge is a % of first cost")]
        P
    }
}
