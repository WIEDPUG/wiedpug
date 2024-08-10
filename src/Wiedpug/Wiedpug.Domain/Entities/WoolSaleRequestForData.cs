using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Interface;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class WoolSaleRequestForData
    {

        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        [Required]
        public required IWoolSaleRequestForDataType RequestForDataType { get; set; }
    }
}
