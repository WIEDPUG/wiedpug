using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class CatalogueRequestExamples : IMultipleExamplesProvider<List<Catalogue>>
    {
        public IEnumerable<SwaggerExample<List<Catalogue>>> GetExamples()
        {
            yield return SwaggerExample.Create(
                "New Auction Catalogue",
                new List<Catalogue>
                {
                    new()
                    {
                        TransmissionHeader = new Domain.Entities.TransmissionHeader
                        {
                            DateFormatLastRevised = "2020-07-15",
                            DateTransmissionFileCreated = "2016-01-17",
                            CountryOfOrigin = Domain.Enums.CountryCode.AU,
                            DocumentOriginator =new Organisation
                            {
                                OrganisationId ="AWTA"
                            },
                            VersionNumber = 31,
                            SoftwareIdentifier = new Domain.ValueObject.SoftwareIdentifier
                            {
                                ProgramName = "NETR",
                                SoftwareCompany = SoftwareCompany.Talman,
                                Version = 1082
                            },
                            ABN = "72001967184"
                        },
                        CatalogueType = CatalogueType.AuctionCatalogues,
                        TransferConfig = new TransferConfig
                        {
                            TransferType = TransferType.Broadcast,
                            ExclusionList = new List<Organisation>
                            {
                                new Organisation{
                                   OrganisationId = "AMSC"
                                },
                                new Organisation{
                                   OrganisationId = "FIBC"
                                }
                            },
                        },
                        WoolSaleHeaders = new List<CatalogueWoolSaleHeader>
                        {
                            new CatalogueWoolSaleHeader
                            {
                                WoolSaleHeaderLots = new WoolSaleHeaderLots //10
                                {
                                    Season = 16,
                                    SaleIdentity = new Domain.Entities.SaleIdentity
                                    {
                                        SellingCentreType = SellingCentreType.AU_F,
                                        SaleNumber = 29
                                    },
                                    CentreStorage = Centre.AU_AR,
                                    SaleDate = "2017-01-19",
                                    WoolState = WoolState.A,
                                    PackType = PackType._2,
                                    Currency = "AUD",
                                    WeightUnit = WeightUnit.Kilograms,
                                    PostSaleCharge = 25.96,
                                    CalculationBasis = CalculationBasis.B,
                                    FreightCharge = 0.00,
                                    FreightRebate = 3.25,
                                    ChargePerLot = 0.00,
                                    CatalogueSection = CatalogueSection.FLC,
                                    IsFinalCatalogue = true,
                                    InvoicingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },
                                    ReleasingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },
                                    SellingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },
                                    WoolTypeGroup = WoolTypeGroup.MFLC,
                                    CentreCatalogue = Centre.AU_G,
                                    DeliveryBasis = DeliveryBasis.D,
                                    StorageOrganisation = "ABCD",
                                    StorageDescription = "45 MAIN ST",
                                    PaymentDueDate = "2017-01-27",
                                    DiscountRate = 1.50,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = "2017-01-24",
                                    StorageChargePerBalePerDay = 0.245,
                                    PenaltyInterestRate = 11.35,
                                },
                                // No 11BA
                                Lots = new List<CatalogueWoolSaleHeaderLot>
                                {
                                    new CatalogueWoolSaleHeaderLot
                                    {
                                        LotHeader = new Domain.Entities.LotHeader //20
                                        {
                                            LotIdentity = "671",
                                            Bales = 8,
                                            Gross = 1316,
                                            Tare = 16,
                                            CataloguePageNumber = 65,
                                            UpdateType = UpdateType.A,
                                            CatalogueSymbols = CatalogueSymbol.A,
                                            PackMaterial = PackMaterial.N,
                                            LotType = LotType.SubjectivelyMatchedInterlot,
                                            LightestIndividualBaleWeight = 149,
                                            ReportingFlag = ReportingFlag.R,
                                            CostPerWeightUnit = 0,
                                            CleanWeight = 0,
                                            PackCondition = PackCondition.N
                                        },
                                        LotHeaderExtension = new Domain.Entities.LotHeaderExtension //21A
                                        {
                                            CoreTestSamplingDate = "2019-01-17",
                                            WoolDescription = "MF6S",
                                            GstTaxInvoiceFlag = true,
                                            NumberOfOverweightBales = 0
        ,                               },
                                        //No 21B
                                        LotHeaderAwexData = new Domain.Entities.LotHeaderAwexData //21C
                                        {
                                            AwexId = "MF6S",
                                            AppraiserId = "99192",
                                            ClassersRegisteredNumber = "998921"
                                        },
                                        LotHeaderVendorDeclarations = new List<Domain.Entities.LotHeaderVendorDeclaration> //25A
                                        {
                                            new Domain.Entities.LotHeaderVendorDeclaration
                                            {
                                                MulesingStatus = MulesingStatus.NM
                                            }
                                        },
                                        LengthAndStrengthDetails = new Domain.Entities.LengthAndStrengthDetails //51L
                                        {
                                            CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                                CertificateIDNumber = "00000664",
                                                CertificateIDSuffix = CertificateIDSuffix.L,
                                                CertificateIDCD = 6
                                            },
                                            Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                            RegrabSampleWeight = 0,
                                            StapleLength = 73,
                                            Charge = 188.50,
                                            StapleLengthCvPercentage = 16,
                                            StapleStrength = 35,
                                            PositionOfBreakPercentageTip = 77,
                                            PositionOfBreakPercentageMiddle = 23,
                                            PositionOfBreakPercentageBase = 0,
                                            Team3Hauteur = 72,
                                            LsCertType = LsCertType.LengthAndStrengthTested,
                                            ExpectedBarbe = 111,
                                            Team3HauteurCvPercentage = 36.9,
                                            Team3RomainePercentage = 11.2,
                                            DateIssued = "2017-01-10",
                                            StapleStrengthLowest25Percent = 24,
                                            isLsSampleSecured = true
                                        },
                                        CoreTestDetails = new Domain.Entities.CoreTestDetails //51P
                                        {
                                            CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                                CertificateIDNumber = "00000499",
                                                CertificateIDSuffix = CertificateIDSuffix.P,
                                                CertificateIDCD = 7
                                            },
                                            Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                            WoolBase = 64.29,
                                            AirflowMean = 0.0,
                                            Vmb = 1.3,
                                            HardHeadsBase = 0.0,
                                            Yield1 = 74.40,
                                            Yield2 = 78.50,
                                            Yield3 = 75.70,
                                            Yield4 = 72.10,
                                            RetestFlag = RetestFlag.NormalTest,
                                            Yield5 = 77.80,
                                            ReissueChargeFlag = ReissueChargeFlag.OriginalCertificateCharge,
                                            Vm1 = 0.0,
                                            Vm2 = 0.9,
                                            Vm3 = 0.0,
                                            DarkAndMedullatedFibreRisk = DarkAndMedullatedFibreRisk.N
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
                                                    CoreTestSamplingDate = "2017-01-10",
                                                    DateIssued = "2017-01-10"
                                                }
                                            }
                                        },
                                        CatalogueLotDescription = new Domain.Entities.CatalogueLotDescription //79A
                                        {
                                            Brand = "SALTBUSH/DOWNS",
                                            BaleDescription = "AAAM",
                                            AreaOfOrigin = "V11",
                                            Bales = 8,
                                        },
                                        BaleIdentifications = new List<Domain.ValueObject.BaleIdentification> //84
                                        {
                                            new Domain.ValueObject.BaleIdentification
                                            {
                                                EBaleId = "093253480000021002346917",
                                                BaleNumber = "1"
                                            }
                                        },
                                        InterlotComponentBales = new List<CatalogueWoolSaleHeaderLotInterlotComponentBale>
                                        {
                                            new CatalogueWoolSaleHeaderLotInterlotComponentBale
                                            {
                                                InterlotComponentBaleHeader = new InterlotComponentBaleHeader //79B
                                                {
                                                    Brand = "RC/FARMING",
                                                    BaleDescription = "AAAMLMS",
                                                    AreaOfOrigin = "W14",
                                                    LocationWithinStore = "Z1-33",
                                                    Bales = 2,
                                                    Postcode = "6510"
                                                },
                                                BaleIdentifications = new List<Domain.ValueObject.BaleIdentification> //84
                                                {
                                                    new Domain.ValueObject.BaleIdentification
                                                    {
                                                        EBaleId = "093253480000021002346918",
                                                        BaleNumber = "2"
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                });

            yield return SwaggerExample.Create(
                "New Private Catalogue",
                new List<Catalogue>
                {
                    new()
                    {
                        TransmissionHeader = new Domain.Entities.TransmissionHeader
                        {
                            DateFormatLastRevised = "2020-07-15",
                            DateTransmissionFileCreated = "2016-01-17",
                            CountryOfOrigin = Domain.Enums.CountryCode.AU,
                            DocumentOriginator = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },
                            VersionNumber = 31,
                            SoftwareIdentifier = new Domain.ValueObject.SoftwareIdentifier
                            {
                                ProgramName = "NETR",
                                SoftwareCompany = SoftwareCompany.Talman,
                                Version = 1082
                            },
                            ABN = "72001967184"
                        },
                        CatalogueType=CatalogueType.AuctionCatalogues,
                        TransferConfig = new TransferConfig
                        {
                            TransferType = TransferType.PrivateSend,
                            InclusionList = new List<Organisation>
                            {
                                new Organisation
                                {
                                    OrganisationId="AWXLC"
                                }
                            }
                        },
                        WoolSaleHeaders = new List<CatalogueWoolSaleHeader>
                        {
                            new CatalogueWoolSaleHeader
                            {
                                WoolSaleHeaderLots = new Domain.Entities.WoolSaleHeaderLots //10
                                {
                                    Season = 16,
                                    SaleIdentity = new Domain.Entities.SaleIdentity
                                    {
                                        SellingCentreType = SellingCentreType.AU_M,
                                        SaleNumber = 29
                                    },
                                    CentreStorage = Centre.AU_AU,
                                    SaleDate = "2017-01-19",
                                    WoolState = WoolState._1,
                                    PackType = PackType._6,
                                    Currency = "AUD",
                                    WeightUnit = WeightUnit.Kilograms,
                                    PostSaleCharge = 25.96,
                                    CalculationBasis = CalculationBasis.B,
                                    FreightCharge = 0.00,
                                    FreightRebate = 3.25,
                                    ChargePerLot = 0.00,
                                    CatalogueSection = CatalogueSection.FLC,
                                    IsFinalCatalogue = true,
                                    InvoicingOrganisation = new Organisation { OrganisationId = "ABCD" },
                                    ReleasingOrganisation =  new Organisation
                            {
                                OrganisationId = "ABCD"
                            },
                                    SellingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },
                                    WoolTypeGroup = WoolTypeGroup.MFLC,
                                    CentreCatalogue = Centre.AU_G,
                                    DeliveryBasis = DeliveryBasis.D,
                                    StorageOrganisation = "ABCD",
                                    StorageDescription = "45 MAIN ST",
                                    PaymentDueDate = "2017-01-27",
                                    DiscountRate = 1.50,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = "2017-01-24",
                                    StorageChargePerBalePerDay = 0.245,
                                    PenaltyInterestRate = 11.35
                                },
                                // No 11BA
                                Lots = new List<CatalogueWoolSaleHeaderLot>
                                {
                                    new CatalogueWoolSaleHeaderLot
                                    {
                                        LotHeader = new Domain.Entities.LotHeader //20
                                        {
                                            LotIdentity = "671",
                                            Bales = 8,
                                            Gross = 1316,
                                            Tare = 16,
                                            CataloguePageNumber = 65,
                                            UpdateType = UpdateType.A,
                                            CatalogueSymbols = CatalogueSymbol.C,
                                            PackMaterial = PackMaterial.N,
                                            LotType = LotType.ClassedGrowerLot,
                                            LightestIndividualBaleWeight = 149,
                                            ReportingFlag = ReportingFlag.R,
                                            CostPerWeightUnit = 0,
                                            CleanWeight = 0,
                                            PackCondition = PackCondition.N
                                        },
                                        LotHeaderExtension = new Domain.Entities.LotHeaderExtension //21A
                                        {
                                            CoreTestSamplingDate = "2019-01-17",
                                            WoolDescription = "MF6S",
                                            GstTaxInvoiceFlag = true,
                                            NumberOfOverweightBales = 0
        ,                               },
                                        //No 21B
                                        LotHeaderAwexData = new Domain.Entities.LotHeaderAwexData //21C
                                        {
                                            AwexId = "MF6S",
                                            AppraiserId = "99192",
                                            ClassersRegisteredNumber = "998921"
                                        },
                                        LotHeaderVendorDeclarations = new List<Domain.Entities.LotHeaderVendorDeclaration> //25A
                                        {
                                            new Domain.Entities.LotHeaderVendorDeclaration
                                            {
                                                MulesingStatus = MulesingStatus.AA
                                            }
                                        },
                                        LengthAndStrengthDetails = new Domain.Entities.LengthAndStrengthDetails //51L
                                        {
                                            CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                                CertificateIDNumber = "00000664",
                                                CertificateIDSuffix = CertificateIDSuffix.L,
                                                CertificateIDCD = 6
                                            },
                                            Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                            RegrabSampleWeight = 0,
                                            Charge = 256.23,
                                            StapleLength = 73,
                                            StapleLengthCvPercentage = 16,
                                            StapleStrength = 35,
                                            PositionOfBreakPercentageTip = 77,
                                            PositionOfBreakPercentageMiddle = 23,
                                            PositionOfBreakPercentageBase = 0,
                                            Team3Hauteur = 72,
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
                                           CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                                CertificateIDNumber = "00000499",
                                                CertificateIDSuffix = CertificateIDSuffix.P,
                                                CertificateIDCD = 7
                                            },
                                            Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                            WoolBase = 64.29,
                                            AirflowMean = 0.0,
                                            Vmb = 1.3,
                                            HardHeadsBase = 0.0,
                                            Yield1 = 74.40,
                                            Yield2 = 78.50,
                                            Yield3 = 75.70,
                                            Yield4 = 72.10,
                                            RetestFlag = RetestFlag.NormalTest,
                                            Yield5 = 77.80,
                                            ReissueChargeFlag = ReissueChargeFlag.OriginalCertificateCharge,
                                            Vm1 = 0.0,
                                            Vm2 = 0.9,
                                            Vm3 = 0.0,
                                            DarkAndMedullatedFibreRisk = DarkAndMedullatedFibreRisk.N
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
                                                    ReportingFlag = ReportingFlag.R,
                                                    Instrument = Instrument.LaserScan,
                                                    SubSamplingMethod = SubSamplingMethod.Minicore,
                                                    NumberOfSpecimens = 4,
                                                    Mean = 20.1,
                                                    StandardDeviation = 4.0,
                                                    CurvatureMeanDegPerMm = 61,
                                                    CoreTestSamplingDate = "2017-01-10",
                                                    DateIssued = "2017-01-10"
                                                }
                                            }
                                        },
                                        CatalogueLotDescription = new Domain.Entities.CatalogueLotDescription //79A
                                        {
                                            Brand = "SALTBUSH/DOWNS",
                                            BaleDescription = "AAAM",
                                            AreaOfOrigin = "V11",
                                            Bales = 8,
                                        },
                                        InterlotComponentBales = new List<CatalogueWoolSaleHeaderLotInterlotComponentBale>
                                        {
                                            new CatalogueWoolSaleHeaderLotInterlotComponentBale
                                            {
                                                InterlotComponentBaleHeader = new InterlotComponentBaleHeader //79B
                                                {
                                                    Brand = "RC/FARMING",
                                                    BaleDescription = "AAAMLMS",
                                                    AreaOfOrigin = "W14",
                                                    LocationWithinStore = "Z1-33",
                                                    Bales = 2,
                                                    Postcode = "6510"
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                });
        }
    }

    public class CatalogueUpdatesRequestExample : IExamplesProvider<List<Catalogue>>
    {
        public List<Catalogue> GetExamples()
        {
            return new List<Catalogue>
            {
                new()
                {
                    TransmissionHeader = new Domain.Entities.TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = new Organisation { OrganisationId = "ABCD" },
                        VersionNumber = 31,
                        SoftwareIdentifier = new Domain.ValueObject.SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = SoftwareCompany.Talman,
                            Version = 1082
                        },
                        ABN = "72001967184"
                    },
                    CatalogueType = CatalogueType.AuctionCatalogues,
                    TransferConfig = new TransferConfig
                        {
                            TransferType = TransferType.Broadcast,
                            ExclusionList = new List<Organisation>
                            {
                                new Organisation { OrganisationId = "AWMS" },
                                new Organisation { OrganisationId = "FCBB" }
                            }
                    },
                    WoolSaleHeaders = new List<CatalogueWoolSaleHeader>
                    {
                        new CatalogueWoolSaleHeader
                        {
                            WoolSaleHeaderLots = new Domain.Entities.WoolSaleHeaderLots //10
                            {
                                Season = 16,
                                SaleIdentity = new Domain.Entities.SaleIdentity
                                {
                                    SellingCentreType = SellingCentreType.AU_M,
                                    SaleNumber = 29
                                },
                                CentreStorage = Centre.AU_A,
                                SaleDate = "2017-01-19",
                                WoolState = WoolState.A,
                                PackType = PackType.F,
                                Currency = "AUD",
                                WeightUnit = WeightUnit.Kilograms,
                                PostSaleCharge = 25.96,
                                CalculationBasis = CalculationBasis.B,
                                FreightCharge = 0.00,
                                FreightRebate = 3.25,
                                ChargePerLot = 0.00,
                                CatalogueSection = CatalogueSection.FLC,
                                IsFinalCatalogue = true,
                                InvoicingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },
                                ReleasingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },
                                SellingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },
                                WoolTypeGroup = WoolTypeGroup.MFLC,
                                CentreCatalogue = Centre.AU_G,
                                DeliveryBasis = DeliveryBasis.D,
                                StorageOrganisation = "ABCD",
                                StorageDescription = "45 MAIN ST",
                                PaymentDueDate = "2017-01-27",
                                DiscountRate = 1.50,
                                MaximumDaysDiscount = 0,
                                DateStorageChargeCommences = "2017-01-24",
                                StorageChargePerBalePerDay = 0.245,
                                PenaltyInterestRate = 11.35,
                            },

                            // No 11BA
                            Lots = new List<CatalogueWoolSaleHeaderLot>
                            {
                                new CatalogueWoolSaleHeaderLot
                                {
                                    LotHeader = new Domain.Entities.LotHeader //20
                                    {
                                        LotIdentity = "671",
                                        Bales = 8,
                                        Gross = 1316,
                                        Tare = 16,
                                        CataloguePageNumber = 65,
                                        UpdateType = UpdateType.A,
                                        CatalogueSymbols = CatalogueSymbol.A,
                                        PackMaterial = PackMaterial.N,
                                        LotType = LotType.ObjectivelyMatchedLot,
                                        LightestIndividualBaleWeight = 149,
                                        ReportingFlag = ReportingFlag.R,
                                        CostPerWeightUnit = 0,
                                        CleanWeight = 0,
                                        PackCondition = PackCondition.N
                                    },
                                    LotHeaderExtension = new Domain.Entities.LotHeaderExtension //21A
                                    {
                                        CoreTestSamplingDate = "2019-01-17",
                                        WoolDescription = "MF6S",
                                        NumberOfOverweightBales = 0
    ,                               },
                                    //No 21B
                                    LotHeaderAwexData = new Domain.Entities.LotHeaderAwexData //21C
                                    {
                                        AwexId = "MF6S",
                                        AppraiserId = "99192",
                                        ClassersRegisteredNumber = "998921"
                                    },
                                    LotHeaderVendorDeclarations = new List<Domain.Entities.LotHeaderVendorDeclaration> //25A
                                    {
                                        new Domain.Entities.LotHeaderVendorDeclaration
                                        {

                                            MulesingStatus = MulesingStatus.AA
                                        }
                                    },
                                    LengthAndStrengthDetails = new Domain.Entities.LengthAndStrengthDetails //51L
                                    {
                                        CertificateIdentity = new CertificateIdentity
                                        {
                                            CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                            CertificateIDSuffix = CertificateIDSuffix.C,
                                            CertificateIDNumber = "00000664",
                                            CertificateIDCD = 6
                                        },
                                        Charge = 230.23,
                                        Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                        RegrabSampleWeight = 0,
                                        StapleLength = 73,
                                        StapleLengthCvPercentage = 16,
                                        StapleStrength = 35,
                                        PositionOfBreakPercentageTip = 77,
                                        PositionOfBreakPercentageMiddle = 23,
                                        PositionOfBreakPercentageBase = 0,
                                        Team3Hauteur = 72,
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
                                        CertificateIdentity = new CertificateIdentity
                                        {
                                            CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                            CertificateIDSuffix = CertificateIDSuffix.M,
                                            CertificateIDNumber = "00000499",
                                            CertificateIDCD = 5

                                        },
                                        Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                        RegrabSampleWeight = null,
                                        WoolBase = 64.29,
                                        AirflowMean = 0.0,
                                        Vmb = 1.3,
                                        HardHeadsBase = 0.0,
                                        Yield1 = 74.40,
                                        Yield2 = 78.50,
                                        Yield3 = 75.70,
                                        Yield4 = 72.10,
                                        RetestFlag = RetestFlag.NormalTest,
                                        Yield5 = 77.80,
                                        ReissueChargeFlag = ReissueChargeFlag.OriginalCertificateCharge,
                                        Vm1 = 0.0,
                                        Vm2 = 0.9,
                                        Vm3 = 0.0,
                                        DarkAndMedullatedFibreRisk = DarkAndMedullatedFibreRisk.D
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
                                                ReportingFlag = ReportingFlag.R,
                                                Instrument = Instrument.LaserScan,
                                                SubSamplingMethod = SubSamplingMethod.Minicore,
                                                NumberOfSpecimens = 4,
                                                Mean = 20.1,
                                                StandardDeviation = 4.0,
                                                CurvatureMeanDegPerMm = 61,
                                                CoreTestSamplingDate = "2017-01-10",
                                                DateIssued = "2017-01-10"
                                            },
                                            FibreDiameterHistogramDetails = new List<FibreDiameterHistogramDetail>
                                            {
                                                new FibreDiameterHistogramDetail //32A
                                                {
                                                    FibreMeasurements = new List<Domain.ValueObject.FibreDiameterHistogramDetailMeasurement>
                                                    {
                                                        new Domain.ValueObject.FibreDiameterHistogramDetailMeasurement
                                                        {
                                                            FibreDiameter = 6,
                                                            FibresMeasuredPercentage = 0.2503
                                                        },
                                                        new Domain.ValueObject.FibreDiameterHistogramDetailMeasurement
                                                        {
                                                            FibreDiameter = 7,
                                                            FibresMeasuredPercentage = 0.2503
                                                        },
                                                        new Domain.ValueObject.FibreDiameterHistogramDetailMeasurement
                                                        {
                                                            FibreDiameter = 8,
                                                            FibresMeasuredPercentage = 0.1500
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
                }                
            };
        }
    }

    public class RequestForDataCatalogueRequestExamples : IMultipleExamplesProvider<List<RequestForDataForCatalogue>>
    {        
        IEnumerable<SwaggerExample<List<RequestForDataForCatalogue>>> IMultipleExamplesProvider<List<RequestForDataForCatalogue>>.GetExamples()
        {
            yield return SwaggerExample.Create(
                "Request for Auction Catalogue Data and Updates",
                new List<RequestForDataForCatalogue>
                {
                    new()
                    {
                        TransmissionTypeRequested = Domain.Enums.TransmissionTypeForCatalogue.AuctionCatalogues,
                        SaleIdentity = new Domain.Entities.SaleIdentity
                        {
                            SellingCentreType = SellingCentreType.AU_F,
                            SaleNumber = 18
                        },
                        OrganisationRequested = new Organisation { OrganisationId = "AWNF" },
                        SaleDateRequested = "2023-10-31",
                        UseNetworkDateTime = false,
                        WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                        ExcludedTypes = new List<ExcludedType>
                        {
                            new ExcludedType
                            {
                                RecordTypesToBeExcluded = RecordTypesToBeExcluded._79B
                            },
                            new ExcludedType
                            {
                                RecordTypesToBeExcluded = RecordTypesToBeExcluded._84
                            }                          
                        },
                        Season = 23
                    },
                    new()
                    {
                        TransmissionTypeRequested = Domain.Enums.TransmissionTypeForCatalogue.AuctionCatalogueUpdates,
                        SaleIdentity = new Domain.Entities.SaleIdentity
                        {
                            SellingCentreType = SellingCentreType.AU_F,
                            SaleNumber = 18
                        },
                        OrganisationRequested = new Organisation
                        {
                            OrganisationId = "AWNF"
                        },
                        SaleDateRequested = "2023-10-31",
                        UseNetworkDateTime = false,
                        WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                        ExcludedTypes = new List<ExcludedType>
                        {
                            new ExcludedType
                            {
                                RecordTypesToBeExcluded = RecordTypesToBeExcluded._79B
                            },
                            new ExcludedType
                            {
                                RecordTypesToBeExcluded = RecordTypesToBeExcluded._31
                            }
                        },
                        Season = 23
                    }
                });

            yield return SwaggerExample.Create(
                "Request for Private Catalogue Data",
                new List<RequestForDataForCatalogue>
                {
                    new()
                    {
                        TransmissionTypeRequested = Domain.Enums.TransmissionTypeForCatalogue.PrivateCatalogues,
                        SaleIdentity = new Domain.Entities.SaleIdentity
                        {
                            SellingCentreType = SellingCentreType.AU_F,
                            SaleNumber = 18
                        },
                        OrganisationRequested = new Organisation
                        {
                            OrganisationId = "AWNF"
                        },
                        SaleDateRequested = "2023-10-31",
                        UseNetworkDateTime = false,
                        WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                        ExcludedTypes = new List<ExcludedType>
                        {
                            new ExcludedType
                            {
                                RecordTypesToBeExcluded = RecordTypesToBeExcluded._79B
                            },
                            new ExcludedType
                            {
                                RecordTypesToBeExcluded = RecordTypesToBeExcluded._32A
                            }
                        },
                        Season = 23
                    }
                });
        }
    }

    public class RequestForDataCatalogue200Example : IExamplesProvider<ApiResult<List<Catalogue>>>
    {
        public ApiResult<List<Catalogue>> GetExamples()
        {
            return new ApiResult<List<Catalogue>>()
            {
                IsSuccessful = true,
                Message = null,
                Data = new List<Catalogue>()
                {
                    new()
                    {
                        TransmissionHeader = new Domain.Entities.TransmissionHeader
                        {
                            DateFormatLastRevised = "2020007-15",
                            DateTransmissionFileCreated = "2016-01-17",
                            CountryOfOrigin = Domain.Enums.CountryCode.AU,
                            DocumentOriginator = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },
                            VersionNumber = 31,
                            SoftwareIdentifier = new Domain.ValueObject.SoftwareIdentifier
                            {
                                ProgramName = "NETR",
                                SoftwareCompany = SoftwareCompany.AWTA,
                                Version = 1082
                            },
                            ABN = "72001967184"
                        },
                        CatalogueType=CatalogueType.AuctionCatalogues,
                        WoolSaleHeaders = new List<CatalogueWoolSaleHeader>
                            {
                                new CatalogueWoolSaleHeader
                                {
                                    WoolSaleHeaderLots = new Domain.Entities.WoolSaleHeaderLots //10
                                    {
                                        Season = 16,
                                        SaleIdentity = new Domain.Entities.SaleIdentity
                                        {
                                            SellingCentreType = SellingCentreType.AU_M,
                                            SaleNumber = 29
                                        },
                                        CentreStorage = Centre.AU_AD,
                                        SaleDate = "2017-01-19",
                                        WoolState = WoolState._1,
                                        PackType = PackType._9,
                                        Currency = "AUD",
                                        WeightUnit = WeightUnit.Kilograms,
                                        PostSaleCharge = 25.96,
                                        CalculationBasis = CalculationBasis.B,
                                        FreightCharge = 0.00,
                                        FreightRebate = 3.25,
                                        ChargePerLot = 0.00,
                                        CatalogueSection = CatalogueSection.FLC,
                                        IsFinalCatalogue = true,
                                        InvoicingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },
                                        ReleasingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },
                                        SellingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },
                                        WoolTypeGroup = WoolTypeGroup.MFLC,
                                        CentreCatalogue = Centre.AU_G,
                                        DeliveryBasis = DeliveryBasis.D,
                                        StorageOrganisation = "ABCD",
                                        StorageDescription = "45 MAIN ST",
                                        PaymentDueDate = "2017-01-27",
                                        DiscountRate = 1.50,
                                        MaximumDaysDiscount = 0,
                                        DateStorageChargeCommences = "2017-01-24",
                                        StorageChargePerBalePerDay = 0.245,
                                        PenaltyInterestRate = 11.35,
                                    },
                                    // No 11BA
                                    Lots = new List<CatalogueWoolSaleHeaderLot>
                                    {
                                        new CatalogueWoolSaleHeaderLot
                                        {
                                            LotHeader = new Domain.Entities.LotHeader //20
                                            {
                                                LotIdentity = "671",
                                                Bales = 8,
                                                Gross = 1316,
                                                Tare = 16,
                                                CataloguePageNumber = 65,
                                                UpdateType = UpdateType.A,
                                                CatalogueSymbols = CatalogueSymbol.C,
                                                PackMaterial = PackMaterial.N,
                                                LotType = LotType.OtherBulkClassLot,
                                                LightestIndividualBaleWeight = 149,
                                                ReportingFlag = ReportingFlag.R,
                                                CostPerWeightUnit = 0,
                                                CleanWeight = 0,
                                                PackCondition = PackCondition.N
                                            },
                                            LotHeaderExtension = new Domain.Entities.LotHeaderExtension //21A
                                            {
                                                CoreTestSamplingDate = "2019-01-17",
                                                WoolDescription = "MF6S",
                                                NumberOfOverweightBales = 0
            ,                               },
                                            //No 21B
                                            LotHeaderAwexData = new Domain.Entities.LotHeaderAwexData //21C
                                            {
                                                AwexId = "MF6S",
                                                AppraiserId = "99192",
                                                ClassersRegisteredNumber = "998921"
                                            },
                                            LotHeaderVendorDeclarations = new List<Domain.Entities.LotHeaderVendorDeclaration> //25A
                                            {
                                                new Domain.Entities.LotHeaderVendorDeclaration
                                                {
                                                    MulesingStatus = MulesingStatus.M
                                                }
                                            },
                                            LengthAndStrengthDetails = new Domain.Entities.LengthAndStrengthDetails //51L
                                            {
                                              CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                                CertificateIDNumber = "00000664",
                                                CertificateIDSuffix = CertificateIDSuffix.L,
                                                CertificateIDCD = 6
                                            },
                                                Charge = 174.30,
                                                Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                                RegrabSampleWeight = 0,
                                                StapleLength = 73,
                                                StapleLengthCvPercentage = 16,
                                                StapleStrength = 35,
                                                PositionOfBreakPercentageTip = 77,
                                                PositionOfBreakPercentageMiddle = 23,
                                                PositionOfBreakPercentageBase = 0,
                                                Team3Hauteur = 72,
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
                                              CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                                CertificateIDNumber = "00000499",
                                                CertificateIDSuffix = CertificateIDSuffix.P,
                                                CertificateIDCD = 7
                                            },
                                                Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                                WoolBase = 64.29,
                                                AirflowMean = 0.0,
                                                Vmb = 1.3,
                                                HardHeadsBase = 0.0,
                                                Yield1 = 74.40,
                                                Yield2 = 78.50,
                                                Yield3 = 75.70,
                                                Yield4 = 72.10,
                                                RetestFlag = RetestFlag.NormalTest,
                                                Yield5 = 77.80,
                                                ReissueChargeFlag = ReissueChargeFlag.OriginalCertificateCharge,
                                                Vm1 = 0.0,
                                                Vm2 = 0.9,
                                                Vm3 = 0.0,
                                                DarkAndMedullatedFibreRisk = DarkAndMedullatedFibreRisk.N
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
                                                        ReportingFlag = ReportingFlag.R,
                                                        Instrument = Instrument.LaserScan,
                                                        SubSamplingMethod = SubSamplingMethod.Minicore,
                                                        NumberOfSpecimens = 4,
                                                        Mean = 20.1,
                                                        StandardDeviation = 4.0,
                                                        CurvatureMeanDegPerMm = 61,
                                                        CoreTestSamplingDate = "2017-01-10",
                                                        DateIssued = "2017-01-10"
                                                    }
                                                }
                                            },
                                            CatalogueLotDescription = new Domain.Entities.CatalogueLotDescription //79A
                                            {
                                                Brand = "SALTBUSH/DOWNS",
                                                BaleDescription = "AAAM",
                                                AreaOfOrigin = "V11",
                                                Bales = 8
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
}
