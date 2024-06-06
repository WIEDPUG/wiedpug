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
                            DocumentOriginator = "ABCD",
                            CurrentTransmitter = "AWTM",
                            CurrentReceiver = "AWXLC",
                            FinalReceiver = "AWXLC",
                            TransmissionType = TransmissionType.TestCertificate,
                            VersionNumber = 31,
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
                                        SellingCentreType = "M",
                                        SaleNumber = 29
                                    },
                                    CentreStorage = Centre.AU_AR,
                                    SaleDate = "2017-01-19",
                                    WoolState = WoolState.C,
                                    PackType = PackType.F,
                                    Currency = "AUD",
                                    WeightUnit = WeightUnit.Kilograms,
                                    PostSaleCharge = 25.96,
                                    CalculationBasis = CalculationBasis.B,
                                    FreightCharge = 0.00,
                                    FreightRebate = 3.25,
                                    ChargePerLot = 0.00,
                                    InvoicingOrganisation = "ABCD",
                                    ReleasingOrganisation = "ABCD",
                                    SellingOrganisation = "ABCD",
                                    WoolTypeGroup = WoolTypeGroup.MFLC,
                                    CentreCatalogue = Centre.AU_G,
                                    DeliveryBasis = DeliveryBasis.D
                                },
                                WoolSaleHeaderExtension = new Domain.Entities.WoolSaleHeaderExtension
                                {
                                    StorageOrganisation = "ABCD",
                                    StorageDescription = "45 MAIN ST",
                                    PaymentDueDate = "2017-01-27",
                                    DiscountRate = 1.51,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = "2017-01-24",
                                    StorageChargePerBalePerDay = 0.245,
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
                                             Gross = 23,
                                             Tare = 12,
                                             CostPerWeightUnit = 25,
                                             FirstCost = 12.24,
                                             PackMaterial = PackMaterial.K
                                         },
                                         LotInvoiceExtension = new LotInvoiceExtension
                                         {
                                             GSTFirstCost =141.11,
                                             GSTTotalPostSaleCharge = 51.80,
                                             TotalPostSaleCharge = 0.00
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
                                                          Gross = 181,
                                                          Tare = 2
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "117",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = 201,
                                                          Tare = 2
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "117",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = 201,
                                                          Tare = 2
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "126",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = 179,
                                                          Tare = 2
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "129",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = 167,
                                                          Tare = 2
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

    public class RequestForLotInovicesExample : IExamplesProvider<RequestForLotInvoices>
    {
        public RequestForLotInvoices GetExamples()
        {
            return new RequestForLotInvoices()
            {
                SaleIdentity = new Domain.Entities.SaleIdentity
                {
                    SellingCentreType = "F",
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

    public class RequestForLotInvoices200Example : IExamplesProvider<ApiResult<LotInvoices>>
    {
        public ApiResult<LotInvoices> GetExamples()
        {
            return new ApiResult<LotInvoices>()
            {
                IsSuccessful = true,
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
                            DocumentOriginator = "ABCD",
                            CurrentTransmitter = "AWTM",
                            CurrentReceiver = "AWXLC",
                            FinalReceiver = "AWXLC",
                            TransmissionType = TransmissionType.TestCertificate,
                            VersionNumber = 31,
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
                                        SellingCentreType = "M",
                                        SaleNumber = 29
                                    },
                                    CentreStorage = Centre.AU_AR,
                                    SaleDate = "2017-01-19",
                                    WoolState = WoolState.C,
                                    PackType = PackType.F,
                                    Currency = "AUD",
                                    WeightUnit = WeightUnit.Kilograms,
                                    PostSaleCharge = 25.96,
                                    CalculationBasis = CalculationBasis.B,
                                    FreightCharge = 0.00,
                                    FreightRebate = 3.25,
                                    ChargePerLot = 0.00,
                                    InvoicingOrganisation = "ABCD",
                                    ReleasingOrganisation = "ABCD",
                                    SellingOrganisation = "ABCD",
                                    WoolTypeGroup = WoolTypeGroup.MFLC,
                                    CentreCatalogue = Centre.AU_G,
                                    DeliveryBasis = DeliveryBasis.D
                                },
                                WoolSaleHeaderExtension = new Domain.Entities.WoolSaleHeaderExtension
                                {
                                    StorageOrganisation = "ABCD",
                                    StorageDescription = "45 MAIN ST",
                                    PaymentDueDate = "2017-01-27",
                                    DiscountRate = 1.51,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = "2017-01-24",
                                    StorageChargePerBalePerDay = 0.245,
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
                                             Gross = 23,
                                             Tare = 12,
                                             CostPerWeightUnit = 25,
                                             FirstCost = 12.24,
                                             PackMaterial = PackMaterial.K
                                         },
                                         LotInvoiceExtension = new LotInvoiceExtension
                                         {
                                             GSTFirstCost =141.11,
                                             GSTTotalPostSaleCharge = 51.80,
                                             TotalPostSaleCharge = 0.00
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
                                                          Gross = 181,
                                                          Tare = 2
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "117",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = 201,
                                                          Tare = 2
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "117",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = 201,
                                                          Tare = 2
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "126",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = 179,
                                                          Tare = 2
                                                      },
                                                       new BaleDetail
                                                      {
                                                          BaleNumber = "129",
                                                          BaleDetailType = BaleDetailType.GreasyOrProcessed,
                                                          Gross = 167,
                                                          Tare = 2
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
