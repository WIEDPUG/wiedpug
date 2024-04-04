using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiedpug.Domain.Entities
{
    public class TestCertificate
    {
        public required TestDataHeader  TestDataHeader { get; set; }

        public ColorDetails? ColorDetails { get; set; }

        public PremiumTestDetails? PremiumTestDetails { get; set; }

        public SubjectiveInterlotDetails? SubjectiveInterlotDetails { get; set;}

        public CombinationDetails? CombinationDetails {  get; set; }
        
        public LengthAndStrengthCombDetails? LengthAndStrengthCombDetails { get; set;}

        public LengthAndStrengthDetails? LengthAndStrengthDetails { get; set; }  

        public OMLDetails? OMLDetails { get; set; }

        public CoreTestDetails? CoreTestDetails { get; set; }

        public ColorCombinationDetails? ColorCombinationDetails { get; set; }

        public OMIDetails? OMIDetials {  get; set; }

        public PostSaleCoreTestDetails? PostSaleCoreTestDetails { get;set; }

        public GuidanceReporttDetails? GuidanceReporttDetails { get; set; }

        public ScouredTestDetails? ScouredTestDetails { get; set; }

        public DichloromethaneTestDetails? DichloromethaneTestDetails { get; set; }

        public ConditioningTestDetails? ConditioningTestDetails { get; set;}

        public LengthAfterCardingTestDetails? LengthAfterCardingTestDetails { get; set; }

        public AdjustmentNoteDetails? LengthAdjustmentNoteDetails { get; set;}

        /// <summary>
        /// A collection of Certificate Identities
        /// </summary>
        public List<string>? CertificateIdentities { get; set; }

        public List<FibreDiameterHistogram>? FibreDiameterHistograms { get; set; }

        public List<Bale>? Bales { get; set; }
    }
}
