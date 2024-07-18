﻿using Swashbuckle.AspNetCore.Filters;
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
                                OrganisationCode = "AAT"
                            },
                            CurrentReceiver = new Organisation
                            {
                               OrganisationCode = "ATW"
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
                        CatalogueType = CatalogueType.A,
                        TransferConfig = new TransferConfig
                        {
                            TransferType = TransferType.Exclude,
                            FinalReceiverList = new List<Organisation>
                            {
                                new Organisation{
                                    OrganisationCode = "AMS"
                                },
                                new Organisation{
                                    OrganisationCode = "FIB"
                                }
                            },
                        },
                        WoolSaleHeaders = new List<CatalogueWoolSaleHeader>
                        {
                            new CatalogueWoolSaleHeader
                            {
                                WoolSaleHeaderLots = new WoolSaleHeaderLots
                                {
                                    Season = 16,
                                    SaleIdentity = new Domain.Entities.SaleIdentity
                                    {
                                        SellingCentreType = SellingCentreType.AU_F,
                                        SaleNumber = 29
                                    },
                                    CentreStorage = new Centre { 
                                        Country = CountryCode.AU, CentreCode = CentreCodeAustralia.A },
                                    SaleDate = "2017-01-19",
                                    WoolState = WoolState.A,
                                    PackType = PackType._2,
                                    WeightUnit = WeightUnit.Kilograms,
                                    PostSaleCharge = new Currency{
                                        Value = 25.96,
                                        CurrencyUnit = CurrencyUnit.AUD
                                    },
                                    CalculationBasis = CalculationBasis.B,
                                    FreightCharge = new Currency { Value = 0.00, CurrencyUnit = CurrencyUnit.AUD },
                                    FreightRebate = new Currency { Value = 3.25, CurrencyUnit = CurrencyUnit.AUD },
                                    CatalogueSection = CatalogueSection.FLC,
                                    IsFinalCatalogue = true,
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
                                    CentreCatalogue = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.G },
                                    DeliveryBasis = DeliveryBasis.D,
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
                                        CurrencyUnit = CurrencyUnit.AUD
                                    },
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
                                            PackMaterial = PackMaterial.N,
                                            CatalogueSymbols = "A",
                                            LotType = LotType.SubjectivelyMatchedInterlot,
                                            LightestIndividualBaleWeight = 149.00,
                                            ReportingFlag = ReportingFlag.R,
                                            CostPerWeightUnit = new PriceCurrency
                                            {
                                                Value = 0,
                                                CurrencyUnit = CurrencyUnit.AUD,
                                            },
                                            CleanWeight = 0.00,
                                            PackCondition = PackCondition.N,
                                            CoreTestSamplingDate = "2019-01-17",
                                            WoolDescription = "MF6S",
                                            GstTaxInvoiceFlag = true,
                                            NumberOfOverweightBales = 0
                                        },
                                        //No 21B
                                        EncryptedLotHeaderAwexData = new EncryptedLotHeaderAwexData
                                        {
                                            EncryptionKeyIdentifier = "123e4567-e89b-12d3-a456-426614174000",
                                            LotHeaderAwexData = new Domain.Entities.LotHeaderAwexData //21C
                                            {
                                                AwexId = "MF6S",
                                                AppraiserId = "99192",
                                                ClassersRegisteredNumber = "998921"
                                            },
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
                                            RegrabSampleWeight = 0.00,
                                            StapleLength = 73.00,
                                            Charge = new Currency{ 
                                                Value= 188.50,
                                                CurrencyUnit = CurrencyUnit.AUD
                                            },
                                            StapleLengthCvPercentage = 16,
                                            StapleStrength = 35.00,
                                            PositionOfBreakPercentageTip = 77,
                                            PositionOfBreakPercentageMiddle = 23,
                                            PositionOfBreakPercentageBase = 0,
                                            Team3Hauteur = 72.00,
                                            LsCertType = LsCertType.LengthAndStrengthTested,
                                            ExpectedBarbe = 111.00,
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
                                                        OrganisationCode = "ABC",
                            },
                                                CurrentReceiver = new Organisation
                    {
                                                OrganisationCode = "ATW",
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
                        CatalogueType=CatalogueType.A,
                        TransferConfig = new TransferConfig
                        {
                            TransferType = TransferType.Exclude,
                            FinalReceiverList = new List<Organisation>
                            {
                                new Organisation
                                {
                            OrganisationCode = "AWL",
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
                                    CentreStorage = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.AU },
                                    SaleDate = "2017-01-19",
                                    WoolState = WoolState._1,
                                    PackType = PackType._6,
                                    WeightUnit = WeightUnit.Kilograms,
                                    PostSaleCharge = new Currency{ 
                                        Value=25.96,
                                        CurrencyUnit = CurrencyUnit.AUD
                                    },
                                    CalculationBasis = CalculationBasis.B,
                                    FreightCharge = new Currency { Value = 0.00, CurrencyUnit = CurrencyUnit.AUD },
                                    FreightRebate = new Currency { Value = 3.25, CurrencyUnit = CurrencyUnit.AUD },
                                    CatalogueSection = CatalogueSection.FLC,
                                    IsFinalCatalogue = true,
                                    InvoicingOrganisation = new Organisation { 
                                        OrganisationCode = "ABC",
                                    },
                                    ReleasingOrganisation =  new Organisation
                                    {
                                        OrganisationCode = "ABC",
                                    },
                                    SellingOrganisation = new Organisation
                                    {
                                        OrganisationCode = "ABC",
                                    },
                                    WoolTypeGroup = WoolTypeGroup.MFLC,
                                    CentreCatalogue = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.G },
                                    DeliveryBasis = DeliveryBasis.D,
                                    StorageOrganisation = new Organisation {  
                                        OrganisationCode = "ABC", 
                                    },
                                    StorageDescription = "45 MAIN ST",
                                    DiscountRate = 1.50,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = "2017-01-24",
                                    StorageChargePerBalePerDay = new StorageChargeCurrency
                                    {
                                        Value = 0.245,
                                        CurrencyUnit = CurrencyUnit.AUD
                                    },
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
                                            PackMaterial = PackMaterial.N,
                                            CatalogueSymbols = "A",
                                            LotType = LotType.ClassedGrowerLot,
                                            LightestIndividualBaleWeight = 149.00,
                                            ReportingFlag = ReportingFlag.R,
                                            CostPerWeightUnit = new PriceCurrency{
                                                Value=0,
                                                CurrencyUnit = CurrencyUnit.AUD
                                            },
                                            CleanWeight = 0.00,
                                            PackCondition = PackCondition.N,
                                            CoreTestSamplingDate = "2019-01-17",
                                            WoolDescription = "MF6S",
                                            GstTaxInvoiceFlag = true,
                                            NumberOfOverweightBales = 0
                                        },
                                        //No 21B
                                        EncryptedLotHeaderAwexData = new EncryptedLotHeaderAwexData
                                        {
                                            EncryptionKeyIdentifier = "123e4567-e89b-12d3-a456-426614174000",
                                            LotHeaderAwexData = new Domain.Entities.LotHeaderAwexData //21C
                                            {
                                                AwexId = "MF6S",
                                                AppraiserId = "99192",
                                                ClassersRegisteredNumber = "998921"
                                            },
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
                                            RegrabSampleWeight = 0.00,
                                            Charge = new Currency { Value = 256.23, CurrencyUnit = CurrencyUnit.AUD },
                                            StapleLength = 73.00,
                                            StapleLengthCvPercentage = 16,
                                            StapleStrength = 35.00,
                                            PositionOfBreakPercentageTip = 77,
                                            PositionOfBreakPercentageMiddle = 23,
                                            PositionOfBreakPercentageBase = 0,
                                            Team3Hauteur = 72,
                                            LsCertType = LsCertType.LengthAndStrengthTested,
                                            isLsSampleSecured = true,
                                            ExpectedBarbe = 111.00,
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
                        DocumentOriginator = new Organisation {                         
                            OrganisationCode = "ABC",
                        },
                        VersionNumber = 31,
                                            CurrentReceiver = new Organisation
                    {
                                                OrganisationCode = "ATW",

                    },
                        SoftwareIdentifier = new Domain.ValueObject.SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = SoftwareCompany.Talman,
                            Version = 1082
                        },
                        ABN = "72001967184"
                    },
                    CatalogueType = CatalogueType.A,
                    TransferConfig = new TransferConfig
                        {
                            TransferType = TransferType.Exclude,
                            FinalReceiverList = new List<Organisation>
                            {
                                new Organisation {                         OrganisationCode = "AWM",
},
                                new Organisation {                         OrganisationCode = "FCB",
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
                                CentreStorage = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.A },
                                SaleDate = "2017-01-19",
                                WoolState = WoolState.A,
                                PackType = PackType.F,
                                WeightUnit = WeightUnit.Kilograms,
                                PostSaleCharge = new Currency { Value = 25.96, CurrencyUnit = CurrencyUnit.AUD },
                                CalculationBasis = CalculationBasis.B,
                                FreightCharge = new Currency { Value = 0.00, CurrencyUnit = CurrencyUnit.AUD },
                                FreightRebate = new Currency { Value = 3.25, CurrencyUnit = CurrencyUnit.AUD },
                                CatalogueSection = CatalogueSection.FLC,
                                IsFinalCatalogue = true,
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
                                    CentreCode = CentreCodeAustralia.G },
                                DeliveryBasis = DeliveryBasis.D,
                                StorageOrganisation = new Organisation {  
                                    OrganisationCode = "ABC",
                                },
                                StorageDescription = "45 MAIN ST",
                                DiscountRate = 1.50,
                                MaximumDaysDiscount = 0,
                                DateStorageChargeCommences = "2017-01-24",
                                    StorageChargePerBalePerDay = new StorageChargeCurrency
                                    {
                                        Value = 0.245,
                                        CurrencyUnit = CurrencyUnit.AUD
                                    },
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
                                        PackMaterial = PackMaterial.N,
                                        CatalogueSymbols = "A",
                                        LotType = LotType.ObjectivelyMatchedLot,
                                        LightestIndividualBaleWeight = 149.00,
                                        ReportingFlag = ReportingFlag.R,
                                        CostPerWeightUnit = new PriceCurrency
                                        {
                                            Value=0,
                                            CurrencyUnit = CurrencyUnit.AUD
                                        },
                                        CleanWeight = 0.00,
                                        PackCondition = PackCondition.N,
                                        CoreTestSamplingDate = "2019-01-17",
                                        WoolDescription = "MF6S",
                                        GstTaxInvoiceFlag = true,
                                        NumberOfOverweightBales = 0
                                    },
                                    //No 21B
                                        EncryptedLotHeaderAwexData = new EncryptedLotHeaderAwexData
                                        {
                                            EncryptionKeyIdentifier = "123e4567-e89b-12d3-a456-426614174000",
                                            LotHeaderAwexData = new Domain.Entities.LotHeaderAwexData //21C
                                            {
                                                AwexId = "MF6S",
                                                AppraiserId = "99192",
                                                ClassersRegisteredNumber = "998921"
                                            },
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
                                        Charge = new Currency { Value = 230.23, CurrencyUnit = CurrencyUnit.AUD },
                                        Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                        RegrabSampleWeight = 0.00,
                                        StapleLength = 73.00,
                                        StapleLengthCvPercentage = 16,
                                        StapleStrength = 35.00,
                                        PositionOfBreakPercentageTip = 77,
                                        PositionOfBreakPercentageMiddle = 23,
                                        PositionOfBreakPercentageBase = 0,
                                        Team3Hauteur = 72.00,
                                        LsCertType = LsCertType.LengthAndStrengthTested,
                                        isLsSampleSecured = true,
                                        ExpectedBarbe = 111.00,
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

    public class RequestForDataCatalogueRequestExamples : IMultipleExamplesProvider<List<RequestForData>>
    {        
        IEnumerable<SwaggerExample<List<RequestForData>>> IMultipleExamplesProvider<List<RequestForData>>.GetExamples()
        {
            yield return SwaggerExample.Create(
                "Request for Auction Catalogue Data and Updates",
                new List<RequestForData>
                {
                    new()
                    {
                        CatalogueTransmissionType = Domain.Enums.CatalogueTransmissionType.AuctionCatalogues,
                        SaleIdentity = new Domain.Entities.SaleIdentity
                        {
                            SellingCentreType = SellingCentreType.AU_F,
                            SaleNumber = 18
                        },
                        OrganisationRequested = new Organisation {                         OrganisationCode = "ANF",},
                        SaleDateRequested = "2023-10-31",
                        UseNetworkDateTime = false,
                        WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                        ExcludedClasses = new List<ExcludedClass>
                        {
                            new ExcludedClass
                            {
                                ClassToBeExcluded = ClassToBeExcluded.InterlotComponentBaleHeader
                            },
                            new ExcludedClass
                            {
                                ClassToBeExcluded = ClassToBeExcluded.BaleIdentification
                            }                          
                        },
                        Season = 23
                    },
                    new()
                    {
                        CatalogueTransmissionType = Domain.Enums.CatalogueTransmissionType.AuctionCatalogueUpdates,
                        SaleIdentity = new Domain.Entities.SaleIdentity
                        {
                            SellingCentreType = SellingCentreType.AU_F,
                            SaleNumber = 18
                        },
                        OrganisationRequested = new Organisation
                        {
                                                    OrganisationCode = "ANF",
                        },
                        SaleDateRequested = "2023-10-31",
                        UseNetworkDateTime = false,
                        WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                        ExcludedClasses = new List<ExcludedClass>
                        {
                            new ExcludedClass
                            {
                                ClassToBeExcluded = ClassToBeExcluded.InterlotComponentBaleHeader
                            },
                            new ExcludedClass
                            {
                                ClassToBeExcluded = ClassToBeExcluded.FibreDiameterHistogramHeader
                            }
                        },
                        Season = 23
                    }
                });

            yield return SwaggerExample.Create(
                "Request for Private Catalogue Data",
                new List<RequestForData>
                {
                    new()
                    {
                        CatalogueTransmissionType = Domain.Enums.CatalogueTransmissionType.PrivateCatalogues,
                        SaleIdentity = new Domain.Entities.SaleIdentity
                        {
                            SellingCentreType = SellingCentreType.AU_F,
                            SaleNumber = 18
                        },
                        OrganisationRequested = new Organisation
                        {
                                                    OrganisationCode = "ANF",
                        },
                        SaleDateRequested = "2023-10-31",
                        UseNetworkDateTime = false,
                        WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                        ExcludedClasses = new List<ExcludedClass>
                        {
                            new ExcludedClass
                            {
                                ClassToBeExcluded = ClassToBeExcluded.InterlotComponentBaleHeader
                            },
                            new ExcludedClass
                            {
                                ClassToBeExcluded = ClassToBeExcluded.FibreDiameterHistogramDetails
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
                                                        OrganisationCode = "ABC",
                            },
                                                CurrentReceiver = new Organisation
                    {
                                                OrganisationCode = "ATW",
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
                        CatalogueType=CatalogueType.A,
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
                                        CentreStorage = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.AD },
                                        SaleDate = "2017-01-19",
                                        WoolState = WoolState._1,
                                        PackType = PackType._9,
                                        WeightUnit = WeightUnit.Kilograms,
                                        PostSaleCharge = new Currency { Value = 25.96, CurrencyUnit = CurrencyUnit.AUD },
                                        CalculationBasis = CalculationBasis.B,
                                        FreightCharge = new Currency { Value = 0.00, CurrencyUnit = CurrencyUnit.AUD },
                                        FreightRebate = new Currency { Value = 3.25, CurrencyUnit = CurrencyUnit.AUD },
                                        CatalogueSection = CatalogueSection.FLC,
                                        IsFinalCatalogue = true,
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
                                        CentreCatalogue = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.G },
                                        DeliveryBasis = DeliveryBasis.D,
                                        StorageOrganisation = new Organisation {
                                            OrganisationCode = "ABC", 
                                        },
                                        StorageDescription = "45 MAIN ST",
                                        DiscountRate = 1.50,
                                        MaximumDaysDiscount = 0,
                                        DateStorageChargeCommences = "2017-01-24",
                                        StorageChargePerBalePerDay = new StorageChargeCurrency
                                        {
                                            Value = 0.245,
                                            CurrencyUnit = CurrencyUnit.AUD
                                        },
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
                                                PackMaterial = PackMaterial.N,
                                                CatalogueSymbols = "A",
                                                LotType = LotType.OtherBulkClassLot,
                                                LightestIndividualBaleWeight = 149.00,
                                                ReportingFlag = ReportingFlag.R,
                                                CostPerWeightUnit = new PriceCurrency
                                                {
                                                    Value = 0,
                                                    CurrencyUnit = CurrencyUnit.AUD,
                                                },
                                                CleanWeight = 0.00,
                                                PackCondition = PackCondition.N,
                                                CoreTestSamplingDate = "2019-01-17",
                                                WoolDescription = "MF6S",
                                                NumberOfOverweightBales = 0
                                            },
                                            //No 21B
                                            EncryptedLotHeaderAwexData = new EncryptedLotHeaderAwexData
                                            {
                                                EncryptionKeyIdentifier = "123e4567-e89b-12d3-a456-426614174000",
                                                LotHeaderAwexData = new Domain.Entities.LotHeaderAwexData //21C
                                                {
                                                    AwexId = "MF6S",
                                                    AppraiserId = "99192",
                                                    ClassersRegisteredNumber = "998921"
                                                },
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
                                                Charge = new Currency { Value = 174.30, CurrencyUnit = CurrencyUnit.AUD },
                                                Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                                RegrabSampleWeight = 0.0,
                                                StapleLength = 73.00,
                                                StapleLengthCvPercentage = 16,
                                                StapleStrength = 35.00,
                                                PositionOfBreakPercentageTip = 77,
                                                PositionOfBreakPercentageMiddle = 23,
                                                PositionOfBreakPercentageBase = 0,
                                                Team3Hauteur = 72.00,
                                                LsCertType = LsCertType.LengthAndStrengthTested,
                                                isLsSampleSecured = true,     
                                                ExpectedBarbe = 111.00,
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
