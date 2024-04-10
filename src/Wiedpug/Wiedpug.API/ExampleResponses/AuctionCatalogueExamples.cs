using Swashbuckle.AspNetCore.Filters;
using Wiedpug.Domain.Aggregates;
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
                        WoolSaleHeaderLots = new Domain.Entities.WoolSaleHeaderLots //10
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
                        WoolSaleHeaderExtension = new Domain.Entities.WoolSaleHeaderExtension //11A
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
                        // No 11BA
                        Lots = new List<AuctionCatalogueWoolSaleHeaderLot>
                        {
                            new AuctionCatalogueWoolSaleHeaderLot
                            {                                
                                LotHeader = new Domain.Entities.LotHeader //20
                                {
                                    LotIdentity = "671",
                                    Bales = 8,
                                    Gross = 1316,
                                    Tare = 16,
                                    RegrabSampleWeight = null,
                                    CataloguePageNumber = 65,
                                    IsNoLot = null,
                                    SourceCode = null,
                                    UpdateType = UpdateType.A,
                                    CatalogueSymbols = null,
                                    PackMaterial = PackMaterial.N,
                                    LotType = LotType.P,
                                    LightestIndividualBaleWeight = 149,
                                    ReportingFlag = ReportingFlag.C,
                                    FirstOfferSeason = null,
                                    FirstOfferSaleIdentity = null,
                                    FirstOfferLotIdentity = null,
                                    CostPerWeightUnit = 0,
                                    CleanWeight = 0,
                                    YieldType = null,
                                    WeightUnit = null,
                                    OfferType = null,
                                    ClientCrossReference = null,
                                    PackCondition = PackCondition.N
                                },
                                LotHeaderExtension = new Domain.Entities.LotHeaderExtension //21A
                                {
                                    CoreTestSamplingDate = "2019-01-17",
                                    WoolDescriptionComment = null,
                                    WoolDescription = "MF6S",
                                    GstTaxInvoiceFlag = true,
                                    BrokerReservePrice = null,
                                    GrowerReservePrice = null,
                                    OpeningPrice = null,
                                    ValuationPrice = null,
                                    WoolDescriptionAuditCode = null,
                                    NumberOfOverweightBales = 0
,                               },
                                //No 21B
                                LotHeaderAwexData = new Domain.Entities.LotHeaderAwexData //21C
                                {
                                    AwexId = "MF6S",
                                    AppraiserId = "99192",
                                    ClassersRegisteredNumber = "998921",
                                    AwexIdComment = null,
                                    AwexIdAuditCode = null
                                },
                                LotHeaderVendorDeclarations = new List<Domain.Entities.LotHeaderVendorDeclaration> //25A
                                {
                                    new Domain.Entities.LotHeaderVendorDeclaration
                                    {
                                        QualityScheme1 = null,
                                        QualityScheme2 = null,
                                        QualityScheme3 = null,
                                        MulesingStatus = "AA"
                                    }
                                },
                                LengthAndStrengthDetails = new Domain.Entities.LengthAndStrengthDetails //51L
                                {
                                    CertificateIdentity = "300000664L6",
                                    Charge = null,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                    RegrabSampleWeight = 0,
                                    StapleLength = 73,
                                    StapleLengthCvPercentage = 16,
                                    StapleStrength = 35,
                                    PositionOfBreakPercentageTip = 77,
                                    PositionOfBreakPercentageMiddle = 23,
                                    PositionOfBreakPercentageBase = 0,
                                    Team3Hauteur = 72,
                                    ReissueChargeFlag = null,
                                    LsCertType = LsCertType.LengthAndStrengthTested,
                                    isLsSampleSecured = true,
                                    ExpectedBarbe = 111,
                                    Team3HauteurCvPercentage = 36.9,
                                    Team3RomainePercentage = 11.2,
                                    DateIssued = "2017-01-10",
                                    StapleStrengthLowest25Percent = 24
                                },
                                CoreTestDetails = new Domain.Entities.CoreTestDetails //51P
                                {
                                    CertificateIdentity = "300000499P7",
                                    Charge = null,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                    RegrabSampleWeight = null,
                                    WoolBase = 64.29,
                                    AirflowMean = 0,
                                    Vmb = 1.3,
                                    HardHeadsBase = 0,
                                    Yield1 = 74.40,
                                    Yield2 = 78.50,
                                    Yield3 = 75.70,
                                    Yield4 = 72.10,
                                    YieldType1 = null,
                                    YieldType2 = null,
                                    RetestFlag = RetestFlag.NormalTest,
                                    Yield5 = 77.80,
                                    ReissueChargeFlag = ReissueChargeFlag.OriginalCertificateCharge,
                                    Vm1 = 0.0,
                                    Vm2 = 0.9,
                                    Vm3 = 0.0,
                                    DarkAndMedullatedFibreRisk = DarkAndMedullatedFibreRisk._1
                                },
                                Histograms = new List<FibreDiameterHistogram>
                                {
                                    new FibreDiameterHistogram
                                    {
                                        FibreDiameterHistogramHeader = new Domain.Entities.FibreDiameterHistogramHeader //31
                                        {
                                            CoefficientOfVariation = 19.9,
                                            ComfortFactorPercentage = 98.7,
                                            FibresMeasured = 4000,
                                            ReportingFlag = ReportingFlag.C,
                                            Instrument = Instrument.LaserScan,
                                            SubSamplingMethod = SubSamplingMethod.Minicore,
                                            NumberOfSpecimens = 4,
                                            Mean = 20.1,
                                            StandardDeviation = 4.0,
                                            CurvatureMeanDegPerMm = 61,
                                            MeanMinimum = null,
                                            MeanMaximum = null,
                                            CoreTestSamplingDate = "2017-01-10",
                                            DateIssued = "2017-01-10",
                                            FactorLaserscanNumerator = null,
                                            FactorLaserscanDenominator = null
                                        }
                                    }
                                },
                                CatalogueLotDescription = new Domain.Entities.CatalogueLotDescription //79A
                                {
                                    Brand = "SALTBUSH/DOWNS",
                                    BaleDescription = "AAAM",
                                    AreaOfOrigin = "V11",
                                    LocationWithinStore = null,
                                    Bales = 8,
                                    Postcode = null
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
