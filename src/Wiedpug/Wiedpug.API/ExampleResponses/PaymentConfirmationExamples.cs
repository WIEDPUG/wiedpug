using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.PaymentAdviceAggregate;
using Wiedpug.Domain.Aggregates.PaymentConfirmationAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class CreatePaymentConfirmationRequestExample : IExamplesProvider<List<PaymentConfirmation>>
    {
        public List<PaymentConfirmation> GetExamples()
        {
            return new List<PaymentConfirmation>()
            {
                new PaymentConfirmation() {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = new LiteralDate{ Date="2020-07-15"},
                    DateTransmissionFileCreated = new LiteralDate{ Date="2016-01-17" },
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                        OrganisationCode = "ATW",
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
                Confirmations = new List<Confirmation>{
                    new Confirmation {
                        PaymentHeader = new PaymentHeader
                        {
                            ClientCode= 55674,
                            StatementDate= new LiteralDate{Date="2024-05-11" },
                            StatementPaymentDate=new LiteralDate{Date="2024-06-01" },
                            BankAccountNumber= 456735,
                            BankBsbNumber=335567,
                            AmountRemitted = new Currency{
                                                Value = 262.00,
                                                CurrencyCode =CurrencyCode.AUD
                                            },
                            AmountWithheldPreviousStatements= new Currency{
                                                Value = 672.23,
                                                CurrencyCode =CurrencyCode.AUD
                                            },
                            AmountWithheldThisStatement=new Currency{
                                                Value = 690.45,
                                                CurrencyCode =CurrencyCode.AUD
                                            },
                        },
                        PaymentDetails = new List<PaymentDetail> {
                            new PaymentDetail
                            {
                                StatementDate=new LiteralDate{Date="2024-05-12" },
                                Amount=new Currency{
                                                Value = 723.23,
                                                CurrencyCode =CurrencyCode.AUD
                                            },
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

    public class RequestForPaymentConfirmationRequestExample : IExamplesProvider<List<RequestForData>>
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

    public class RequestForPaymentConfirmation200Example : IExamplesProvider<ApiResult<List<PaymentConfirmation>>>
    {
        public ApiResult<List<PaymentConfirmation>> GetExamples()
        {
            return new ApiResult<List<PaymentConfirmation>>()
            {
                
                ApiMessages = [],
                Data = new List<PaymentConfirmation>
                {
                    new PaymentConfirmation {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = new LiteralDate{ Date="2020-07-15"},
                        DateTransmissionFileCreated = new LiteralDate{ Date="2016-01-17" },
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                            OrganisationCode = "ATW",
                        },
                        CurrentReceiver = new Organisation
                        {
                            OrganisationCode = "ATC",
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
                    Confirmations = new List<Confirmation>{
                    new Confirmation {
                        PaymentHeader = new PaymentHeader
                        {
                            ClientCode= 223350,
                            StatementDate= new LiteralDate{Date="2024-05-11" },
                            StatementPaymentDate=new LiteralDate{Date="2024-06-01" },
                            BankAccountNumber= 456735,
                            BankBsbNumber=335567,
                            AmountRemitted = new Currency{
                                                Value = 262.00,
                                                CurrencyCode =CurrencyCode.AUD
                                            },
                            AmountWithheldPreviousStatements=new Currency { Value = 672.23, CurrencyCode = CurrencyCode.AUD },
                            AmountWithheldThisStatement=new Currency { Value = 690.45, CurrencyCode = CurrencyCode.AUD }
                        },
                        PaymentDetails = new List<PaymentDetail> {
                            new PaymentDetail
                            {
                                StatementDate=new LiteralDate{Date="2024-05-12" },
                                Amount=new Currency { Value = 693.00, CurrencyCode = CurrencyCode.AUD },
                                AccountReference="12345678901",
                                PaymentType=PaymentType.Paid
                            }
                        }
                    }
                    }
                }
                }
            };
        }
    }
}
