using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.TestRequestsVerificationAggregate;
using Wiedpug.Domain.Aggregates.TextAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class TestRequestsVerificationRequestExample : IExamplesProvider<TestRequestsVerification>
    {
        public TestRequestsVerification GetExamples()
        {
            return new TestRequestsVerification()
            {
                TransmissionHeader = new Domain.Entities.TransmissionHeader
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
                                                OrganisationCode = "BCA",
                    },
                    VersionNumber = 31,
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.AWTA,
                        Version = 1082
                    },
                    ABN = "72001967184"
                },
                TestRequestsVerificationDetails = new List<TestRequestsVerificationDetail> {
                    new TestRequestsVerificationDetail
                    {
                        TestDataHeader = new TestDataHeader
                        {
                            Client = new Organisation
                            {
                                                        OrganisationCode = "AWT",
                            },
                            Bales = 1,
                            Gross = new Weight
                            {
                                Value = 1.00,
                                Unit = WeightUnit.Kilograms
                            },
                            Tare = new Weight
                            {
                                Value = 1.00,
                                Unit = WeightUnit.Kilograms
                            },
                            LotIdentity = "567545",
                            WeightUnit = WeightUnit.Kilograms,
                        WeightNote = new WeightNote{
                            Prefix = "L",
                            Suffix = "1234567",
                        },
                            LotType = LotType.CombinedCertificate,
                            CentreAuction = new Centre {
                                 Country = CountryCode.AU,
                                 CentreCode = CentreCodeAustralia.A
                            },
                            SourceCode = SourceCode.Grower,
                            IsCompanyABNApplicable = false
                        },
                        TestRequestVerification = new TestRequestVerification
                        {
                            Laboratory = Laboratory.AustralianWoolTestingAuthority,
                            IsPreviousDataToBeUpdated = true,
                            HashTotal = 123456,
                            GrowerCode = "G123",
                            GrowerName = "John Doe",
                            CoreSampleWeight = new Weight
                            {
                                Value =100,
                                Unit = WeightUnit.Kilograms
                            },
                            CoreTestSamplingDate = "2024-04-15",
                            CoresPerBale = 5,
                            GrabsPerBale = 10,
                            IsYieldAndMicronTestRequired = true,
                            IsLengthAndStrengthTestRequired = false,
                            IsLengthOnlyTestRequired = true,
                            IsColourTestRequired = false,
                            IsLaserscanTestRequired = true,
                            IsAirflowTestRequired = false,
                            IsOFDATestRequired = true,
                            IsDarkAndMedullatedFibreTestRequired = false,
                            IsPesticideResidueTestRequired = false
                        },
                        ContractLimitRequirements = new ContractLimitRequirements
                        {
                            MicronMin = 15.5,
                            MicronMax = 25.0,
                            ColourYZMin = 1.2,
                            ColourYZMax = 2.1,
                            VMBMin = 0.85,
                            VMBMax = 1.25,
                            WoolBaseMin = 50.00,
                            WoolBaseMax = 65.00,
                            DichloromethaneDryBasisMin = 0.05,
                            DichloromethaneDryBasisMax = 0.15,
                            ConditioningMassMin = new Weight
                            {
                                Value = 500.00,
                                Unit = WeightUnit.Kilograms
                            },
                            ConditioningMassMax = new Weight { Value = 1500.00, Unit = WeightUnit.Kilograms },
                            LACBarbeMin = 10,
                            LACBarbeMax = 30,
                            LACHauteurMin = 15,
                            LACHauteurMax = 45,
                            LACHauteurUnder20Min = 5,
                            LACHauteurUnder20Max = 15,
                            LACHauteurUnder40Min = 8,
                            LACHauteurUnder40Max = 25,
                            LACHauteurCVPercentMin = 10,
                            LACHauteurCVPercentMax = 20
                        },
                        DarkAndMedullatedFibreRiskDetails = new TestRequestVerificationDarkAndMedullatedFibreRiskDetails
                        {
                            DeclaredBreed = DeclaredBreed.A,
                            DeclaredWoolSubCategory = DeclaredWoolSubCategory.N,
                            DeclaredWoolCategory = DeclaredWoolCategory.P,
                            IsContactingWithExoticBreeds = true,
                            IsCrutched = false,
                            Sex = Sex.R,
                            AgeFrom = 2,
                            IsCrutchedWithin3MonthsOfShearing = true,
                            AgeTo = 5

                        }
                    },
                    new TestRequestsVerificationDetail
                    {
                        TestDataHeader = new TestDataHeader
                        {
                            Client = new Organisation
                            {
                                                        OrganisationCode = "AWT",
                            },
                            Bales = 1,
                            Gross = new Weight { Value = 1.00, Unit = WeightUnit.Kilograms },
                            Tare = new Weight { Value = 1.00, Unit = WeightUnit.Kilograms },
                            LotIdentity = "567545",
                        WeightNote = new WeightNote{
                            Prefix = "L",
                            Suffix = "1234567",
                        },
                            WeightUnit = WeightUnit.Kilograms,
                            LotType = LotType.CombinedCertificate,
                            CentreAuction = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.BA },
                            SourceCode = SourceCode.Dealer,
                            IsCompanyABNApplicable = false
                        },
                        TestRequestVerification = new TestRequestVerification
                        {
                            Laboratory = Laboratory.AustralianWoolTestingAuthority,
                            IsPreviousDataToBeUpdated = true,
                            HashTotal = 125534,
                            GrowerCode = "G4643",
                            GrowerName = "Alice Stonewood",
                            CoreSampleWeight = new Weight
                            {
                                Value=100.00,
                                Unit = WeightUnit.Kilograms
                            },
                            CoreTestSamplingDate = "2024-04-25",
                            CoresPerBale = 4,
                            GrabsPerBale = 20,
                            IsYieldAndMicronTestRequired = true,
                            IsLengthAndStrengthTestRequired = false,
                            IsLengthOnlyTestRequired = false,
                            IsColourTestRequired = false,
                            IsLaserscanTestRequired = false,
                            IsAirflowTestRequired = false,
                            IsOFDATestRequired = false,
                            IsDarkAndMedullatedFibreTestRequired = true,
                            IsPesticideResidueTestRequired = true
                        },
                        ContractLimitRequirements = new ContractLimitRequirements
                        {
                            MicronMin = 12.3,
                            MicronMax = 18.6,
                            ColourYZMin = 1.6,
                            ColourYZMax = 2.5,
                            VMBMin = 0.66,
                            VMBMax = 1.80,
                            WoolBaseMin = 40.00,
                            WoolBaseMax = 55.00,
                            DichloromethaneDryBasisMin = 0.06,
                            DichloromethaneDryBasisMax = 0.12,
                            ConditioningMassMin = new Weight
                            {
                                Value = 260.00,
                                Unit = WeightUnit.Kilograms
                            },
                            ConditioningMassMax = new Weight
                            {
                                Value = 1200.00,
                                Unit = WeightUnit.Kilograms
                            },
                            LACBarbeMin = 17,
                            LACBarbeMax = 56,
                            LACHauteurMin = 12,
                            LACHauteurMax = 36,
                            LACHauteurUnder20Min = 3,
                            LACHauteurUnder20Max = 12,
                            LACHauteurUnder40Min = 9,
                            LACHauteurUnder40Max = 15,
                            LACHauteurCVPercentMin = 13,
                            LACHauteurCVPercentMax = 27
                        },
                        DarkAndMedullatedFibreRiskDetails = new TestRequestVerificationDarkAndMedullatedFibreRiskDetails
                        {
                            DeclaredBreed = DeclaredBreed.A,
                            DeclaredWoolSubCategory = DeclaredWoolSubCategory.N,
                            DeclaredWoolCategory = DeclaredWoolCategory.B,
                            IsContactingWithExoticBreeds = false,
                            IsCrutched = false,
                            Sex = Sex.E,
                            AgeFrom = 1,
                            IsCrutchedWithin3MonthsOfShearing = true,
                            AgeTo = 4

                        }
                    }

                }

            };
        }
    }

    public class RequestForTestRequestsVerificationExample : IExamplesProvider<RequestForData>
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

    public class RequestForTestRequestsVerification200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                
                Message = null,
                Data = new TestRequestsVerification()
                {
                    TransmissionHeader = new Domain.Entities.TransmissionHeader
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
                                                    OrganisationCode = "BCA",
                        },
                        VersionNumber = 31,
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = SoftwareCompany.AWTA,
                            Version = 1082
                        },
                        ABN = "72001967184"
                    },
                    TestRequestsVerificationDetails = new List<TestRequestsVerificationDetail> {
                        new TestRequestsVerificationDetail
                        {
                            TestDataHeader = new TestDataHeader
                            {
                                Client = new Organisation
                                {
                                                            OrganisationCode = "AWT",
                                },
                                Bales = 1,
                                Gross = new Weight { Value = 1.00, Unit = WeightUnit.Kilograms },
                                Tare = new Weight { Value = 1.00, Unit = WeightUnit.Kilograms },
                                LotIdentity = "567545",
                                WeightUnit = WeightUnit.Kilograms,
                                WeightNote = new WeightNote {
                                    Prefix = "L",
                                    Suffix = "1234567",
                                },
                                LotType = LotType.CombinedCertificate,
                                CentreAuction = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.A },
                                SourceCode = SourceCode.Grower,
                                IsCompanyABNApplicable = false
                            },
                            TestRequestVerification = new TestRequestVerification
                            {
                                Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                IsPreviousDataToBeUpdated = true,
                                HashTotal = 123456,
                                GrowerCode = "G123",
                                GrowerName = "John Doe",
                                CoreSampleWeight = new Weight { Value = 20.00, Unit = WeightUnit.Kilograms },
                                CoreTestSamplingDate = "2024-04-15",
                                CoresPerBale = 5,
                                GrabsPerBale = 10,
                                IsYieldAndMicronTestRequired = true,
                                IsLengthAndStrengthTestRequired = false,
                                IsLengthOnlyTestRequired = true,
                                IsColourTestRequired = false,
                                IsLaserscanTestRequired = true,
                                IsAirflowTestRequired = false,
                                IsOFDATestRequired = true,
                                IsDarkAndMedullatedFibreTestRequired = false,
                                IsPesticideResidueTestRequired = false
                            },
                            ContractLimitRequirements = new ContractLimitRequirements
                            {
                                MicronMin = 15.5,
                                MicronMax = 25.0,
                                ColourYZMin = 1.2,
                                ColourYZMax = 2.1,
                                VMBMin = 0.85,
                                VMBMax = 1.25,
                                WoolBaseMin = 50.00,
                                WoolBaseMax = 65.00,
                                DichloromethaneDryBasisMin = 0.05,
                                DichloromethaneDryBasisMax = 0.15,
                                ConditioningMassMin = new Weight { Value = 500.00, Unit = WeightUnit.Kilograms },
                                ConditioningMassMax = new Weight { Value = 1500.00, Unit = WeightUnit.Kilograms },
                                LACBarbeMin = 10,
                                LACBarbeMax = 30,
                                LACHauteurMin = 15,
                                LACHauteurMax = 45,
                                LACHauteurUnder20Min = 5,
                                LACHauteurUnder20Max = 15,
                                LACHauteurUnder40Min = 8,
                                LACHauteurUnder40Max = 25,
                                LACHauteurCVPercentMin = 10,
                                LACHauteurCVPercentMax = 20
                            },
                            DarkAndMedullatedFibreRiskDetails = new TestRequestVerificationDarkAndMedullatedFibreRiskDetails
                            {
                                DeclaredBreed = DeclaredBreed.A,
                                DeclaredWoolSubCategory = DeclaredWoolSubCategory.N,
                                DeclaredWoolCategory = DeclaredWoolCategory.P,
                                IsContactingWithExoticBreeds = true,
                                IsCrutched = false,
                                Sex = Sex.R,
                                AgeFrom = 2,
                                IsCrutchedWithin3MonthsOfShearing = true,
                                AgeTo = 5

                            }
                        },
                        new TestRequestsVerificationDetail
                        {
                            TestDataHeader = new TestDataHeader
                            {
                                Client = new Organisation
                                {
                                                            OrganisationCode = "AWT",
                                },
                                Bales = 1,
                                Gross = new Weight { Value = 1.00, Unit = WeightUnit.Kilograms },
                                Tare = new Weight
                                {
                                    Value = 1.00,
                                    Unit = WeightUnit.Kilograms
                                },
                                LotIdentity = "567545",
                                WeightNote = new WeightNote {
                                    Prefix = "L",
                                    Suffix = "1234567",
                                },
                                WeightUnit = WeightUnit.Kilograms,
                                LotType = LotType.CombinedCertificate,
                                CentreAuction = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.A },
                                SourceCode = SourceCode.Dealer,
                                IsCompanyABNApplicable = false
                            },
                            TestRequestVerification = new TestRequestVerification
                            {
                                Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                IsPreviousDataToBeUpdated = true,
                                HashTotal = 125534,
                                GrowerCode = "G4643",
                                GrowerName = "Alice Stonewood",
                                CoreSampleWeight = new Weight { Value = 164.00, Unit = WeightUnit.Kilograms },
                                CoreTestSamplingDate = "2024-04-25",
                                CoresPerBale = 4,
                                GrabsPerBale = 20,
                                IsYieldAndMicronTestRequired = true,
                                IsLengthAndStrengthTestRequired = false,
                                IsLengthOnlyTestRequired = false,
                                IsColourTestRequired = false,
                                IsLaserscanTestRequired = false,
                                IsAirflowTestRequired = false,
                                IsOFDATestRequired = false,
                                IsDarkAndMedullatedFibreTestRequired = true,
                                IsPesticideResidueTestRequired = true
                            },
                            ContractLimitRequirements = new ContractLimitRequirements
                            {
                                MicronMin = 12.3,
                                MicronMax = 18.6,
                                ColourYZMin = 1.6,
                                ColourYZMax = 2.5,
                                VMBMin = 0.66,
                                VMBMax = 1.80,
                                WoolBaseMin = 40.00,
                                WoolBaseMax = 55.00,
                                DichloromethaneDryBasisMin = 0.06,
                                DichloromethaneDryBasisMax = 0.12,
                                ConditioningMassMin = new Weight
                            {
                                Value = 126.00,
                                Unit = WeightUnit.Kilograms
                            },
                                ConditioningMassMax = new Weight
                            {
                                Value = 1200.00,
                                Unit = WeightUnit.Kilograms
                            },
                                LACBarbeMin = 17,
                                LACBarbeMax = 56,
                                LACHauteurMin = 12,
                                LACHauteurMax = 36,
                                LACHauteurUnder20Min = 3,
                                LACHauteurUnder20Max = 12,
                                LACHauteurUnder40Min = 9,
                                LACHauteurUnder40Max = 15,
                                LACHauteurCVPercentMin = 13,
                                LACHauteurCVPercentMax = 27
                            },
                            DarkAndMedullatedFibreRiskDetails = new TestRequestVerificationDarkAndMedullatedFibreRiskDetails
                            {
                                DeclaredBreed = DeclaredBreed.A,
                                DeclaredWoolSubCategory = DeclaredWoolSubCategory.N,
                                DeclaredWoolCategory = DeclaredWoolCategory.B,
                                IsContactingWithExoticBreeds = false,
                                IsCrutched = false,
                                Sex = Sex.E,
                                AgeFrom = 1,
                                IsCrutchedWithin3MonthsOfShearing = true,
                                AgeTo = 4

                            }
                        }

                    }
                }
            };
        }
    }

}
