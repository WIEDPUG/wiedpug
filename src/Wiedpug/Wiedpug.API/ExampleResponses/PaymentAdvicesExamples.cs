using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.LotPriceAndBuyerAggregate;
using Wiedpug.Domain.Aggregates.PaymentAdviceAggregate;
using Wiedpug.Domain.Aggregates.PaymentAdviceDetailAggregate;
using Wiedpug.Domain.Aggregates.TestCertificateAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class CreatePaymentAdvicesRequestExample : IExamplesProvider<List<PaymentAdvice>>
    {
        public List<PaymentAdvice> GetExamples()
        {
            return new List<PaymentAdvice>
            {
                new PaymentAdvice
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
                        VersionNumber = 31,
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
                PaymentAdviceDetails = new List<PaymentAdviceDetail>
                {
                    new PaymentAdviceDetail
                    {
                            WoolSaleHeaderLot = new WoolSaleHeaderLot
                                {
                                    Season = new Season{SeasonValue= 16},
                                    SaleIdentity =new SaleIdentity
                {
                    SellingCentreType = "M",
                    SaleNumber = 18
                },
                                    CentreStorage = new Centre {CountryCode = CountryCode.AU, CentreCode = CentreCodeAustralia.A},
                                    SaleDate = new LiteralDate{ Date="2017-01-10"},
                                    WoolState = WoolState.A,
                                    PackType = PackType._2,
                                    InvoicingOrganisation = new Organisation
                            {
                                                        OrganisationCode = "ABC",
                            },

                                    SellingOrganisation = new Organisation
                            {
                                                        OrganisationCode = "ABC",
                            },

                                    CentreCatalogue = new Centre { CountryCode = CountryCode.AU, CentreCode = CentreCodeAustralia.A },
                                    StorageOrganisation = new Organisation {                         OrganisationCode = "ABC", },
                                    StorageDescription = "45 MAIN ST",
                                    DiscountRate = 1.50,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = new LiteralDate{ Date="2017-01-24"},
                                    StorageChargePerBalePerDay = new StorageChargeCurrency{ 
                                        Value = 0.245,
                                        CurrencyCode = CurrencyCode.AUD
                                    },
                                    PenaltyInterestRate = 11.35,
                                },
                            LotPaymentDetails = new List<LotPaymentDetail>
                            {
                                new LotPaymentDetail
                                {
                                    LotIdentity = new LotIdentity{Identity="123456" },
                                    LotLastCost = new Currency{ 
                                        Value = 23.45,
                                        CurrencyCode = CurrencyCode.AUD
                                    },

                                }
                            },
                            PaymentSummary = new PaymentSummary
                            {
                                LastCostPaid =new Currency { Value = 67.00, CurrencyCode = CurrencyCode.AUD },
                                DiscountAmount=new Currency { Value = 23.00, CurrencyCode = CurrencyCode.AUD },
                                NetAmountPaid=new Currency { Value = 77.00, CurrencyCode = CurrencyCode.AUD },
                                DatePaymentMade= new LiteralDate{Date="2024-05-24" }
                            }

                    }
                },
                Comments = new List<Comment>
                {
                    new Comment
                    {
                        Text = "dfsfbsdfafsafs fdsa"
                    }
                }
                },
            };
        }
    }

    public class RequestForPaymentAdvicesRequestExample : IExamplesProvider<List<RequestForData>>
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
                    VersionNumber = 31,
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

    public class RequestForPaymentAdvices200Example : IExamplesProvider<ApiResult<List<PaymentAdvice>>>
    {
        public ApiResult<List<PaymentAdvice>> GetExamples()
        {
            return new ApiResult<List<PaymentAdvice>>()
            {
                
                ApiMessages = [],
                Data = new List<PaymentAdvice>
                {
                        new PaymentAdvice
                        {
                                                TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = new LiteralDate{ Date="2020-07-15"},
                        DateTransmissionFileCreated = new LiteralDate{ Date="2016-01-17" },
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                                                    OrganisationCode = "AWT",
                        },
                        CurrentReceiver = new Organisation
                        {
                                                    OrganisationCode = "MNC",
                        },
                        VersionNumber = 31,
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = SoftwareCompany.Talman,
                            SoftwareVersion =  1082
                        },
                        Abn = 72001967184
                    },
                    PaymentAdviceDetails = new List<PaymentAdviceDetail>
                {
                    new PaymentAdviceDetail
                    {
                                WoolSaleHeaderLot = new WoolSaleHeaderLot
                                {
                                    Season = new Season{SeasonValue= 16},
                                    SaleIdentity = new SaleIdentity
                {
                    SellingCentreType = "M",
                    SaleNumber = 18
                },
                                    CentreStorage = new Centre { CountryCode = CountryCode.AU, CentreCode = CentreCodeAustralia.A },
                                    SaleDate = new LiteralDate{ Date="2017-01-10"},
                                    WoolState = WoolState.A,
                                    PackType = PackType._2,
                                    InvoicingOrganisation = new Organisation
                            {
                                                        OrganisationCode = "ABC",
                            },

                                    SellingOrganisation = new Organisation
                            {
                                                        OrganisationCode = "ABC",
                            },

                                    CentreCatalogue = new Centre {
                                        CountryCode = CountryCode.AU,
                                        CentreCode =  CentreCodeAustralia.A
                                    },
                                    StorageOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "ABC",
                                    },
                                    StorageDescription = "45 MAIN ST",
                                    DiscountRate = 1.50,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = new LiteralDate{ Date="2017-01-24"},
                                    StorageChargePerBalePerDay = new StorageChargeCurrency
                                    {
                                        Value = 0.245,
                                        CurrencyCode = CurrencyCode.USD,
                                    },
                                    PenaltyInterestRate = 11.35,
                                },
                            LotPaymentDetails = new List<LotPaymentDetail>
                            {
                                new LotPaymentDetail
                                {
                                    LotIdentity = new LotIdentity{Identity="123456" },
                                    LotLastCost = new Currency { Value = 23.45, CurrencyCode = CurrencyCode.AUD }

                                }
                            },
                            PaymentSummary = new PaymentSummary
                            {
                                LastCostPaid =new Currency{
                                                Value = 67.00,
                                                CurrencyCode =CurrencyCode.AUD
                                            },
                                DiscountAmount=new Currency{
                                                Value = 23.00,
                                                CurrencyCode =CurrencyCode.AUD
                                            },
                                NetAmountPaid=new Currency { Value = 77.00, CurrencyCode = CurrencyCode.AUD },
                                DatePaymentMade=new LiteralDate{Date="2024-05-24" }
                            }

                    }
                },
                    Comments = new List<Comment>
                {
                    new Comment
                    {
                        Text = "dfsfbsdfafsafs fdsa"
                    }
                }
                        }
                    }
            };
        }
    }
}
