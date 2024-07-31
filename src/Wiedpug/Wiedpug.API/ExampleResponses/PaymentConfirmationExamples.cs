using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.PaymentConfirmationAggregate;
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
                        OrganisationCode = "ATW",
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
                Confirmations = new List<Confirmation>{
                    new Confirmation {
                        PaymentHeader = new PaymentHeader
                        {
                            ClientCode= "ATC",
                            StatementDate="2024-05-11",
                            StatementPaymentDate="2024-06-01",
                            BankAccountNumber="456735",
                            BankBSBNumber="335567",
                            AmountRemitted = new Currency{
                                                Value = 262.00,
                                                CurrencyUnit =CurrencyUnit.AUD
                                            },
                            AmountWithheldPreviousStatements= new Currency{
                                                Value = 672.23,
                                                CurrencyUnit =CurrencyUnit.AUD
                                            },
                            AmountWithheldThisStatement=new Currency{
                                                Value = 690.45,
                                                CurrencyUnit =CurrencyUnit.AUD
                                            },
                        },
                        PaymentDetails = new List<PaymentDetail> { 
                            new PaymentDetail
                            {
                                StatementDate="2024-05-12",
                                Amount=new Currency{
                                                Value = 723.23,
                                                CurrencyUnit =CurrencyUnit.AUD
                                            },
                                AccountReference="12345678901",
                                PaymentType=PaymentType.Paid
                            }
                        }
                    }
                }
            };
        }
    }

    public class RequestForPaymentConfirmationRequestExample : IExamplesProvider<RequestForData>
    {
        public RequestForData GetExamples()
        {
            return new RequestForData()
            {
                SaleIdentity = new Domain.Entities.SaleIdentity
                {
                    SellingCentreType =SellingCentreType.AU_F,
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

    public class RequestForPaymentConfirmation200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                
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
                            OrganisationCode = "ATW",
                        },
                        CurrentReceiver = new Organisation
                        {
                            OrganisationCode = "ATC",
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
                            ClientCode= "ATC",
                            StatementDate="2024-05-11",
                            StatementPaymentDate="2024-06-01",
                            BankAccountNumber="456735",
                            BankBSBNumber="335567",
                            AmountRemitted = new Currency{
                                                Value = 262.00,
                                                CurrencyUnit =CurrencyUnit.AUD
                                            },
                            AmountWithheldPreviousStatements=new Currency { Value = 672.23, CurrencyUnit = CurrencyUnit.AUD },
                            AmountWithheldThisStatement=new Currency { Value = 690.45, CurrencyUnit = CurrencyUnit.AUD }
                        },
                        PaymentDetails = new List<PaymentDetail> {
                            new PaymentDetail
                            {
                                StatementDate="2024-05-12",
                                Amount=new Currency { Value = 693.00, CurrencyUnit = CurrencyUnit.AUD },
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
