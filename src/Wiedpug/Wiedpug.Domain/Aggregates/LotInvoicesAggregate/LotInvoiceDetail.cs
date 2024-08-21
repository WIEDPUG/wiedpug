using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiedpug.Domain.Entities;

namespace Wiedpug.Domain.Aggregates.LotInvoicesAggregate
{
    public class LotInvoiceDetail
    {
        [Required]
        public required LotInvoiceHeader LotInvoiceHeader { get; set; }

        [Required]
        public required LotInvoiceExtension LotInvoiceExtension { get; set; }

        public TestDetail? TestDetail { get; set; }

        public ColourTestDetail? ColourTestDetail { get; set; }

        public LengthAndStrengthTestDetail? LengthAndStrengthTestDetail { get; set; }

        [Required]
        public required List<LotHeaderVendorDeclaration> LotHeaderVendorDeclarations { set; get; }

        public List<FibreDiameterHistogram>? FibreDiameterHistograms { set; get; }

        [Required]
        public required List<Bale> Bales {  set; get; }
    }
}
