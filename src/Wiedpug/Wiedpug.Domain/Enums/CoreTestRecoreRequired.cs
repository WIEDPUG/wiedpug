using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Wiedpug.Domain.Enums
{
    public enum CoreTestRecoreRequired
    {
        [Description("1: Core Test Recore is required – bales must be resampled to complete core test")]
        Required = 1,

        [Description("2: Core Test Recore sample received in laboratory")]
        Received = 2,

        [Description("3: Core Test Recore testing in progress")]
        InProgress = 3

    }
}
