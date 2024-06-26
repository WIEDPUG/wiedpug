namespace Wiedpug.Domain.Entities
{
    public class TestCertificate
    {
        public required TestCertificateTestDataHeader  TestDataHeader { get; set; }

        public TestCertificateColourDetails? ColorDetails { get; set; }

        public TestCertificatePremiumTestDetails? PremiumTestDetails { get; set; }

        public TestCertificateSubjectiveInterlotDetails? SubjectiveInterlotDetails { get; set;}

        public TestCertificateCombinationDetails? CombinationDetails {  get; set; }
        
        public TestCertificateLengthAndStrengthCombDetails? LengthAndStrengthCombDetails { get; set;}

        public TestCertificateLengthAndStrengthDetails? LengthAndStrengthDetails { get; set; }  

        public TestCertificateOMLDetails? OMLDetails { get; set; }

        public TestCertificateCoreTestDetails? CoreTestDetails { get; set; }

        public TestCertificateColourCombinationDetails? ColorCombinationDetails { get; set; }

        public TestCertificateOMIDetails? OMIDetials {  get; set; }

        public PostSaleCoreTestDetails? PostSaleCoreTestDetails { get;set; }

        public GuidanceReportDetails? GuidanceReporttDetails { get; set; }

        public ScouredTestDetails? ScouredTestDetails { get; set; }

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
