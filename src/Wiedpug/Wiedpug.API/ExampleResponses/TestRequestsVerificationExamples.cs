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
    public class TestRequestsVerificationRequestExample : IExamplesProvider<List<TestRequestsVerification>>
    {
        public List<TestRequestsVerification> GetExamples()
        {
            return new List<TestRequestsVerification>()
            {
                new TestRequestsVerification {
                TransmissionHeader = new Domain.Entities.TransmissionHeader
                {
                    DateFormatLastRevised = new LiteralDate{ Date="2020-07-15"},
                    DateTransmissionFileCreated = new LiteralDate{ Date="2016-01-17" },
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                                                OrganisationCode = "AWT",
                    },
                    CurrentReceiver = new Organisation
                    {
                                                OrganisationCode = "BCA",
                    },
                    VersionNumber = "1.10.1",
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.AWTA,
                        SoftwareVersion =  1082
                    },
                    Abn = 72001967184
                },
                                TransferConfig = new TransferConfig
                {
                   TransferType = TransferType.Unrestrict
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
                            NumberOfBales = new NumberOfBales{BalesCount=1 },
                            Gross = new Weight
                            {
                                Value = 1.00,
                                WeightCode = WeightCode.KG
                            },
                            Tare = new Weight
                            {
                                Value = 1.00,
                                WeightCode = WeightCode.KG
                            },
                            LotIdentityOrGroupNumber = "567545",
                        WeightNote = new WeightNote{
                            Prefix = "L",
                            Suffix = 1234567,
                        },
                            LotType = LotType.CombinedCertificate,
                            CentreAuction = new Centre {
                                 CountryCode = CountryCode.AU,
                                 CentreCode = CentreCodeAustralia.A
                            },
                            SourceCode = SourceCode.Grower,
                            IsCompanyAbnApplicable = false
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
                                WeightCode = WeightCode.KG
                            },
                            CoreTestSamplingDate = new LiteralDate { Date="2024-04-15"},
                            CoresPerBale = 5,
                            GrabsPerBale = 10,
                            IsYieldAndMicronTestRequired = true,
                            IsLengthAndStrengthTestRequired = false,
                            IsLengthOnlyTestRequired = true,
                            IsColourTestRequired = false,
                            LaserscanTestRequired = LaserscanTestRequired.N,
                            IsAirflowTestRequired = false,
                            IsOfdaTestRequired = true,
                            IsDarkAndMedullatedFibreTestRequired = false,
                            IsPesticideResidueTestRequired = false
                        },
                        ContractLimitRequirement = new ContractLimitRequirement
                        {
                            MicronMin = 15.5,
                            MicronMax = 25.0,
                            ColourYZMin = 1.2,
                            ColourYZMax = 2.1,
                            VmbMin = 0.85,
                            VmbMax = 1.25,
                            WoolBaseMin = 50.00,
                            WoolBaseMax = 65.00,
                            DichloromethaneDryBasisMin = 0.05,
                            DichloromethaneDryBasisMax = 0.15,
                            ConditioningMassMin = new Weight
                            {
                                Value = 500.00,
                                WeightCode = WeightCode.KG
                            },
                            ConditioningMassMax = new Weight { Value = 1500.00, WeightCode = WeightCode.KG },
                            LacBarbeMin = 10,
                            LacBarbeMax = 30,
                            LacHauteurMin = 15,
                            LacHauteurMax = 45,
                            LacHauteurUnder20Min = 5,
                            LacHauteurUnder20Max = 15,
                            LacHauteurUnder40Min = 8,
                            LacHauteurUnder40Max = 25,
                            LacHauteurCvPercentMin = 10,
                            LacHauteurCvPercentMax = 20
                        },
                        DarkAndMedullatedFibreRiskDetails = new DarkAndMedullatedFibreRiskDetail
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
                            NumberOfBales = new NumberOfBales{BalesCount=1 },
                            Gross = new Weight { Value = 1.00, WeightCode = WeightCode.KG },
                            Tare = new Weight { Value = 1.00, WeightCode = WeightCode.KG },
                            LotIdentityOrGroupNumber = "567545",
                        WeightNote = new WeightNote{
                            Prefix = "L",
                            Suffix = 1234567,
                        },
                            LotType = LotType.CombinedCertificate,
                            CentreAuction = new Centre { CountryCode = CountryCode.AU, CentreCode = CentreCodeAustralia.BA },
                            SourceCode = SourceCode.Dealer,
                            IsCompanyAbnApplicable = false
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
                                WeightCode = WeightCode.KG
                            },
                            CoreTestSamplingDate = new LiteralDate{ Date="2024-04-25"},
                            CoresPerBale = 4,
                            GrabsPerBale = 20,
                            IsYieldAndMicronTestRequired = true,
                            IsLengthAndStrengthTestRequired = false,
                            IsLengthOnlyTestRequired = false,
                            IsColourTestRequired = false,
                            LaserscanTestRequired = LaserscanTestRequired.S,
                            IsAirflowTestRequired = false,
                            IsOfdaTestRequired = false,
                            IsDarkAndMedullatedFibreTestRequired = true,
                            IsPesticideResidueTestRequired = true
                        },
                        ContractLimitRequirement = new ContractLimitRequirement
                        {
                            MicronMin = 12.3,
                            MicronMax = 18.6,
                            ColourYZMin = 1.6,
                            ColourYZMax = 2.5,
                            VmbMin = 0.66,
                            VmbMax = 1.80,
                            WoolBaseMin = 40.00,
                            WoolBaseMax = 55.00,
                            DichloromethaneDryBasisMin = 0.06,
                            DichloromethaneDryBasisMax = 0.12,
                            ConditioningMassMin = new Weight
                            {
                                Value = 260.00,
                                WeightCode = WeightCode.KG
                            },
                            ConditioningMassMax = new Weight
                            {
                                Value = 1200.00,
                                WeightCode = WeightCode.KG
                            },
                            LacBarbeMin = 17,
                            LacBarbeMax = 56,
                            LacHauteurMin = 12,
                            LacHauteurMax = 36,
                            LacHauteurUnder20Min = 3,
                            LacHauteurUnder20Max = 12,
                            LacHauteurUnder40Min = 9,
                            LacHauteurUnder40Max = 15,
                            LacHauteurCvPercentMin = 13,
                            LacHauteurCvPercentMax = 27
                        },
                        DarkAndMedullatedFibreRiskDetails = new DarkAndMedullatedFibreRiskDetail
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

    public class RequestForTestRequestsVerificationExample : IExamplesProvider<List<RequestForData>>
    {
        public List<RequestForData> GetExamples()
        {
            return new List<RequestForData>()
            {
                new RequestForData {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = new LiteralDate{ Date="2020-07-15"},
                    DateTransmissionFileCreated = new LiteralDate{ Date="2016-01-17" },
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                        OrganisationCode = "ABC",
                    },
                    CurrentReceiver = new Organisation
                    {
                        OrganisationCode = "ATW",
                    },
                    VersionNumber = "1.10.1",
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

    public class RequestForTestRequestsVerification200Example : IExamplesProvider<ApiResult<List<TestRequestsVerification>>>
    {
        public ApiResult<List<TestRequestsVerification>> GetExamples()
        {
            return new ApiResult<List<TestRequestsVerification>>()
            {
                
                ApiMessages = [],
                Data = new List<TestRequestsVerification>()
                {
                    new TestRequestsVerification {
                    TransmissionHeader = new Domain.Entities.TransmissionHeader
                    {
                        DateFormatLastRevised = new LiteralDate{ Date="2020-07-15"},
                        DateTransmissionFileCreated = new LiteralDate{ Date="2016-01-17" },
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                                                    OrganisationCode = "AWT",
                        },
                        CurrentReceiver = new Organisation
                        {
                                                    OrganisationCode = "BCA",
                        },
                        VersionNumber = "1.10.1",
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = SoftwareCompany.AWTA,
                            SoftwareVersion =  1082
                        },
                        Abn = 72001967184
                    },
                                    TransferConfig = new TransferConfig
                {
                   TransferType = TransferType.Unrestrict
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
                                NumberOfBales = new NumberOfBales{BalesCount=1 },
                                Gross = new Weight { Value = 1.00, WeightCode = WeightCode.KG },
                                Tare = new Weight { Value = 1.00, WeightCode = WeightCode.KG },
                                LotIdentityOrGroupNumber = "567545",
                                WeightNote = new WeightNote {
                                    Prefix = "L",
                                    Suffix = 1234567,
                                },
                                LotType = LotType.CombinedCertificate,
                                CentreAuction = new Centre { CountryCode = CountryCode.AU, CentreCode = CentreCodeAustralia.A },
                                SourceCode = SourceCode.Grower,
                                IsCompanyAbnApplicable = false
                            },
                            TestRequestVerification = new TestRequestVerification
                            {
                                Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                IsPreviousDataToBeUpdated = true,
                                HashTotal = 123456,
                                GrowerCode = "G123",
                                GrowerName = "John Doe",
                                CoreSampleWeight = new Weight { Value = 20.00, WeightCode = WeightCode.KG },
                                CoreTestSamplingDate = new LiteralDate{ Date="2024-04-15"},
                                CoresPerBale = 5,
                                GrabsPerBale = 10,
                                IsYieldAndMicronTestRequired = true,
                                IsLengthAndStrengthTestRequired = false,
                                IsLengthOnlyTestRequired = true,
                                IsColourTestRequired = false,
                                LaserscanTestRequired = LaserscanTestRequired.P,
                                IsAirflowTestRequired = false,
                                IsOfdaTestRequired = true,
                                IsDarkAndMedullatedFibreTestRequired = false,
                                IsPesticideResidueTestRequired = false
                            },
                            ContractLimitRequirement = new ContractLimitRequirement
                            {
                                MicronMin = 15.5,
                                MicronMax = 25.0,
                                ColourYZMin = 1.2,
                                ColourYZMax = 2.1,
                                VmbMin = 0.85,
                                VmbMax = 1.25,
                                WoolBaseMin = 50.00,
                                WoolBaseMax = 65.00,
                                DichloromethaneDryBasisMin = 0.05,
                                DichloromethaneDryBasisMax = 0.15,
                                ConditioningMassMin = new Weight { Value = 500.00, WeightCode = WeightCode.KG },
                                ConditioningMassMax = new Weight { Value = 1500.00, WeightCode = WeightCode.KG },
                                LacBarbeMin = 10,
                                LacBarbeMax = 30,
                                LacHauteurMin = 15,
                                LacHauteurMax = 45,
                                LacHauteurUnder20Min = 5,
                                LacHauteurUnder20Max = 15,
                                LacHauteurUnder40Min = 8,
                                LacHauteurUnder40Max = 25,
                                LacHauteurCvPercentMin = 10,
                                LacHauteurCvPercentMax = 20
                            },
                            DarkAndMedullatedFibreRiskDetails = new DarkAndMedullatedFibreRiskDetail
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
                                NumberOfBales = new NumberOfBales{BalesCount=1 },
                                Gross = new Weight { Value = 1.00, WeightCode = WeightCode.KG },
                                Tare = new Weight
                                {
                                    Value = 1.00,
                                    WeightCode = WeightCode.KG
                                },
                                LotIdentityOrGroupNumber = "567545",
                                WeightNote = new WeightNote {
                                    Prefix = "L",
                                    Suffix = 1234567,
                                },
                                LotType = LotType.CombinedCertificate,
                                CentreAuction = new Centre { CountryCode = CountryCode.AU, CentreCode = CentreCodeAustralia.A },
                                SourceCode = SourceCode.Dealer,
                                IsCompanyAbnApplicable = false
                            },
                            TestRequestVerification = new TestRequestVerification
                            {
                                Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                IsPreviousDataToBeUpdated = true,
                                HashTotal = 125534,
                                GrowerCode = "G4643",
                                GrowerName = "Alice Stonewood",
                                CoreSampleWeight = new Weight { Value = 164.00, WeightCode = WeightCode.KG },
                                CoreTestSamplingDate = new LiteralDate{ Date="2024-04-25"},
                                CoresPerBale = 4,
                                GrabsPerBale = 20,
                                IsYieldAndMicronTestRequired = true,
                                IsLengthAndStrengthTestRequired = false,
                                IsLengthOnlyTestRequired = false,
                                IsColourTestRequired = false,
                                LaserscanTestRequired = LaserscanTestRequired.N,
                                IsAirflowTestRequired = false,
                                IsOfdaTestRequired = false,
                                IsDarkAndMedullatedFibreTestRequired = true,
                                IsPesticideResidueTestRequired = true
                            },
                            ContractLimitRequirement = new ContractLimitRequirement
                            {
                                MicronMin = 12.3,
                                MicronMax = 18.6,
                                ColourYZMin = 1.6,
                                ColourYZMax = 2.5,
                                VmbMin = 0.66,
                                VmbMax = 1.80,
                                WoolBaseMin = 40.00,
                                WoolBaseMax = 55.00,
                                DichloromethaneDryBasisMin = 0.06,
                                DichloromethaneDryBasisMax = 0.12,
                                ConditioningMassMin = new Weight
                            {
                                Value = 126.00,
                                WeightCode = WeightCode.KG
                            },
                                ConditioningMassMax = new Weight
                            {
                                Value = 1200.00,
                                WeightCode = WeightCode.KG
                            },
                                LacBarbeMin = 17,
                                LacBarbeMax = 56,
                                LacHauteurMin = 12,
                                LacHauteurMax = 36,
                                LacHauteurUnder20Min = 3,
                                LacHauteurUnder20Max = 12,
                                LacHauteurUnder40Min = 9,
                                LacHauteurUnder40Max = 15,
                                LacHauteurCvPercentMin = 13,
                                LacHauteurCvPercentMax = 27
                            },
                            DarkAndMedullatedFibreRiskDetails = new DarkAndMedullatedFibreRiskDetail
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
                }
            };
        }
    }

}
