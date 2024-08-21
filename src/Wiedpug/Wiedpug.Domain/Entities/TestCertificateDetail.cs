namespace Wiedpug.Domain.Entities
{
    public class TestCertificateDetail
    {
        public required TestDataHeader  TestDataHeader { get; set; }

        public TestDetail? TestDetail { get; set; }

        public ColourTestDetail? ColourTestDetail { get; set; }

        public LengthAndStrengthTestDetail? LengthAndStrengthTestDetail { get; set; }
        
        public DichloromethaneTestDetail? DichloromethaneTestDetail { get; set; }

        public ConditioningTestDetail? ConditioningTestDetail { get; set;}

        public LengthAfterCardingTestDetail? LengthAfterCardingTestDetail { get; set; }

        public AdjustmentNoteDetail? AdjustmentNoteDetail { get; set;}

        /// <summary>
        /// A collection of Certificate Identities
        /// </summary>
        public List<CertificateIdentity>? SublotCertificateNumbers { get; set; }

        public List<FibreDiameterHistogram>? FibreDiameterHistograms { get; set; }

        public List<Bale>? Bales { get; set; }
    }
}
