using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.LotInvoicesAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class LotInvoicesRequestExample : IExamplesProvider<List<LotInvoice>>
    {
        public List<LotInvoice> GetExamples()
        {
            return new List<LotInvoice>
                {
                    new LotInvoice
                    {
                        TransmissionHeader = new TransmissionHeader
                        {
                            DateFormatLastRevised = new UtcDate{ Date="2020-07-15"},
                            DateTransmissionFileCreated = new UtcDate{ Date="2016-01-17" },
                            CountryOfOrigin = Domain.Enums.CountryCode.AU,
                            DocumentOriginator = new Organisation
                            {
                                                        OrganisationCode = "ABC",

                            },VersionNumber = 31,
                                                CurrentReceiver = new Organisation
                    {
                                                OrganisationCode = "ATW",

                    },
                            SoftwareIdentifier = new SoftwareIdentifier
                            {
                                ProgramName = "NETR",
                                SoftwareCompany = SoftwareCompany.Talman,
                                SoftwareVersion =  1082
                            },
                            Abn = 72001967184
                        },
                         WoolSales = new List<WoolSale>()
                        {
                             new WoolSale
                             {
                                WoolSaleHeaderLot = new Domain.Entities.WoolSaleHeaderLot
                                {
                                    Season = new Season{SeasonValue= 16},
                                    SaleIdentity = new SaleIdentity { SellingCentreType = "M", SaleNumber = 18 },
                                    CentreStorage = new Centre {
                                        Country = CountryCode.AU,
                                        CentreCode = CentreCodeAustralia.AR
                                    },
                                    SaleDate = new UtcDate{Date="2017-01-19" },
                                    WoolState = WoolState.C,
                                    PackType = PackType.F,
                                    PostSaleCharge = new Currency{
                                                Value = 25.96,
                                                CurrencyCode =CurrencyCode.AUD
                                            },
                                    CalculationBasis = CalculationBasis.B,
                                    FreightCharge = new Currency{
                                                Value = 0.00,
                                                CurrencyCode =CurrencyCode.AUD
                                            },
                                    FreightRebate = new Currency{
                                                Value = 3.25,
                                                CurrencyCode =CurrencyCode.AUD
                                            },
                                    ChargePerLot = new Currency
                                    {
                                        Value = 0.00,
                                        CurrencyCode = CurrencyCode.AUD
                                    },
                                    InvoicingOrganisation = new Organisation
                            {
                                                        OrganisationCode = "ABC",

                            },
                                    ReleasingOrganisation = new Organisation
                            {
                                                        OrganisationCode = "ABC",

                            },
                                    SellingOrganisation = new Organisation
                            {
                                                        OrganisationCode = "ABC",

                            },
                                    WoolTypeGroup = WoolTypeGroup.MFLC,
                                    CentreCatalogue = new Centre {
                                        Country = CountryCode.AU,
                                        CentreCode = CentreCodeAustralia.G
                                    },
                                    DeliveryBasis = DeliveryBasis.D,
                                    StorageOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "ABC",
                                    },
                                    StorageDescription = "45 MAIN ST",
                                    PaymentDueDate = new UtcDate{ Date="2017-01-24"},
                                    DiscountRate = 1.51,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = new UtcDate{ Date="2017-01-24"},
                                    StorageChargePerBalePerDay = new StorageChargeCurrency
                                    {
                                        Value = 0.245,
                                        CurrencyCode = CurrencyCode.AUD
                                    },
                                    PenaltyInterestRate = 11.35
                                },
                                 LotInvoiceDetails = new List<LotInvoiceDetail>
                                 {
                                     new LotInvoiceDetail
                                     {
                                         LotInvoiceHeader = new LotInvoiceHeader
                                         {
                                             LotIdentity = new LotIdentity{Identity="39123" },
                                             NumberOfBales = new NumberOfBales{BalesCount=34 },
                                             Gross = new Weight
                                            {
                                                Value = 23.00,
                                                WeightCode = WeightCode.KG
                                            },
                                             Tare = new Weight
                                            {
                                                Value = 12.00,
                                                WeightCode = WeightCode.KG
                                            },
                                             CostPerWeightUnit = 25,
                                             FirstCost = new Currency{
                                                Value = 12.24,
                                                CurrencyCode =CurrencyCode.AUD
                                            },
                                             PackMaterial = PackMaterial.K,
                                             GstFirstCost =new Currency{
                                                Value = 14.11,
                                                CurrencyCode =CurrencyCode.AUD
                                            },
                                             GstTotalPostSaleCharge = new Currency{
                                                Value = 51.80,
                                                CurrencyCode =CurrencyCode.AUD
                                            },
                                             TotalPostSaleCharge = new Currency { Value = 0.00, CurrencyCode = CurrencyCode.AUD }
                                         },
                                         LotHeaderVendorDeclarations = new List<LotHeaderVendorDeclaration>
                                         {
                                             new LotHeaderVendorDeclaration
                                             {
                                                 MulesingStatus = MulesingStatus.ND
                                             }
                                         },
                                         Bales = new List<Bale>
                                         {
                                             new Bale
                                             {
                                                  BaleHeader = new BaleHeader
                                                  {
                                                      Brand = "FTT",
                                                      BaleDescription = new BaleDescription{Description="AAC"},
                                                      AreaOfOrigin = "Melbourne",
                                                      LocationWithinStore = "AWTA LTD"
                                                  },
                                                  BaleDetails = new List<BaleDetail>
                                                  {
                                                      new BaleDetail
                                                      {
                                                          BaleNumber = "116",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          BaleRenumber = "181",
                                                          Gross = new Weight
                                                            {
                                                                Value = 18.00,
                                                                WeightCode = WeightCode.KG
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                WeightCode = WeightCode.KG
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "117",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 201.00,
                                                                WeightCode = WeightCode.KG
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                WeightCode = WeightCode.KG
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "117",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = .02010,
                                                                WeightCode = WeightCode.KG
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                WeightCode = WeightCode.KG
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "126",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 178.00,
                                                                WeightCode = WeightCode.KG
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                WeightCode = WeightCode.KG
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "129",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 168.00,
                                                                WeightCode = WeightCode.KG
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                WeightCode = WeightCode.KG
                                                            }
                                                      }
                                                  }
                                             }
                                         }
                                     }
                                 }
                             }
                        }
                    }
                };

        }
    }

    public class RequestForLotInovicesExample : IExamplesProvider<List<RequestForData>>
    {
        public List<RequestForData> GetExamples()
        {
            return new List<RequestForData>()
            {
                new RequestForData {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = new UtcDate{ Date="2020-07-15"},
                    DateTransmissionFileCreated = new UtcDate{ Date="2016-01-17" },
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

    public class RequestForLotInvoices200Example : IExamplesProvider<ApiResult<List<LotInvoice>>>
    {
        public ApiResult<List<LotInvoice>> GetExamples()
        {
            return new ApiResult<List<LotInvoice>>()
            {
                
                ApiMessages = [],
                Data = new List<LotInvoice>
                {
                    new LotInvoice
                    {
                        TransmissionHeader = new TransmissionHeader
                        {
                            DateFormatLastRevised = new UtcDate{ Date="2020-07-15"},
                            DateTransmissionFileCreated = new UtcDate{ Date="2016-01-17" },
                            CountryOfOrigin = Domain.Enums.CountryCode.AU,
                            DocumentOriginator = new Organisation
                            {
                                                        OrganisationCode = "ABC",

                            },VersionNumber = 31,
                                                CurrentReceiver = new Organisation
                    {
                                                OrganisationCode = "ATW",

                    },
                            SoftwareIdentifier = new SoftwareIdentifier
                            {
                                ProgramName = "NETR",
                                SoftwareCompany = SoftwareCompany.Talman,
                                SoftwareVersion =  1082
                            },
                            Abn = 72001967184
                        },
                         WoolSales = new List<WoolSale>()
                        {
                             new WoolSale
                             {
                                WoolSaleHeaderLot = new Domain.Entities.WoolSaleHeaderLot
                                {
                                    Season = new Season{SeasonValue= 16},
                                    SaleIdentity = new SaleIdentity
                                    {
                                        SellingCentreType = "M",
                                        SaleNumber = 18
                                    },
                                    CentreStorage = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.AR },
                                    SaleDate = new UtcDate{Date="2017-01-19" },
                                    WoolState = WoolState.C,
                                    PackType = PackType.F,
                                    PostSaleCharge = new Currency { Value = 25.96, CurrencyCode = CurrencyCode.AUD },
                                    CalculationBasis = CalculationBasis.B,
                                    FreightCharge = new Currency { Value = 0.00, CurrencyCode = CurrencyCode.AUD },
                                    FreightRebate = new Currency { Value = 3.25, CurrencyCode = CurrencyCode.AUD },
                                    ChargePerLot = new Currency{
                                        Value = 0.0,
                                        CurrencyCode = CurrencyCode.AUD
                                    },
                                    InvoicingOrganisation = new Organisation
                            {
                                                        OrganisationCode = "ABC",

                            },
                                    ReleasingOrganisation = new Organisation
                            {
                                                        OrganisationCode = "ABC",

                            },
                                    SellingOrganisation =new Organisation
                            {
                                                        OrganisationCode = "ABC",

                            },
                                    WoolTypeGroup = WoolTypeGroup.MFLC,
                                    CentreCatalogue = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.G },
                                    DeliveryBasis = DeliveryBasis.D,
                                     StorageOrganisation = new Organisation
                                    {
                                         OrganisationCode = "ABC",
                                    },
                                    StorageDescription = "45 MAIN ST",
                                    PaymentDueDate = new UtcDate{ Date="2017-01-24"},
                                    DiscountRate = 1.51,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = new UtcDate{ Date="2017-01-24"},
                                    StorageChargePerBalePerDay = new StorageChargeCurrency
                                    {
                                        Value =0.245,
                                        CurrencyCode = CurrencyCode.AUD
                                    },
                                    PenaltyInterestRate = 11.35
                                },
                                 LotInvoiceDetails = new List<LotInvoiceDetail>
                                 {
                                     new LotInvoiceDetail
                                     {
                                         LotInvoiceHeader = new LotInvoiceHeader
                                         {
                                             LotIdentity = new LotIdentity{Identity="39123" },
                                             NumberOfBales = new NumberOfBales{BalesCount=34 },
                                                          Gross = new Weight
                                                            {
                                                                Value = 23.00,
                                                                WeightCode = WeightCode.KG
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 12.00,
                                                                WeightCode = WeightCode.KG
                                                            },
                                             CostPerWeightUnit = 25,
                                             FirstCost = new Currency { Value = 12.24, CurrencyCode = CurrencyCode.AUD },
                                             PackMaterial = PackMaterial.K,
                                             GstFirstCost =new Currency { Value = 141.11, CurrencyCode = CurrencyCode.AUD },
                                             GstTotalPostSaleCharge = new Currency { Value = 51.80, CurrencyCode = CurrencyCode.AUD },
                                             TotalPostSaleCharge = new Currency { Value = 0.00, CurrencyCode = CurrencyCode.AUD }
                                         },
                                         LotHeaderVendorDeclarations = new List<LotHeaderVendorDeclaration>
                                         {
                                             new LotHeaderVendorDeclaration
                                             {
                                                 MulesingStatus = MulesingStatus.ND
                                             }
                                         },
                                         Bales = new List<Bale>
                                         {
                                             new Bale
                                             {
                                                  BaleHeader = new BaleHeader
                                                  {
                                                      Brand = "FTT",
                                                      BaleDescription = new BaleDescription{Description="AAC"},
                                                      AreaOfOrigin = "Melbourne",
                                                      LocationWithinStore = "AWTA LTD"
                                                  },
                                                  BaleDetails = new List<BaleDetail>
                                                  {
                                                      new BaleDetail
                                                      {
                                                          BaleNumber = "116",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          BaleRenumber = "181",
                                                          Gross = new Weight
                                                            {
                                                                Value = 181.00,
                                                                WeightCode = WeightCode.KG
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 12.00,
                                                                WeightCode = WeightCode.KG
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "117",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 201.00,
                                                                WeightCode = WeightCode.KG
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                WeightCode = WeightCode.KG
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "117",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 18.00,
                                                                WeightCode = WeightCode.KG
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                WeightCode = WeightCode.KG
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "126",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 178.00,
                                                                WeightCode = WeightCode.KG
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                WeightCode = WeightCode.KG
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "129",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 168.00,
                                                                WeightCode = WeightCode.KG
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                WeightCode = WeightCode.KG
                                                            }
                                                      }
                                                  }
                                             }
                                         }
                                     }
                                 }
                             }
                        }
                    }
                },

            };
        }
    }



}
