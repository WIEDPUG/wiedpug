using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CatalogueType
    {
        [Description("A: Auction Catalogues")]
        A,

        [Description("P: Private Catalogues")]
        P
    }
}
