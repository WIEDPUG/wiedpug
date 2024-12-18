using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates;
using Wiedpug.Domain.Aggregates.TestCertificateUpdateAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class TestCertificateUpdateRequestExample : IExamplesProvider<List<TestCertificateUpdate>>
    {
        public List<TestCertificateUpdate> GetExamples()
        {
            return new List<TestCertificateUpdate>()
            {
                new TestCertificateUpdate {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = new LiteralDate{ Date="2020-07-15"},
                    DateTransmissionFileCreated = new LiteralDate{ Date="2016-01-17" },
                    CountryOfOrigin = CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                        OrganisationCode = "ABC",
                    },
                    CurrentReceiver = new Organisation
                    {
                        OrganisationCode = "ATW",
                    },
                    VersionNumber = "1.10.1",
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.Talman,
                        SoftwareVersion =  1082
                    },
                    Abn = 72001967184
                },
                                TransferConfig = new TransferConfig
                {
                   TransferType = TransferType.Unrestrict
                },
                TestCertificateUpdateDetails = new List<TestCertificateUpdateDetail> {
                    new TestCertificateUpdateDetail {
                        CertificateIdentity =  new CertificateIdentity{
                                    CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                                    CertificateIdNumber = 16101382,
                                    CertificateIdSuffix = CertificateIdSuffix.L,
                                    CertificateIdCd = 6
                                },
                        ReissueType = ReissueType._06,
                        Client = new Organisation {
                            OrganisationCode = "ABC",
                        },
                        NumberOfBales = new NumberOfBales{BalesCount=2},
                        BaleDescription = new BaleDescription{ BaleDescriptionContent="AAA"},
                        WoolBase = 60.43,
                        MulesingStatusFrom = MulesingStatus.ND,
                        MulesingStatusTo = MulesingStatus.M
                    },
                    new TestCertificateUpdateDetail {
                        CertificateIdentity =  new CertificateIdentity{
                                    CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                                    CertificateIdNumber = 16101382,
                                    CertificateIdSuffix = CertificateIdSuffix.M,
                                    CertificateIdCd = 5
                                },
                        ReissueType = ReissueType._05,
                        Client = new Organisation {
                            OrganisationCode = "ABC",
                        },
                        NumberOfBales = new NumberOfBales{BalesCount=7},
                        BaleDescription = new BaleDescription{ BaleDescriptionContent="AAA"},
                        WoolBase = 65.12,
                        MulesingStatusFrom = MulesingStatus.AA,
                        MulesingStatusTo = MulesingStatus.M
                    },
                    new TestCertificateUpdateDetail {
                        CertificateIdentity =  new CertificateIdentity{
                                    CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                                    CertificateIdNumber = 15701332,
                                    CertificateIdSuffix = CertificateIdSuffix.B,
                                    CertificateIdCd = 6
                                },
                        ReissueType = ReissueType._02,
                        Client = new Organisation {
                            OrganisationCode = "ABC",
                        },
                        NumberOfBales = new NumberOfBales{BalesCount=8},
                        BaleDescription = new BaleDescription{BaleDescriptionContent="PCA" },
                        WoolBase = 50.31,
                        MulesingStatusFrom = MulesingStatus.NM,
                        MulesingStatusTo = MulesingStatus.M
                    }
                }
                }
            };
        }
    }

    public class RequestForDataForTestCertificateUpdateExample : IExamplesProvider<List<RequestForData>>
    {
        public List<RequestForData> GetExamples()
        {
            return new List<RequestForData>()
            {
                new RequestForData {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = new LiteralDate{ Date="2020-07-15"},
                    DateTransmissionFileCreated = new LiteralDate{ Date="2016-01-17" },
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                        OrganisationCode = "ABC",
                    },
                    CurrentReceiver = new Organisation
                    {
                        OrganisationCode = "ATW",
                    },
                    VersionNumber = "1.10.1",
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.AWTA,
                        SoftwareVersion =  1082
                    },
                    Abn = 72001967184
                },
                RequestForDataType = new UseNetworkDateTimeRequestForDataType
                {
                    IsUsingNetworkDateTime
                    = true
                }
                }
            };
        }
    }

    public class RequestForDataForTestCertificateUpdate200Example : IExamplesProvider<ApiResult<List<TestCertificateUpdate>>>
    {
        public ApiResult<List<TestCertificateUpdate>> GetExamples()
        {
            return new ApiResult<List<TestCertificateUpdate>>()
            {
                
                ApiMessages = [],
                Data = new List<TestCertificateUpdate>()
                {
                    new TestCertificateUpdate {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = new LiteralDate{ Date="2020-07-15"},
                        DateTransmissionFileCreated = new LiteralDate{ Date="2016-01-17" },
                        CountryOfOrigin = CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                            OrganisationCode = "ABC",
                        },
                        CurrentReceiver = new Organisation
                        {
                            OrganisationCode = "ATW",
                        },
                        VersionNumber = "1.10.1",
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = SoftwareCompany.Talman,
                            SoftwareVersion =  1082
                        },
                        Abn = 72001967184
                    },
                                    TransferConfig = new TransferConfig
                {
                   TransferType = TransferType.Unrestrict
                },
                    TestCertificateUpdateDetails = new List<TestCertificateUpdateDetail> {
                    new TestCertificateUpdateDetail {
                        CertificateIdentity =  new CertificateIdentity{
                                    CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                                    CertificateIdNumber = 16101382,
                                    CertificateIdSuffix = CertificateIdSuffix.L,
                                    CertificateIdCd = 6
                                },
                        ReissueType = ReissueType._06,
                        Client = new Organisation {
                            OrganisationCode = "ABC",
                        },
                        NumberOfBales = new NumberOfBales{BalesCount=2},
                        BaleDescription = new BaleDescription{ BaleDescriptionContent="AAA"},
                        WoolBase = 60.43,
                        MulesingStatusFrom = MulesingStatus.ND,
                        MulesingStatusTo = MulesingStatus.M
                    },
                    new TestCertificateUpdateDetail {
                        CertificateIdentity =  new CertificateIdentity{
                                    CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                                    CertificateIdNumber = 16101382,
                                    CertificateIdSuffix = CertificateIdSuffix.M,
                                    CertificateIdCd = 5
                                },
                        ReissueType = ReissueType._05,
                        Client = new Organisation {
                            OrganisationCode = "ABC",
                        },
                        NumberOfBales = new NumberOfBales{BalesCount=7},
                        BaleDescription = new BaleDescription{ BaleDescriptionContent="AAA"},
                        WoolBase = 65.12,
                        MulesingStatusFrom = MulesingStatus.AA,
                        MulesingStatusTo = MulesingStatus.M
                    },
                    new TestCertificateUpdateDetail {
                        CertificateIdentity =  new CertificateIdentity{
                                    CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                                    CertificateIdNumber = 15701332,
                                    CertificateIdSuffix = CertificateIdSuffix.B,
                                    CertificateIdCd = 6
                                },
                        ReissueType = ReissueType._02,
                        Client = new Organisation {
                            OrganisationCode = "ABC",
                        },
                        NumberOfBales = new NumberOfBales{BalesCount=8},
                        BaleDescription = new BaleDescription{BaleDescriptionContent="PCA" },
                        WoolBase = 50.31,
                        MulesingStatusFrom = MulesingStatus.NM,
                        MulesingStatusTo = MulesingStatus.M
                    }
                    }
                }
                }
        };
        }
    }


}
