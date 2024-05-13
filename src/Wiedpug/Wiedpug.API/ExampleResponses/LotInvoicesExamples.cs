using Swashbuckle.AspNetCore.Filters;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
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
                                SoftwareCompany = "Talman",
                                Version = 10820
                            },
                            Abn = "72001967184"
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
                                    CentreStorage = "M",
                                    SaleDate = "2017-01-19",
                                    WoolState = WoolState.Greasy,
                                    PackType = PackType.TwoBaleTripack,
                                    Currency = "AUD",
                                    WeightUnit = WeightUnit.Kilograms,
                                    PostSaleCharge = 25.96,
                                    CalculationBasis = CalculationBasis.Bale,
                                    FreightCharge = 0,
                                    FreightRebate = 3.25,
                                    ChargePerLot = 0,
                                    InvoiceNumber = null,
                                    InvoicingOrganisation = "ABCD",
                                    ReleasingOrganisation = "ABCD",
                                    SellingOrganisation = "ABCD",
                                    WoolTypeGroup = WoolTypeGroup.MFLC,
                                    CentreCatalogue = Centre.AU_G,
                                    DeliveryBasis = DeliveryBasis.DeliveryNominatedDestination,
                                    CentreDelivery = null,
                                    AlternateDelivery = null
                                },
                                WoolSaleHeaderExtension = new Domain.Entities.WoolSaleHeaderExtension
                                {
                                    StorageOrganisation = "ABCD",
                                    StorageDescription = "45 MAIN ST",
                                    PaymentDueDate = "2017-01-27",
                                    DiscountRate = 1.5,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = "2017-01-24",
                                    StorageChargePerBalePerDay = 0.245,
                                    PenaltyInterestRate = 11.5,
                                    LotAvailableDate = null,
                                    PostSaleChargeRebate = null
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
                                             PackMaterial = PackMaterial.HDPE1Packs
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
                                                 MulesingStatus = MulesingStatus.NotDeclared
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
}
