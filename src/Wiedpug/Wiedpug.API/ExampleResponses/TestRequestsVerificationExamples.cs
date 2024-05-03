using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.Domain.Aggregates.TestRequestsVerificationAggregate;
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
                TestRequestsVerificationDetails = new List<TestRequestsVerificationDetail> {
                    new TestRequestsVerificationDetail
                    {
                        TestDataHeader = new TestDataHeader
                        {
                            Client = new Client
                            {
                                OrganizationCode = "AWTA"
                            },
                            Bales = 1,
                            Gross = 1,
                            Tare = 1,
                            RegrabSampleWeight=1,
                            WeightUnit = WeightUnit.Kilograms,
                            LotType = LotType.ClassedGrowerLot,
                            CentreAuction = Centre.AU_A,
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.InformationOnly,
                            ScouredType = ScouredType.NotScoured,
                            IsGSTApplicable = false,
                            IsCompanyABNApplicable = false
                        },
                        TestRequestVerification = new TestRequestVerification
                        {
                            Laboratory = Laboratory.AustralianWoolTestingAuthority,
                            UpdatePreviousData = true,
                            HashTotal = 123456,
                            GrowerCode = "G123",
                            GrowerName = "John Doe",
                            CoreSampleWeight = 200,
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
                            MicronMin = 15.5d,
                            MicronMax = 25.0d,
                            ColourYZMin = 1.2d,
                            ColourYZMax = 2.1d,
                            VMBMin = 0.85d,
                            VMBMax = 1.25d,
                            WoolBaseMin = 50.00d,
                            WoolBaseMax = 65.00d,
                            DichloromethaneDryBasisMin = 0.05d,
                            DichloromethaneDryBasisMax = 0.15d,
                            ConditioningMassMin = 500,
                            ConditioningMassMax = 1500,
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
                        DarkAndMedullatedFibreRiskDetails = new DarkAndMedullatedFibreRiskDetails
                        {
                            DeclaredBreed = DeclaredBreed.AustralianSuperfine,
                            DeclaredWoolSubCategory = DeclaredWoolSubCategory.NotRequired,
                            DeclaredWoolCategory = DeclaredWoolCategory.Pieces,
                            ContactWithExoticBreeds = true,
                            Crutched = false,
                            Sex = Sex.Rams,
                            AgeFrom = 2,
                            DeclaredQualifierCode1 = null,
                            DeclaredQualifierCode2 = null,
                            DeclaredQualifierScale = null,
                            CrutchedWithin3MonthsOfShearing = true,
                            AgeTo = 5,
                            DarkAndMedullatedFibreRiskBroker = null

                        },
                        Bales = null
                    },
                    new TestRequestsVerificationDetail
                    {
                        TestDataHeader = new TestDataHeader
                        {
                            Client = new Client
                            {
                                OrganizationCode = "AWTA"
                            },
                            Bales = 1,
                            Gross = 1,
                            Tare = 1,
                            RegrabSampleWeight=1,
                            WeightUnit = WeightUnit.Kilograms,
                            LotType = LotType.ObjectivelyMatchedInterlot,
                            CentreAuction = Centre.AU_BA,
                            SourceCode = SourceCode.Dealer,
                            ReportingFlag = ReportingFlag.InformationOnly,
                            ScouredType = ScouredType.ScouredDualSolvent,
                            IsGSTApplicable = false,
                            IsCompanyABNApplicable = false
                        },
                        TestRequestVerification = new TestRequestVerification
                        {
                            Laboratory = Laboratory.AustralianWoolTestingAuthority,
                            UpdatePreviousData = true,
                            HashTotal = 125534,
                            GrowerCode = "G4643",
                            GrowerName = "Alice Stonewood",
                            CoreSampleWeight = 164,
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
                            MicronMin = 12.3d,
                            MicronMax = 18.6d,
                            ColourYZMin = 1.6d,
                            ColourYZMax = 2.5d,
                            VMBMin = 0.66d,
                            VMBMax = 1.80d,
                            WoolBaseMin = 40.00d,
                            WoolBaseMax = 55.00d,
                            DichloromethaneDryBasisMin = 0.06d,
                            DichloromethaneDryBasisMax = 0.12d,
                            ConditioningMassMin = 260,
                            ConditioningMassMax = 1200,
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
                        DarkAndMedullatedFibreRiskDetails = new DarkAndMedullatedFibreRiskDetails
                        {
                            DeclaredBreed = DeclaredBreed.AustralianSuperfine,
                            DeclaredWoolSubCategory = DeclaredWoolSubCategory.NotRequired,
                            DeclaredWoolCategory = DeclaredWoolCategory.Bellies,
                            ContactWithExoticBreeds = false,
                            Crutched = false,
                            Sex = Sex.Ewes,
                            AgeFrom = 1,
                            DeclaredQualifierCode1 = null,
                            DeclaredQualifierCode2 = null,
                            DeclaredQualifierScale = null,
                            CrutchedWithin3MonthsOfShearing = true,
                            AgeTo = 4,
                            DarkAndMedullatedFibreRiskBroker = null

                        },
                        Bales = null
                    }

                }

            };
        }
    }
}
