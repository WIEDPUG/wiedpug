using System.ComponentModel;
using System.Text.Json.Serialization;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Enums
{
     [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ReissueType
    {
        [Description(" WoolPreparationCategoryChange: Code: 01. Wool Preparation Category (WPC) Change")]
        WoolPreparationCategoryChange,

        [Description("MulesingStatusChange: Code: 02. Mulesing Status (MS) Change")]
        MulesingStatusChange,

        [Description("SaleLotChange: Code: 03. Sale/Lot Change")]
        SaleLotChange,

        [Description("WoolPreparationCategoryAndMulesingStatusChange: Code: 04. WPC and MS Change")]
        WoolPreparationCategoryAndMulesingStatusChange,

        [Description("WoolPreparationCategoryAndSaleLotChange: Code: 05. WPC and Sale/Lot Change")]
        WoolPreparationCategoryAndSaleLotChange,

        [Description("MulesingStatusAndSaleLotChange: Code: 06. MS and Sale/Lot Change")]
        MulesingStatusAndSaleLotChange,

        [Description("WoolPreparationCategoryAndMulesingStatusAndSaleLotChange: Code: 07. WPC, MS and Sale/Lot Change")]
        WoolPreparationCategoryAndMulesingStatusAndSaleLotChange
    }
}
