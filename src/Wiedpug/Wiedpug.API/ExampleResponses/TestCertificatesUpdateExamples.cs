using Swashbuckle.AspNetCore.Filters;
using Wiedpug.Domain.Aggregates.TestCertificateUpdateAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class TestCertificateUpdateRequestExample : IExamplesProvider<TestCertificateUpdate>
    {
        public TestCertificateUpdate GetExamples()
        {
            return new TestCertificateUpdate()
            {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = "200715",
                    DateTransmissionFileCreated = "160117",
                    CountryOfOrigin = CountryCode.AU,
                    DocumentOriginator = "ABCD",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXLC",
                    FinalReceiver = "AWXLC",
                    TransmissionType = TransmissionType.TestCertificateUpdate,
                    VersionNumber = 31,
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.Talman,
                        Version = 1082
                    },
                    ABN = "72001967184"
                },
                TestCertificateUpdateDetails = new List<TestCertificateUpdateDetail> {
                    new TestCertificateUpdateDetail { 
                        CertificateIdentity = "316101382L6",
                        ReissueType = ReissueType._06,
                        Client = "AABBC",
                        Bales = 2,
                        BaleDescription = "AAA M",
                        WoolBase = 60.43m,
                        WoolPreparationCategoryFrom = null,
                        WoolPreparationCategoryTo = null,
                        MulesingStatusFrom = MulesingStatus.ND,
                        MulesingStatusTo = MulesingStatus.M,
                        SaleIdentityFrom = null,
                        SaleIdentityTo = null,
                        LotIdentityFrom = null,
                        LotIdentityTo = null
                    },
                    new TestCertificateUpdateDetail {
                        CertificateIdentity = "316071189T5",
                        ReissueType = ReissueType._05,
                        Client = "ACAC",
                        Bales = 7,
                        BaleDescription = "AAA M",
                        WoolBase = 65.12m,
                        WoolPreparationCategoryFrom = null,
                        WoolPreparationCategoryTo = null,
                        MulesingStatusFrom = MulesingStatus.AA,
                        MulesingStatusTo = MulesingStatus.M,
                        SaleIdentityFrom = null,
                        SaleIdentityTo = null,
                        LotIdentityFrom = null,
                        LotIdentityTo = null
                    },
                    new TestCertificateUpdateDetail {
                        CertificateIdentity = "315701332B6",
                        ReissueType = ReissueType._02,
                        Client = "AAAAA",
                        Bales = 8,
                        BaleDescription = "PCA M",
                        WoolBase = 50.31m,
                        WoolPreparationCategoryFrom = null,
                        WoolPreparationCategoryTo = null,
                        MulesingStatusFrom = MulesingStatus.NM,
                        MulesingStatusTo = MulesingStatus.M,
                        SaleIdentityFrom = null,
                        SaleIdentityTo = null,
                        LotIdentityFrom = null,
                        LotIdentityTo = null
                    }
                }
            };
        }
    }
}
