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
                StatementCollection = new List<Statement>
                {
                    new Statement
                    {
                        StatementHeader = new StatementHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationId = "ATTA"
                            },
                            ClientCode = 345678,
                            StatementDate = "2024-03-21",
                            DebitOrCreditFlag1 = DebitCreditFlag.Debit,
                            OpeningBalanceCurrent = 234.54,
                            DebitOrCreditFlag2 = DebitCreditFlag.Debit,
                            OpeningBalance30 = 365.50,
                            DebitOrCreditFlag3 = DebitCreditFlag.Debit,
                            OpeningBalance60 = 566.78,
                            DebitOrCreditFlag4 = DebitCreditFlag.Debit,
                            OpeningBalance90 = 234.34,
                            DebitOrCreditFlag5 = DebitCreditFlag.Debit,
                            OpeningBalance90Plus = 500.34
                        },
                        StatementDetails = new List<StatementDetail>
                        {
                            new StatementDetail
                            {
                                ClientsReference = "1234567890",
                                AccountReference = "AWTA LED REFERENCE",
                                Amount = 866.30,
                                AmountType = AmountType.Invoice,
                                ItemDate = "2024-04-23",
                                GstAmount = 134.30,
                                GstTaxInvoiceApplicable = true,
                                CompanyABNApplicable = true
                            }
                        },
                        StatementTrailer = new StatementTrailer
                        {
                            DebitOrCreditFlag1 = DebitCreditFlag.Debit,
                            ClosingBalanceCurrent = 234.54,
                            DebitOrCreditFlag2 = DebitCreditFlag.Debit,
                            ClosingBalance30 = 365.50,
                            DebitOrCreditFlag3 = DebitCreditFlag.Debit,
                            ClosingBalance60 = 566.78,
                            DebitOrCreditFlag4 = DebitCreditFlag.Debit,
                            ClosingBalance90 = 234.34,
                            DebitOrCreditFlag5 = DebitCreditFlag.Debit,
                            ClosingBalance90Plus = 500.34
                        }
                    }
                }

            };
        }
    }

    public class RequestForStatementsRequestExample : IExamplesProvider<RequestForStatements>
    {
        public RequestForStatements GetExamples()
        {
            return new RequestForStatements()
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

    public class RequestForStatements200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = true,
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
                    StatementCollection = new List<Statement>
                {
                    new Statement
                    {
                        StatementHeader = new StatementHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationId = "ATTA"
                            },
                            ClientCode = 345678,
                            StatementDate = "2024-03-21",
                            DebitOrCreditFlag1 = DebitCreditFlag.Debit,
                            OpeningBalanceCurrent = 234.54,
                            DebitOrCreditFlag2 = DebitCreditFlag.Debit,
                            OpeningBalance30 = 365.50,
                            DebitOrCreditFlag3 = DebitCreditFlag.Debit,
                            OpeningBalance60 = 566.78,
                            DebitOrCreditFlag4 = DebitCreditFlag.Debit,
                            OpeningBalance90 = 234.34,
                            DebitOrCreditFlag5 = DebitCreditFlag.Debit,
                            OpeningBalance90Plus = 500.34
                        },
                        StatementDetails = new List<StatementDetail>
                        {
                            new StatementDetail
                            {
                                ClientsReference = "1234567890",
                                AccountReference = "AWTA LED REFERENCE",
                                Amount = 866.30,
                                AmountType = AmountType.Invoice,
                                ItemDate = "2024-04-23",
                                GstAmount = 134.30,
                                GstTaxInvoiceApplicable = true,
                                CompanyABNApplicable = true
                            }
                        },
                        StatementTrailer = new StatementTrailer
                        {
                            DebitOrCreditFlag1 = DebitCreditFlag.Debit,
                            ClosingBalanceCurrent = 234.54,
                            DebitOrCreditFlag2 = DebitCreditFlag.Debit,
                            ClosingBalance30 = 365.50,
                            DebitOrCreditFlag3 = DebitCreditFlag.Debit,
                            ClosingBalance60 = 566.78,
                            DebitOrCreditFlag4 = DebitCreditFlag.Debit,
                            ClosingBalance90 = 234.34,
                            DebitOrCreditFlag5 = DebitCreditFlag.Debit,
                            ClosingBalance90Plus = 500.34
                        }
                    }
                }



                }
            };
        }
    }
}
