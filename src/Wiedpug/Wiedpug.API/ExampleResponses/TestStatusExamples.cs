using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates;
using Wiedpug.Domain.Aggregates.TestStatusAggregate;
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
                    DocumentOriginator = "ABCD",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXLC",
                    FinalReceiver = "AWXLC",
                    TransmissionType = TransmissionType.TestCertificate,
                    VersionNumber = 31,
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = "Talman",
                        Version = 10820
                    },
                    Abn = "72001967184"
                },
                TestStatusDetails = new List<TestStatusDetail>
                {
                    new TestStatusDetail
                    {
                        CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                        WeightNote = "1111877",
                        ClientCode = "019944",
                        ChargeCode = "0511",
                        LSSampleID = "F885688",
                        CoreSampleReceived = "2024-04-23",
                        LSSampleReceived = "2024-04-24",
                        TRVMatched = "2024-04-24",
                        CoreSampleCheckTest = null,
                        LsRetuftRequired = LsRetuftRequired.Required,
                        LsRetuftReceived = null,
                        CoreTestRecoreRequired = null,
                        CoreTestRecoreReceived = null
                    },
                    new TestStatusDetail {
                        CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                        WeightNote = "1111832",
                        ClientCode = "019944",
                        ChargeCode = "0511",
                        LSSampleID = "F865734",
                        CoreSampleReceived = "2024-04-23",
                        LSSampleReceived = "2024-04-24",
                        TRVMatched = "2024-04-24",
                        CoreSampleCheckTest = null,
                        LsRetuftRequired = null,
                        LsRetuftReceived = null,
                        CoreTestRecoreRequired = null,
                        CoreTestRecoreReceived = null
                    }
                }
            };
        }
    }
}
