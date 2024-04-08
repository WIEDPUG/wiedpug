using Swashbuckle.AspNetCore.Filters;
using Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate;
using Wiedpug.Domain.Enums;

namespace Wiedpug.API.ExampleResponses
{
    public class AuctionCatalogueRequestExample : IExamplesProvider<AuctionCatalogue>
    {
        public AuctionCatalogue GetExamples()
        {
            return new AuctionCatalogue
            {
                TransmissionHeader = new Domain.Entities.TransmissionHeader
                {
                    DateFormatLastRevised = "2020-07-15",
                    DateTransmissionFileCreated = "2016-01-17",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = "ABCD",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXLC",
                    FinalReceiver = "AWXLC",
                    AccessPassword = "1111111111",
                    AccessPasswordReplacement = null,
                    TransmissionType = Domain.Enums.TransmissionType.AuctionCatalogues,
                    VersionNumber = 31,
                    SoftwareIdentifier = new Domain.ValueObject.SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = "Talman",
                        Version = 10820
                    },
                    Abn = "72001967184"
                },
                WoolSaleHeaders = new List<AuctionCatalogueWoolSaleHeader>
                {
                    new AuctionCatalogueWoolSaleHeader
                    {
                        WoolSaleHeaderLots = new Domain.Entities.WoolSaleHeaderLots
                        {
                            Season = 16,
                            SaleIdentity = new Domain.Entities.SaleIdentity
                            {
                                SellingCentreType = "M",
                                SaleNumber = 29
                            },
                            CentreStorage = "M",
                            SaleDate = "2017-01-19",
                            WoolState = WoolState._1,
                            PackType = PackType._0,
                            Currency = "AUD",
                            WeightUnit = WeightUnit.Kilograms,
                            PostSaleCharge = 25.96,
                            CalculationBasis = CalculationBasis.B,
                            FreightCharge = 0,
                            FreightRebate = 3.25,
                            ChargePerLot = 0,
                            InvoiceNumber = null,
                            CatalogueSection = CatalogueSection.FLC,
                            IsFinalCatalogue = true,
                            InvoicingOrganisation = "ABCD",
                            ReleasingOrganisation = "ABCD",
                            SellingOrganisation = "ABCD",
                            WoolTypeGroup = WoolTypeGroup.MFLC,
                            CentreCatalogue = Centre.AU_G,
                            DeliveryBasis = DeliveryBasis.D,
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
                        Lots = new List<AuctionCatalogueWoolSaleHeaderLot>
                        {
                            //new AuctionCatalogueWoolSaleHeaderLot
                            //{
                            //    LotHeader = new Domain.Entities.LotHeader
                            //    {
                            //        LotIdentity = "671",
                            //        Bales = 8,
                            //        Gross = 1316,
                            //        Tare = 16,
                            //        RegrabSampleWeight = null,
                            //        CataloguePageNumber = 65,
                            //        IsNoLot = null,
                            //        SourceCode = null,
                            //        UpdateType = UpdateType.A,
                            //        CatalogueSymbols = null,
                            //        PackMaterial = PackMaterial.N,
                            //        LotType = LotType.P,
                            //        LightestIndividualBaleWeight = 149,
                            //        ReportingFlag = ReportingFlag.C,
                            //        FirstOfferSeason = null,
                            //        FirstOfferSaleIdentity = null,
                            //        FirstOfferLotIdentity = null,
                            //        CostPerWeightUnit = 0,
                            //        CleanWeight = 0,
                            //        YieldType = null,
                            //        WeightUnit = null,
                            //        OfferType = null,
                            //        ClientCrossReference = null,
                            //        PackCondition = PackCondition.N
                            //    }                                
                            //}
                        }
                    }
                }
            };
        }
    }
}
