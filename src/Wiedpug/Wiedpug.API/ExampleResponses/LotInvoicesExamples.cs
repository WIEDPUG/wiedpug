using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.LotInvoicesAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class LotInvoicesRequestExample : IExamplesProvider<LotInvoices>
    {
        public LotInvoices GetExamples()
        {
            return new LotInvoices()
            {
                LotInvoiceCollection = new List<LotInvoice>
                {
                    new LotInvoice
                    {
                        TransmissionHeader = new TransmissionHeader
                        {
                            DateFormatLastRevised = "2020-07-15",
                            DateTransmissionFileCreated = "2016-01-17",
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
                                Version = 1082
                            },
                            ABN = "72001967184"
                        },
                         WoolSales = new List<WoolSale>()
                        {
                             new WoolSale
                             {
                                WoolSaleHeaderLots = new Domain.Entities.LotInvoicesWoolSaleHeaderLots
                                {
                                    Season = 16,
                                    SaleIdentity = new Domain.Entities.SaleIdentity
                                    {
                                        SellingCentreType = SellingCentreType.AU_M,
                                        SaleNumber = 29
                                    },
                                    CentreStorage = new Centre { 
                                        Country = CountryCode.AU,
                                        CentreCode = CentreCodeAustralia.AR 
                                    },
                                    SaleDate = "2017-01-19",
                                    WoolState = WoolState.C,
                                    PackType = PackType.F,
                                    Currency = "AUD",
                                    PostSaleCharge = new Currency{
                                                Value = 25.96,
                                                CurrencyUnit =CurrencyUnit.AUD
                                            },
                                    CalculationBasis = CalculationBasis.B,
                                    FreightCharge = new Currency{
                                                Value = 0.00,
                                                CurrencyUnit =CurrencyUnit.AUD
                                            },
                                    FreightRebate = new Currency{
                                                Value = 3.25,
                                                CurrencyUnit =CurrencyUnit.AUD
                                            },
                                    ChargePerLot = new Currency
                                    {
                                        Value = 0.00,
                                        CurrencyUnit = CurrencyUnit.AUD
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
                                    DeliveryBasis = DeliveryBasis.D
                                },
                                WoolSaleHeaderExtension = new Domain.Entities.WoolSaleHeaderExtension
                                {
                                    StorageOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "ABC",
                                    },
                                    StorageDescription = "45 MAIN ST",
                                    PaymentDueDate = "2017-01-27",
                                    DiscountRate = 1.51,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = "2017-01-24",
                                    StorageChargePerBalePerDay = new StorageChargeCurrency
                                    {
                                        Value = 0.245,
                                        CurrencyUnit = CurrencyUnit.AUD
                                    },
                                    PenaltyInterestRate = 11.35
                                },
                                 LotInvoiceDetails = new List<LotInvoiceDetail>
                                 {
                                     new LotInvoiceDetail
                                     {
                                         LotInvoiceHeader = new LotInvoiceHeader
                                         {
                                             LotIdentity = "39",
                                             Bales = 34,
                                             Gross = new Weight
                                            {
                                                Value = 23.00,
                                                Unit = WeightUnit.Kilograms
                                            },
                                             Tare = new Weight
                                            {
                                                Value = 12.00,
                                                Unit = WeightUnit.Kilograms
                                            },
                                             CostPerWeightUnit = 25,
                                             FirstCost = new Currency{
                                                Value = 12.24,
                                                CurrencyUnit =CurrencyUnit.AUD
                                            },
                                             PackMaterial = PackMaterial.K
                                         },
                                         LotInvoiceExtension = new LotInvoiceExtension
                                         {
                                             GSTFirstCost =new Currency{
                                                Value = 14.11,
                                                CurrencyUnit =CurrencyUnit.AUD
                                            },
                                             GSTTotalPostSaleCharge = new Currency{
                                                Value = 51.80,
                                                CurrencyUnit =CurrencyUnit.AUD
                                            },
                                             TotalPostSaleCharge = new Currency { Value = 0.00, CurrencyUnit = CurrencyUnit.AUD }
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
                                                      BaleDescription = "AAC",
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
                                                                Unit = WeightUnit.Kilograms
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                Unit = WeightUnit.Kilograms
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "117",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 201.00,
                                                                Unit = WeightUnit.Kilograms
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                Unit = WeightUnit.Kilograms
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "117",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = .02010,
                                                                Unit = WeightUnit.Kilograms
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                Unit = WeightUnit.Kilograms
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "126",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 178.00,
                                                                Unit = WeightUnit.Kilograms
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                Unit = WeightUnit.Kilograms
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "129",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 168.00,
                                                                Unit = WeightUnit.Kilograms
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                Unit = WeightUnit.Kilograms
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

    public class RequestForLotInovicesExample : IExamplesProvider<RequestForData>
    {
        public RequestForData GetExamples()
        {
            return new RequestForData()
            {
                SaleIdentity = new Domain.Entities.SaleIdentity
                {
                    SellingCentreType = SellingCentreType.AU_F,
                    SaleNumber = 18
                },
                OrganisationRequested = new Organisation { OrganisationCode = "ANF" },
                SaleDateRequested = "2023-10-31",
                IsUsingNetworkDateTime = false,
                RequestType = Domain.Enums.RequestTypeForData.BroadcastDataRequest,
                WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                Season = 23
            };
        }
    }

    public class RequestForLotInvoices200Example : IExamplesProvider<ApiResult<LotInvoices>>
    {
        public ApiResult<LotInvoices> GetExamples()
        {
            return new ApiResult<LotInvoices>()
            {
                
                Message = null,
                Data = new LotInvoices
                {
                    LotInvoiceCollection = new List<LotInvoice>
                {
                    new LotInvoice
                    {
                        TransmissionHeader = new TransmissionHeader
                        {
                            DateFormatLastRevised = "2020-07-15",
                            DateTransmissionFileCreated = "2016-01-17",
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
                                Version = 1082
                            },
                            ABN = "72001967184"
                        },
                         WoolSales = new List<WoolSale>()
                        {
                             new WoolSale
                             {
                                WoolSaleHeaderLots = new Domain.Entities.LotInvoicesWoolSaleHeaderLots
                                {
                                    Season = 16,
                                    SaleIdentity = new Domain.Entities.SaleIdentity
                                    {
                                        SellingCentreType = SellingCentreType.AU_M,
                                        SaleNumber = 29
                                    },
                                    CentreStorage = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.AR },
                                    SaleDate = "2017-01-19",
                                    WoolState = WoolState.C,
                                    PackType = PackType.F,
                                    Currency = "AUD",
                                    PostSaleCharge = new Currency { Value = 25.96, CurrencyUnit = CurrencyUnit.AUD },
                                    CalculationBasis = CalculationBasis.B,
                                    FreightCharge = new Currency { Value = 0.00, CurrencyUnit = CurrencyUnit.AUD },
                                    FreightRebate = new Currency { Value = 3.25, CurrencyUnit = CurrencyUnit.AUD },
                                    ChargePerLot = new Currency{ 
                                        Value = 0.0,
                                        CurrencyUnit = CurrencyUnit.AUD
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
                                    DeliveryBasis = DeliveryBasis.D
                                },
                                WoolSaleHeaderExtension = new Domain.Entities.WoolSaleHeaderExtension
                                {
                                    StorageOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "ABC",

                                    },
                                    StorageDescription = "45 MAIN ST",
                                    PaymentDueDate = "2017-01-27",
                                    DiscountRate = 1.51,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = "2017-01-24",
                                    StorageChargePerBalePerDay = new StorageChargeCurrency
                                    {
                                        Value =0.245,
                                        CurrencyUnit = CurrencyUnit.AUD
                                    },
                                    PenaltyInterestRate = 11.35
                                },
                                 LotInvoiceDetails = new List<LotInvoiceDetail>
                                 {
                                     new LotInvoiceDetail
                                     {
                                         LotInvoiceHeader = new LotInvoiceHeader
                                         {
                                             LotIdentity = "39",
                                             Bales = 34,
                                                          Gross = new Weight
                                                            {
                                                                Value = 23.00,
                                                                Unit = WeightUnit.Kilograms
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 12.00,
                                                                Unit = WeightUnit.Kilograms
                                                            },
                                             CostPerWeightUnit = 25,
                                             FirstCost = new Currency { Value = 12.24, CurrencyUnit = CurrencyUnit.AUD },
                                             PackMaterial = PackMaterial.K
                                         },
                                         LotInvoiceExtension = new LotInvoiceExtension
                                         {
                                             GSTFirstCost =new Currency { Value = 141.11, CurrencyUnit = CurrencyUnit.AUD },
                                             GSTTotalPostSaleCharge = new Currency { Value = 51.80, CurrencyUnit = CurrencyUnit.AUD },
                                             TotalPostSaleCharge = new Currency { Value = 0.00, CurrencyUnit = CurrencyUnit.AUD }
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
                                                      BaleDescription = "AAC",
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
                                                                Unit = WeightUnit.Kilograms
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 12.00,
                                                                Unit = WeightUnit.Kilograms
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "117",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 201.00,
                                                                Unit = WeightUnit.Kilograms
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                Unit = WeightUnit.Kilograms
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "117",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 18.00,
                                                                Unit = WeightUnit.Kilograms
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                Unit = WeightUnit.Kilograms
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "126",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 178.00,
                                                                Unit = WeightUnit.Kilograms
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                Unit = WeightUnit.Kilograms
                                                            }
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "129",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = new Weight
                                                            {
                                                                Value = 168.00,
                                                                Unit = WeightUnit.Kilograms
                                                            },
                                                          Tare = new Weight
                                                            {
                                                                Value = 2.00,
                                                                Unit = WeightUnit.Kilograms
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
                }
            };
        }
    }



}
