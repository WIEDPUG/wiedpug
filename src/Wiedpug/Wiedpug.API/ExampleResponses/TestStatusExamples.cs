using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates;
using Wiedpug.Domain.Aggregates.TestStatusAggregate;
using Wiedpug.Domain.Aggregates.TextAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class TestStatusRequestExample : IExamplesProvider<TestStatus>
    {
        public TestStatus GetExamples()
        {
            return new TestStatus()
            {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = "2020-07-15",
                    DateTransmissionFileCreated = "2016-01-17",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
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
                        SoftwareCompany = SoftwareCompany.AWTA,
                        Version = 1082
                    },
                    ABN = "72001967184"
                },
                TestStatusDetails = new List<TestStatusDetail>
                {
                    new TestStatusDetail
                    {
                        CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                        WeightNote = new WeightNote{
                            Prefix = "1",
                            Suffix = "1234567",
                        },
                        ClientCode = "019944",
                        ChargeCode = "0511",
                        LSSampleID = "F885688",
                        CoreSampleReceived = "240423",
                        LSSampleReceived = "240424",
                        TRVMatched = "240424",
                        LsRetuftRequired = LsRetuftRequired.Required
                    },
                    new TestStatusDetail {
                        CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                        WeightNote = new WeightNote{
                            Prefix = "1",
                            Suffix = "1234567",
                        },
                        ClientCode = "019944",
                        ChargeCode = "0511",
                        LSSampleID = "F865734",
                        CoreSampleReceived = "240423",
                        LSSampleReceived = "240424",
                        TRVMatched = "240424"
                    }
                }
            };
        }


    }

    public class RequestForTestStatusExample : IExamplesProvider<RequestForData>
    {
        public RequestForData GetExamples()
        {
            return new RequestForData()
            {
                SaleIdentity = new Domain.Entities.SaleIdentity
                {
                    SellingCentreType = SellingCentreType.AU_M,
                    SaleNumber = 18
                },
                OrganisationRequested = new Organisation { OrganisationCode = "ANF" },
                SaleDateRequested = "2023-10-31",
                UseNetworkDateTime = false,
                RequestType = Domain.Enums.RequestTypeForData.BroadcastDataRequest,
                WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                Season = 23
            };
        }
    }

    public class RequestForTestStatus200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = true,
                Message = null,
                Data =  new TestStatus()
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
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
                            SoftwareCompany = SoftwareCompany.AWTA,
                            Version = 1082
                        },
                        ABN = "72001967184"
                    },
                    TestStatusDetails = new List<TestStatusDetail>
                {
                    new TestStatusDetail
                    {
                        CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                        WeightNote = new WeightNote{
                            Prefix = "1",
                            Suffix = "1234567",
                        },
                        ClientCode = "019944",
                        ChargeCode = "0511",
                        LSSampleID = "F885688",
                        CoreSampleReceived = "240423",
                        LSSampleReceived = "240424",
                        TRVMatched = "240424",
                        LsRetuftRequired = LsRetuftRequired.Required
                    },
                    new TestStatusDetail {
                        CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                        WeightNote = new WeightNote{
                            Prefix = "1",
                            Suffix = "1234567",
                        },
                        ClientCode = "019944",
                        ChargeCode = "0511",
                        LSSampleID = "F865734",
                        CoreSampleReceived = "240423",
                        LSSampleReceived = "240424",
                        TRVMatched = "240424"
                    }
                }
                }
        };
        }
    }
}
