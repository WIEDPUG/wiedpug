using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    /// <summary>
    /// Used to define the type of catalogue
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CatalogueType
    {
        [Description("A: Auction Catalogues")]
        A,

        [Description("P: Private Catalogues")]
        P
    }
}
