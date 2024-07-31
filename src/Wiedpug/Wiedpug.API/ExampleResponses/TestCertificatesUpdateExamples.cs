using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates;
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
                        OrganisationCode = "ABC",
                    },
                    CurrentReceiver = new Organisation
                    {
                        OrganisationCode = "ATW",
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
                        Client = new Organisation {
                            OrganisationCode = "ABC",
                        },
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
                        Client = new Organisation {
                            OrganisationCode = "ABC",
                        },
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
                        Client = new Organisation {
                            OrganisationCode = "ABC",
                        },
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

    public class RequestForDataForTestCertificateUpdateExample : IExamplesProvider<RequestForData>
    {
        public RequestForData GetExamples()
        {
            return new RequestForData()
            {
                SaleIdentity = new Domain.Entities.SaleIdentity
                {
                    SellingCentreType = SellingCentreType.AU_F,
                    SaleNumber = 18
                },
                OrganisationRequested = new Organisation { OrganisationCode = "ANF", },
                SaleDateRequested = "2023-10-31",
                IsUsingNetworkDateTime = false,
                RequestType = Domain.Enums.RequestTypeForData.BroadcastDataRequest,
                WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                Season = 23
            };
        }
    }

    public class RequestForDataForTestCertificateUpdate200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                
                Message = null,
                Data = new TestCertificateUpdate()
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
                        CountryOfOrigin = CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                            OrganisationCode = "ABC",
                        },
                        CurrentReceiver = new Organisation
                        {
                            OrganisationCode = "ATW",
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
                        Client = new Organisation {
                            OrganisationCode = "ABC",
                        },
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
                        Client = new Organisation {
                            OrganisationCode = "ABC",
                        },
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
                        Client = new Organisation {
                            OrganisationCode = "ABC",
                        },
                        Bales = 8,
                        BaleDescription = "PCA M",
                        WoolBase = 50.31,
                        MulesingStatusFrom = MulesingStatus.NM,
                        MulesingStatusTo = MulesingStatus.M
                    }
                }
                }
        };
        }
    }


}
