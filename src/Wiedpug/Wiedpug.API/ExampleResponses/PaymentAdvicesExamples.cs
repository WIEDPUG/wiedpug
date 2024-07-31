using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.PaymentAdviceAggregate;
using Wiedpug.Domain.Aggregates.PaymentAdviceDetailAggregate;
using Wiedpug.Domain.Aggregates.TestCertificateAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class CreatePaymentAdvicesRequestExample : IExamplesProvider<PaymentAdvices>
    {
        public PaymentAdvices GetExamples()
        {
            return new PaymentAdvices()
            {
                PaymentAdviceCollection = new List<PaymentAdvice>
                {
                    new PaymentAdvice
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
                        SoftwareCompany = SoftwareCompany.Talman,
                        Version = 1082
                    },
                    ABN = "72001967184"
                },
                        TransferConfig = new TransferConfig
                        {
                            TransferType = TransferType.Unrestrict
                        },
                PaymentAdviceDetailList = new List<PaymentAdviceDetail>
                {
                    new PaymentAdviceDetail
                    {
                            WoolSaleHeaderLots = new PaymentAdviceWoolSaleHeaderLots
                                {
                                    Season = 16,
                                    SaleIdentity = new Domain.Entities.SaleIdentity
                                    {
                                        SellingCentreType = SellingCentreType.AU_M,
                                        SaleNumber = 29
                                    },
                                    CentreStorage = new Centre {Country = CountryCode.AU, CentreCode = CentreCodeAustralia.A},
                                    SaleDate = "2017-01-19",
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

                                    CentreCatalogue = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.A },
                                    StorageOrganisation = new Organisation {                         OrganisationCode = "ABC", },
                                    StorageDescription = "45 MAIN ST",
                                    DiscountRate = 1.50,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = "2017-01-24",
                                    StorageChargePerBalePerDay = new StorageChargeCurrency{ 
                                        Value = 0.245,
                                        CurrencyUnit = CurrencyUnit.AUD
                                    },
                                    PenaltyInterestRate = 11.35,
                                },
                            LotPaymentDetails = new List<LotPaymentDetail>
                            {
                                new LotPaymentDetail
                                {
                                    LotIdentity = "123256",
                                    LotLastCost = new Currency{ 
                                        Value = 23.45,
                                        CurrencyUnit = CurrencyUnit.AUD
                                    },

                                }
                            },
                            PaymentSummary = new PaymentSummary
                            {
                                LastCostPaid =new Currency { Value = 67.00, CurrencyUnit = CurrencyUnit.AUD },
                                DiscountAmount=new Currency { Value = 23.00, CurrencyUnit = CurrencyUnit.AUD },
                                NetAmountPaid=new Currency { Value = 77.00, CurrencyUnit = CurrencyUnit.AUD },
                                DatePaymentMade="2024-05-24"
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

    public class RequestForPaymentAdvicesRequestExample : IExamplesProvider<RequestForData>
    {
        public RequestForData GetExamples()
        {
            return new RequestForData()
            {
                SaleIdentity = new Domain.Entities.SaleIdentity
                {
                    SellingCentreType = SellingCentreType.AU_M,
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

    public class RequestForPaymentAdvices200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                
                Message = null,
                Data = new PaymentAdvices
                {
                    PaymentAdviceCollection = new List<PaymentAdvice>
                    {
                        new PaymentAdvice
                        {
                                                TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
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
                            Version = 1082
                        },
                        ABN = "72001967184"
                    },
                    PaymentAdviceDetailList = new List<PaymentAdviceDetail>
                {
                    new PaymentAdviceDetail
                    {
                                WoolSaleHeaderLots = new PaymentAdviceWoolSaleHeaderLots
                                {
                                    Season = 16,
                                    SaleIdentity = new Domain.Entities.SaleIdentity
                                    {
                                        SellingCentreType = SellingCentreType.AU_M,
                                        SaleNumber = 29
                                    },
                                    CentreStorage = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.A },
                                    SaleDate = "2017-01-19",
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
                                        Country = CountryCode.AU,
                                        CentreCode =  CentreCodeAustralia.A
                                    },
                                    StorageOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "ABC",
                                    },
                                    StorageDescription = "45 MAIN ST",
                                    DiscountRate = 1.50,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = "2017-01-24",
                                    StorageChargePerBalePerDay = new StorageChargeCurrency
                                    {
                                        Value = 0.245,
                                        CurrencyUnit = CurrencyUnit.USD,
                                    },
                                    PenaltyInterestRate = 11.35,
                                },
                            LotPaymentDetails = new List<LotPaymentDetail>
                            {
                                new LotPaymentDetail
                                {
                                    LotIdentity = "123256",
                                    LotLastCost = new Currency { Value = 23.45, CurrencyUnit = CurrencyUnit.AUD }

                                }
                            },
                            PaymentSummary = new PaymentSummary
                            {
                                LastCostPaid =new Currency{
                                                Value = 67.00,
                                                CurrencyUnit =CurrencyUnit.AUD
                                            },
                                DiscountAmount=new Currency{
                                                Value = 23.00,
                                                CurrencyUnit =CurrencyUnit.AUD
                                            },
                                NetAmountPaid=new Currency { Value = 77.00, CurrencyUnit = CurrencyUnit.AUD },
                                DatePaymentMade="2024-05-24"
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

                }
            };
        }
    }
}
