namespace Wiedpug.Domain.Entities
{
    public class TestCertificate
    {
        public required TestDataHeader  TestDataHeader { get; set; }

        public List<TestDetails>? TestDetailsCollection { get; set; }

        public List<ColourTestDetails>? ColourTestDetailsCollection { get; set; }

        public List<LengthAndStrengthTestDetails>? LengthAndStrengthTestDetailsCollection { get; set; }

        public CombinationDetails? CombinationDetails {  get; set; }
        
        public DichloromethaneTestDetails? DichloromethaneTestDetails { get; set; }

        public ConditioningTestDetails? ConditioningTestDetails { get; set;}

        public LengthAfterCardingTestDetails? LengthAfterCardingTestDetails { get; set; }

        public AdjustmentNoteDetails? LengthAdjustmentNoteDetails { get; set;}

        /// <summary>
        /// A collection of Certificate Identities
        /// </summary>
        public List<CertificateIdentity>? SublotCertificateNumbers { get; set; }

        public List<FibreDiameterHistogram>? FibreDiameterHistograms { get; set; }

        public List<Bale>? Bales { get; set; }
    }
}
