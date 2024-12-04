using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.PaymentAdviceAggregate;
using Wiedpug.Domain.Aggregates.PaymentAdviceDetailAggregate;
using Wiedpug.Domain.Aggregates.StatementsAggregate;
using Wiedpug.Domain.Aggregates.TestCertificateAggregate;
using Wiedpug.Domain.Aggregates.TextAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class CreateTextsRequestExample : IExamplesProvider<List<Text>>
    {
        public List<Text> GetExamples()
        {
            return new List<Text>
            {
                    new Text
                    {
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
                                SoftwareCompany = SoftwareCompany.Talman,
                                SoftwareVersion =  1082
                            },
                            Abn = 72001967184
                        },
                        TransferConfig = new TransferConfig
                        {
                            TransferType = TransferType.Unrestrict
                        },
                        Comments = new List<Comment> 
                        {
                            new Comment
                            {
                                Text = "Order is paid."
                            }    
                        }

                    }

            };
        }
    }

    public class RequestForTextsRequestExample : IExamplesProvider<List<RequestForData>>
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
                RequestForDataType = new DateTimeRangeRequestForDataType
                {
                    StartDateTimeStatusRequest = new UtcDateTime{DateTime="2024-03-21T19:25:04Z"}
                }
                }
            };
        }
    }

    public class RequestForTexts200Example : IExamplesProvider<ApiResult<List<Text>>>
    {
        public ApiResult<List<Text>> GetExamples()
        {
            return new ApiResult<List<Text>>()
            {
                
                ApiMessages = [],
                Data = new List<Text>
                {
                    new Text
                    {
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
                                SoftwareCompany = SoftwareCompany.Talman,
                                SoftwareVersion =  1082
                            },
                            Abn = 72001967184
                        },
                        Comments = new List<Comment>
                        {
                            new Comment
                            {
                                Text = "Order is paid."
                            }
                        }

                    }

                }
            };
        }
    }
}
