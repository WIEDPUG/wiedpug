using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;

namespace Wiedpug.Domain.Errors
{
    public class InvalidCatalogueError
    {
        [MinLength(1)]
        [MaxLength(80)]
        public readonly ErrorCode ErrorCode = ErrorCode.INVAC;

        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Explanation = " Invalid sale aann/nn dd/mm/yy ooooo. All data rejected.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Reason = "For AC transmission, the sale number, season, sale date or selling organisation on the WoolSaleHeaderLots cannot be found on the network sale roster file. Data up to the next WoolSaleHeaderLots will be rejected.";

        [MinLength(1)]
        [MaxLength(80)]
        public readonly string Action = "Check data sent and if ok, resend later after sale roster file has been updated. Otherwise resend the data with the correct WoolSaleHeaderLots. An INVAC message will be sent for each invali dWoolSaleHeaderLots within a transmission file.";
    }
}
