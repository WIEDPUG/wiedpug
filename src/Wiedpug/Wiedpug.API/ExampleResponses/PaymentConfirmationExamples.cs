using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.PaymentAdviceAggregate;
using Wiedpug.Domain.Aggregates.PaymentAdviceDetailAggregate;
using Wiedpug.Domain.Aggregates.PaymentConfirmationAggregate;
using Wiedpug.Domain.Aggregates.TestCertificateAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class CreatePaymentConfirmationRequestExample : IExamplesProvider<PaymentConfirmation>
    {
        public PaymentConfirmation GetExamples()
        {
            return new PaymentConfirmation()
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
                Confirmations = new List<Confirmation>{
                    new Confirmation {
                        PaymentHeader = new PaymentHeader
                        {
                            ClientCode= new Organisation
                            {
                                OrganisationId = "AWCED"
                            },
                            StatementDate="2024-05-11",
                            StatementPaymentDate="2024-06-01",
                            BankAccountNumber="456735",
                            BankBSBNumber="335567",
                            AmountWithheldPreviousStatements=672.23,
                            AmountWithheldThisStatement=690.45
                        },
                        PaymentDetails = new List<PaymentDetail> { 
                            new PaymentDetail
                            {
                                StatementDate="2024-05-12",
                                Amount=723.23,
                                AccountReference="12345678901",
                                PaymentType=PaymentType.Paid
                            }
                        }
                    }
                }
            };
        }
    }

    public class RequestForPaymentConfirmationRequestExample : IExamplesProvider<RequestForPaymentConfirmation>
    {
        public RequestForPaymentConfirmation GetExamples()
        {
            return new RequestForPaymentConfirmation()
            {
                SaleIdentity = new Domain.Entities.SaleIdentity
                {
                    SellingCentreType =SellingCentreType.AU_F,
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

    public class RequestForPaymentConfirmation200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = true,
                Message = null,
                Data = new PaymentConfirmation
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                            OrganisationId = "AWTA"
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
                    Confirmations = new List<Confirmation>{
                    new Confirmation {
                        PaymentHeader = new PaymentHeader
                        {
                            ClientCode= new Organisation
                            {
                                OrganisationId = "AWCED"
                            },
                            StatementDate="2024-05-11",
                            StatementPaymentDate="2024-06-01",
                            BankAccountNumber="456735",
                            BankBSBNumber="335567",
                            AmountWithheldPreviousStatements=672.23,
                            AmountWithheldThisStatement=690.45
                        },
                        PaymentDetails = new List<PaymentDetail> {
                            new PaymentDetail
                            {
                                StatementDate="2024-05-12",
                                Amount=723.23,
                                AccountReference="12345678901",
                                PaymentType=PaymentType.Paid
                            }
                        }
                    }
                }
                }
            };
        }
    }
}
