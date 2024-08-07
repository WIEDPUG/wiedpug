using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.PaymentAdviceAggregate;
using Wiedpug.Domain.Aggregates.PaymentAdviceDetailAggregate;
using Wiedpug.Domain.Aggregates.StatementsAggregate;
using Wiedpug.Domain.Aggregates.TestCertificateAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class CreateStatementsRequestExample : IExamplesProvider<Statements>
    {
        public Statements GetExamples()
        {
            return new Statements()
            {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = "2020-07-15",
                    DateTransmissionFileCreated = "2016-01-17",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    CurrentReceiver = new Organisation
                    {
                        OrganisationCode = "ATC",
                    },
                    DocumentOriginator = new Organisation
                    {
                        OrganisationCode = "ABC",
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
                StatementCollection = new List<Statement>
                {
                    new Statement
                    {
                        StatementHeader = new StatementHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationCode = "ADC",
                            },
                            ClientCode = 345678,
                            StatementDate = "2024-03-21",
                            DebitOrCreditFlagCurrent = DebitCreditFlag.Debit,
                            OpeningBalanceCurrent = new Currency { Value = 234.54, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag30 = DebitCreditFlag.Debit,
                            OpeningBalance30 = new Currency { Value = 365.50, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag60 = DebitCreditFlag.Debit,
                            OpeningBalance60 = new Currency { Value = 566.78, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag90 = DebitCreditFlag.Debit,
                            OpeningBalance90 = new Currency { Value = 234.34, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag90Plus = DebitCreditFlag.Debit,
                            OpeningBalance90Plus = new Currency { Value = 500.34, CurrencyUnit = CurrencyUnit.AUD }
                        },
                        StatementDetails = new List<StatementDetail>
                        {
                            new StatementDetail
                            {
                                ClientsReference = "1234567890",
                                AccountReference = "AWTA LED REFERENCE",
                                Amount = new Currency { Value = 866.30, CurrencyUnit = CurrencyUnit.AUD },
                                AmountType = AmountType.Invoice,
                                ItemDate = "2024-04-23",
                                GstAmount = new Currency { Value = 134.30, CurrencyUnit = CurrencyUnit.AUD },
                                IsGstTaxInvoiceApplicable = true,
                                IsCompanyABNApplicable = true
                            }
                        },
                        StatementTrailer = new StatementTrailer
                        {
                            DebitOrCreditFlagCurrent = DebitCreditFlag.Debit,
                            ClosingBalanceCurrent = new Currency { Value = 234.54, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag30 = DebitCreditFlag.Debit,
                            ClosingBalance30 = new Currency { Value = 365.50, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag60 = DebitCreditFlag.Debit,
                            ClosingBalance60 = new Currency { Value = 566.78, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag90 = DebitCreditFlag.Debit,
                            ClosingBalance90 = new Currency { Value = 234.34, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag90Plus = DebitCreditFlag.Debit,
                            ClosingBalance90Plus = new Currency { Value = 500.34, CurrencyUnit = CurrencyUnit.AUD }
                        }
                    }
                }

            };
        }
    }

    public class RequestForStatementsRequestExample : IExamplesProvider<RequestForDataRework>
    {
        public RequestForDataRework GetExamples()
        {
            return new RequestForDataRework()
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
                SaleIdentity = "M18",
                OrganisationRequested = new Organisation { OrganisationCode = "ANF", },
                SaleDateRequested = "2023-10-31",
                IsUsingNetworkDateTime = false,
                RequestType = Domain.Enums.RequestTypeForData.BroadcastDataRequest,
                WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                Season = 23
            };
        }
    }

    public class RequestForStatements200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                
                Message = null,
                Data = new Statements
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                            OrganisationCode = "ATC",
                        },
                        CurrentReceiver = new Organisation
                        {
                            OrganisationCode = "ATT",
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
                    StatementCollection = new List<Statement>
                {
                    new Statement
                    {
                        StatementHeader = new StatementHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationCode = "ATT",
                            },
                            ClientCode = 345678,
                            StatementDate = "2024-03-21",
                            DebitOrCreditFlagCurrent = DebitCreditFlag.Debit,
                            OpeningBalanceCurrent = new Currency { Value = 234.54, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag30 = DebitCreditFlag.Debit,
                            OpeningBalance30 = new Currency { Value = 365.50, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag60 = DebitCreditFlag.Debit,
                            OpeningBalance60 = new Currency { Value = 566.78, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag90 = DebitCreditFlag.Debit,
                            OpeningBalance90 = new Currency { Value = 234.54, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag90Plus = DebitCreditFlag.Debit,
                            OpeningBalance90Plus = new Currency { Value = 500.34, CurrencyUnit = CurrencyUnit.AUD }
                        },
                        StatementDetails = new List<StatementDetail>
                        {
                            new StatementDetail
                            {
                                ClientsReference = "1234567890",
                                AccountReference = "AWTA LED REFERENCE",
                                Amount = new Currency { Value = 866.30, CurrencyUnit = CurrencyUnit.AUD },
                                AmountType = AmountType.Invoice,
                                ItemDate = "2024-04-23",
                                GstAmount = new Currency { Value = 134.30, CurrencyUnit = CurrencyUnit.AUD },
                                IsGstTaxInvoiceApplicable = true,
                                IsCompanyABNApplicable = true
                            }
                        },
                        StatementTrailer = new StatementTrailer
                        {
                            DebitOrCreditFlagCurrent = DebitCreditFlag.Debit,
                            ClosingBalanceCurrent = new Currency { Value = 234.54, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag30 = DebitCreditFlag.Debit,
                            ClosingBalance30 = new Currency { Value = 365.50, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag60 = DebitCreditFlag.Debit,
                            ClosingBalance60 = new Currency { Value = 566.78, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag90 = DebitCreditFlag.Debit,
                            ClosingBalance90 = new Currency { Value = 234.54, CurrencyUnit = CurrencyUnit.AUD },
                            DebitOrCreditFlag90Plus = DebitCreditFlag.Debit,
                            ClosingBalance90Plus = new Currency { Value = 500.34, CurrencyUnit = CurrencyUnit.AUD }
                        }
                    }
                }



                }
            };
        }
    }
}
