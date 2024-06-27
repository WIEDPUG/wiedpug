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
    public class CreateTextsRequestExample : IExamplesProvider<Texts>
    {
        public Texts GetExamples()
        {
            return new Texts()
            {
                TextList = new List<Text>
                {
                    new Text
                    {
                        TransmissionHeader = new TransmissionHeader
                        {
                            DateFormatLastRevised = "2020-07-15",
                            DateTransmissionFileCreated = "2016-01-17",
                            CountryOfOrigin = Domain.Enums.CountryCode.AU,
                            DocumentOriginator = new Organisation
                            {
                                OrganisationId = "ABCD"
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
                        FinalReceiverList = new List<Organisation>
                        {
                            new Organisation
                            {
                                OrganisationId = "BAAT"
                            }
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

    public class RequestForTextsRequestExample : IExamplesProvider<RequestForTexts>
    {
        public RequestForTexts GetExamples()
        {
            return new RequestForTexts()
            {
                SaleIdentity = new Domain.Entities.SaleIdentity
                {
                    SellingCentreType = SellingCentreType.AU_M,
                    SaleNumber = 18
                },
                OrganisationRequested = "AWNF",
                SaleDateRequested = "2023-10-31",
                UseNetworkDateTime = false,
                RequestType = Domain.Enums.RequestTypeForData.BroadcastDataRequest,
                WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                Season = 23
            };
        }
    }

    public class RequestForTexts200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = true,
                Message = null,
                Data = new Texts
                {
                    TextList = new List<Text>
                {
                    new Text
                    {
                        TransmissionHeader = new TransmissionHeader
                        {
                            DateFormatLastRevised = "2020-07-15",
                            DateTransmissionFileCreated = "2016-01-17",
                            CountryOfOrigin = Domain.Enums.CountryCode.AU,
                            DocumentOriginator = new Organisation
                            {
                                OrganisationId = "ABCD"
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
                        FinalReceiverList = new List<Organisation>
                        {
                            new Organisation
                            {
                                OrganisationId = "BAAT"
                            }
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

                }
            };
        }
    }
}
