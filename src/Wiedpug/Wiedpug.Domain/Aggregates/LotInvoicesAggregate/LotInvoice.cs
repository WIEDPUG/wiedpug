using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Aggregates.LotInvoicesAggregate
{
    public class LotInvoice
    {
        [Required]
        public required TransmissionHeader TransmissionHeader { get; set; }

        public List<Organisation>? FinalRecieverList { get; set; }

        [Required]
        public required List<WoolSale> WoolSales { get; set; }
    }
}
