using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CoreTestRecoreRequired
    {
        [Description("Required: Code: 1. Core Test Recore is required – bales must be resampled to complete core test")]
        Required,

        [Description("Received: Code: 2. Core Test Recore sample received in laboratory")]
        Received,

        [Description("InProgress Code: 3. Core Test Recore testing in progress")]
        InProgress

    }
}
