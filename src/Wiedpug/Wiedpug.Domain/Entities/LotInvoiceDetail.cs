using System.ComponentModel.DataAnnotations;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Shared.Constants;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.Domain.Entities
{
    public class LotInvoiceDetail
    {
        [Required]
        public required LotInvoiceHeader LotInvoiceHeader { get; set; }

        public ColourDetails? ColourDetails { get; set; }

        public PremiumTestDetails? PremiumTestDetails {  get; set; }

        public SubjectiveInterlotDetails? SubjectiveInterlotDetails { get; set; }

        public CombinationDetails? CombinationDetails { get; set; }

        public LengthAndStrengthCombDetails? LengthAndStrengthCombDetails { get;set; }

        public LengthAndStrengthDetails? LengthAndStrengthDetails { get; set;}  

        public OMLDetails? OMLDetails { get; set; }

        public CoreTestDetails? CoreTestDetails { get; set; } 

        public ColourCombinationDetails? ColourCombinationDetails { get; set; } = null;

        public OMIDetails? OMIDetails { get; set;}

        public GuidanceReportDetails? GuidanceReporttDetails { get; private set; }

        public required List<LotHeaderVendorDeclaration> LotHeaderVendorDeclarations { get; set; }

        public List<FibreDiameterHistogram>? FibreDiameterHistograms { get; set; }   

        public required List<Bale> Bales { get; set; }
    }
}
