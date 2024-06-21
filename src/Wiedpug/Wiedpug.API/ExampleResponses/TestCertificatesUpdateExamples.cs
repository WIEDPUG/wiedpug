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
                    DateFormatLastRevised = "2020-07-15",
                    DateTransmissionFileCreated = "2016-01-17",
                    CountryOfOrigin = CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                        OrganizationCode = "ABCD"
                    },
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
                        CertificateIdentity =  new CertificateIdentity{
                                    CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                                    CertificateIDNumber = "16101382",
                                    CertificateIDSuffix = CertificateIDSuffix.L,
                                    CertificateIDCD = 6
                                },
                        ReissueType = ReissueType._06,
                        Client = new Organisation { OrganizationCode = "AABBC" },
                        Bales = 2,
                        BaleDescription = "AAA M",
                        WoolBase = 60.43,
                        MulesingStatusFrom = MulesingStatus.ND,
                        MulesingStatusTo = MulesingStatus.M
                    },
                    new TestCertificateUpdateDetail {
                        CertificateIdentity =  new CertificateIdentity{
                                    CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                                    CertificateIDNumber = "16101382",
                                    CertificateIDSuffix = CertificateIDSuffix.M,
                                    CertificateIDCD = 5
                                },
                        ReissueType = ReissueType._05,
                        Client = new Organisation { OrganizationCode = "ACAC" },
                        Bales = 7,
                        BaleDescription = "AAA M",
                        WoolBase = 65.12,
                        MulesingStatusFrom = MulesingStatus.AA,
                        MulesingStatusTo = MulesingStatus.M
                    },
                    new TestCertificateUpdateDetail {
                        CertificateIdentity =  new CertificateIdentity{
                                    CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                                    CertificateIDNumber = "15701332",
                                    CertificateIDSuffix = CertificateIDSuffix.B,
                                    CertificateIDCD = 6
                                },
                        ReissueType = ReissueType._02,
                        Client = new Organisation { OrganizationCode = "AAAAA" },
                        Bales = 8,
                        BaleDescription = "PCA M",
                        WoolBase = 50.31,
                        MulesingStatusFrom = MulesingStatus.NM,
                        MulesingStatusTo = MulesingStatus.M
                    }
                }
            };
        }
    }
}
