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

        public ColourDetails? ColourDetails {  get; set; }
        
        public PremiumTestDetails? PremiumTestDetails { get; set;}

        public SubjectiveInterlotDetails? SubjectiveInterlotDetails { get;set; }

        public CombinationDetails? CombinationDetails { get; set; }

        public LengthAndStrengthCombDetails? LengthAndStrengthCombDetail { get; set; }
        public LengthAndStrengthDetails? LengthAndStrengthDetails { get; set;}

        public OMLDetails? OMLDetails { get; set; }

        public OMIDetails? OMIDetails { get; set;}

        public CoreTestDetails? CoreTestDetails { get; set; }

        public ColourCombinationDetails? ColourCombinationDetails { get; set; }

        public GuidanceReporttDetails? GuidanceReporttDetails { get; set; }

        [Required]
        public required List<LotHeaderVendorDeclaration> LotHeaderVendorDeclarations { set; get; }

        public List<FibreDiameterHistogram>? FibreDiameterHistograms { set; get; }

        [Required]
        public required List<Bale> Bales {  set; get; }
    }
}
