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
                    Abn = "72001967184"
                },
                StatementInformationDetails = new List<StatementInformationDetail>
                {
                    new StatementInformationDetail
                    {
                        StatementHeader = new StatementHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationCode = "ADC",
                            },
                            ClientCode = 345678,
                            StatementDate = "2024-03-21",
                            OpeningBalances = new List<Balance>
                            {
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Current,
                                    BalanceValue = new Currency { Value = 234.54, CurrencyUnit = CurrencyUnit.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Thirty,
                                    BalanceValue = new Currency { Value = 365.50, CurrencyUnit = CurrencyUnit.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Sixty,
                                    BalanceValue = new Currency { Value = 566.78, CurrencyUnit = CurrencyUnit.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Ninety,
                                    BalanceValue = new Currency { Value = 234.34, CurrencyUnit = CurrencyUnit.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Ninety,
                                    BalanceValue = new Currency { Value = 500.34, CurrencyUnit = CurrencyUnit.AUD },
                                },
                            },
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
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Current,
                                    BalanceValue = new Currency { Value = 234.54, CurrencyUnit = CurrencyUnit.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Thirty,
                                    BalanceValue = new Currency { Value = 365.50, CurrencyUnit = CurrencyUnit.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Sixty,
                                    BalanceValue = new Currency { Value = 566.78, CurrencyUnit = CurrencyUnit.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Ninety,
                                    BalanceValue = new Currency { Value = 234.34, CurrencyUnit = CurrencyUnit.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Ninety,
                                    BalanceValue = new Currency { Value = 500.34, CurrencyUnit = CurrencyUnit.AUD },
                                },
                            },
                        }
                    }
                }

            };
        }
    }

    public class RequestForStatementsRequestExample : IExamplesProvider<RequestForData>
    {
        public RequestForData GetExamples()
        {
            return new RequestForData()
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
                    Abn = "72001967184"
                },
                RequestForDataType = new DateTimeRangeRequestForDataType
                {
                    StartDateTimeStatusRequest = "2024-03-21T19:25:04Z"
                }
            };
        }
    }

    public class RequestForStatements200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                
                ApiMessages = [],
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
                        Abn = "72001967184"
                    },
                    StatementInformationDetails = new List<StatementInformationDetail>
                {
                    new StatementInformationDetail
                    {
                        StatementHeader = new StatementHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationCode = "ATT",
                            },
                            ClientCode = 345678,
                            StatementDate = "2024-03-21",
                            OpeningBalances = new List<Balance>
                            {
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Current,
                                    BalanceValue = new Currency { Value = 234.54, CurrencyUnit = CurrencyUnit.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Thirty,
                                    BalanceValue = new Currency { Value = 365.50, CurrencyUnit = CurrencyUnit.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Sixty,
                                    BalanceValue = new Currency { Value = 566.78, CurrencyUnit = CurrencyUnit.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Ninety,
                                    BalanceValue = new Currency { Value = 234.34, CurrencyUnit = CurrencyUnit.AUD },
                                },
                                new Balance
                                {
                                    DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                    BalanceType = BalanceType.Ninety,
                                    BalanceValue = new Currency { Value = 500.34, CurrencyUnit = CurrencyUnit.AUD },
                                },
                            },
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
                                        DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                        BalanceType = BalanceType.Current,
                                        BalanceValue = new Currency { Value = 234.54, CurrencyUnit = CurrencyUnit.AUD },
                                    },
                                    new Balance
                                    {
                                        DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                        BalanceType = BalanceType.Thirty,
                                        BalanceValue = new Currency { Value = 365.50, CurrencyUnit = CurrencyUnit.AUD },
                                    },
                                    new Balance
                                    {
                                        DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                        BalanceType = BalanceType.Sixty,
                                        BalanceValue = new Currency { Value = 566.78, CurrencyUnit = CurrencyUnit.AUD },
                                    },
                                    new Balance
                                    {
                                        DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                        BalanceType = BalanceType.Ninety,
                                        BalanceValue = new Currency { Value = 234.34, CurrencyUnit = CurrencyUnit.AUD },
                                    },
                                    new Balance
                                    {
                                        DebitOrCreditFlag = DebitOrCreditFlag.Debit,
                                        BalanceType = BalanceType.Ninety,
                                        BalanceValue = new Currency { Value = 500.34, CurrencyUnit = CurrencyUnit.AUD },
                                    },
                                },
                        }
                    }
                }



                }
            };
        }
    }
}
