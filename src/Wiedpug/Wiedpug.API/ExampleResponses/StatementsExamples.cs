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
    public class CreateStatementsRequestExample : IExamplesProvider<List<Statements>>
    {
        public List<Statements> GetExamples()
        {
            return new List<Statements>()
            {
                new Statements(){
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = new LiteralDate{ Date="2020-07-15"},
                    DateTransmissionFileCreated = new LiteralDate{ Date="2016-01-17" },
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    CurrentReceiver = new Organisation
                    {
                        OrganisationCode = "ATC",
                    },
                    DocumentOriginator = new Organisation
                    {
                        OrganisationCode = "ABC",
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
                        StatementHeader = new StatementHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationCode = "ADC",
                            },
                            ClientCode = 345678,
                            StatementDate = new LiteralDate{ Date="2024-03-21"},
                            OpeningBalances = new List<Balance>
                            {
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.Current,
                                    BalanceValue = new Currency { Value = 234.54, CurrencyCode = CurrencyCode.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.Thirty,
                                    BalanceValue = new Currency { Value = 365.50, CurrencyCode = CurrencyCode.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.Sixty,
                                    BalanceValue = new Currency { Value = 566.78, CurrencyCode = CurrencyCode.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.Ninety,
                                    BalanceValue = new Currency { Value = 234.34, CurrencyCode = CurrencyCode.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.Ninety,
                                    BalanceValue = new Currency { Value = 500.34, CurrencyCode = CurrencyCode.AUD },
                                },
                            },
                        },
                        StatementDetails = new List<StatementDetail>
                        {
                            new StatementDetail
                            {
                                ClientsReference = "1234567890",
                                AccountReference = "AWTA LED REFERENCE",
                                Amount = new Currency { Value = 866.30, CurrencyCode = CurrencyCode.AUD },
                                AmountType = AmountType.Invoice,
                                ItemDate = new LiteralDate{ Date="2024-04-23"},
                                GstAmount = new Currency { Value = 134.30, CurrencyCode = CurrencyCode.AUD },
                                IsGstApplicable = true,
                                IsCompanyAbnApplicable = true
                            }
                        },
                        StatementTrailer = new StatementTrailer
                        {
                            ClosingBalances = new List<Balance>
                            {
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.Current,
                                    BalanceValue = new Currency { Value = 234.54, CurrencyCode = CurrencyCode.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.Thirty,
                                    BalanceValue = new Currency { Value = 365.50, CurrencyCode = CurrencyCode.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.Sixty,
                                    BalanceValue = new Currency { Value = 566.78, CurrencyCode = CurrencyCode.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.Ninety,
                                    BalanceValue = new Currency { Value = 234.34, CurrencyCode = CurrencyCode.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.NinetyPlus,
                                    BalanceValue = new Currency { Value = 500.34, CurrencyCode = CurrencyCode.AUD },
                                },
                            },
                        }
                    }


            };
        }
    }

    public class RequestForStatementsRequestExample : IExamplesProvider<List<RequestForData>>
    {
        public List<RequestForData> GetExamples()
        {
            return new List<RequestForData>()
            {
                new RequestForData{
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

    public class RequestForStatements200Example : IExamplesProvider<ApiResult<List<Statements>>>
    {
        public ApiResult<List<Statements>> GetExamples()
        {
            return new ApiResult<List<Statements>>()
            {
                
                ApiMessages = [],
                Data = new List<Statements>
                {
                    new Statements{
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = new LiteralDate{ Date="2020-07-15"},
                        DateTransmissionFileCreated = new LiteralDate{ Date="2016-01-17" },
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                            OrganisationCode = "ATC",
                        },
                        CurrentReceiver = new Organisation
                        {
                            OrganisationCode = "ATT",
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
                        StatementHeader = new StatementHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationCode = "ATT",
                            },
                            ClientCode = 345678,
                            StatementDate = new LiteralDate{ Date="2024-03-21"},
                            OpeningBalances = new List<Balance>
                            {
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.Current,
                                    BalanceValue = new Currency { Value = 234.54, CurrencyCode = CurrencyCode.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.Thirty,
                                    BalanceValue = new Currency { Value = 365.50, CurrencyCode = CurrencyCode.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.Sixty,
                                    BalanceValue = new Currency { Value = 566.78, CurrencyCode = CurrencyCode.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.Ninety,
                                    BalanceValue = new Currency { Value = 234.34, CurrencyCode = CurrencyCode.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditType = DebitOrCreditType.DR,
                                    BalanceType = BalanceType.NinetyPlus,
                                    BalanceValue = new Currency { Value = 500.34, CurrencyCode = CurrencyCode.AUD },
                                },
                            },
                        },
                        StatementDetails = new List<StatementDetail>
                        {
                            new StatementDetail
                            {
                                ClientsReference = "1234567890",
                                AccountReference = "AWTA LED REFERENCE",
                                Amount = new Currency { Value = 866.30, CurrencyCode = CurrencyCode.AUD },
                                AmountType = AmountType.Invoice,
                                ItemDate = new LiteralDate{ Date="2024-04-23"},
                                GstAmount = new Currency { Value = 134.30, CurrencyCode = CurrencyCode.AUD },
                                IsGstApplicable = true,
                                IsCompanyAbnApplicable = true
                            }
                        },
                        StatementTrailer = new StatementTrailer
                        {
                            ClosingBalances = new List<Balance>
                                {
                                    new Balance
                                    {
                                        DebitOrCreditType = DebitOrCreditType.DR,
                                        BalanceType = BalanceType.Current,
                                        BalanceValue = new Currency { Value = 234.54, CurrencyCode = CurrencyCode.AUD },
                                    },
                                    new Balance
                                    {
                                        DebitOrCreditType = DebitOrCreditType.DR,
                                        BalanceType = BalanceType.Thirty,
                                        BalanceValue = new Currency { Value = 365.50, CurrencyCode = CurrencyCode.AUD },
                                    },
                                    new Balance
                                    {
                                        DebitOrCreditType = DebitOrCreditType.DR,
                                        BalanceType = BalanceType.Sixty,
                                        BalanceValue = new Currency { Value = 566.78, CurrencyCode = CurrencyCode.AUD },
                                    },
                                    new Balance
                                    {
                                        DebitOrCreditType = DebitOrCreditType.DR,
                                        BalanceType = BalanceType.Ninety,
                                        BalanceValue = new Currency { Value = 234.34, CurrencyCode = CurrencyCode.AUD },
                                    },
                                    new Balance
                                    {
                                        DebitOrCreditType = DebitOrCreditType.DR,
                                        BalanceType = BalanceType.NinetyPlus,
                                        BalanceValue = new Currency { Value = 500.34, CurrencyCode = CurrencyCode.AUD },
                                    },
                                },
                        }
                    }

                }
            };
        }
    }
}
