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
                    DocumentOriginator = new Organisation
                    {
                        OrganizationCode = "AWTA"
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
                                OrganizationCode = "AWTA"
                            },
                            Bales = 1,
                            Gross = 1,
                            Tare = 1,
                            RegrabSampleWeight=1,
                            WeightUnit = WeightUnit.Kilograms,
                            LotType = LotType.CombinedCertificate,
                            CentreAuction = Centre.AU_A,
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.R,
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
                            CoreSampleWeight = 20,
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
                            CertificateIdentity = new CertificateIdentity
                            {
                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                CertificateIDNumber = "16547898",
                                CertificateIDSuffix = CertificateIDSuffix.L,
                                CertificateIDCD = 6
                            },
                            DeclaredBreed = DeclaredBreed.A,
                            DeclaredWoolSubCategory = DeclaredWoolSubCategory.N,
                            DeclaredWoolCategory = DeclaredWoolCategory.P,
                            ContactWithExoticBreeds = true,
                            WoolBase = 23.24,
                            Crutched = false,
                            Sex = Sex.R,
                            AgeFrom = 2,
                            CrutchedWithin3MonthsOfShearing = true,
                            AgeTo = 5

                        }
                    },
                    new TestRequestsVerificationDetail
                    {
                        TestDataHeader = new TestDataHeader
                        {
                            Client = new Organisation
                            {
                                OrganizationCode = "AWTA"
                            },
                            Bales = 1,
                            Gross = 1,
                            Tare = 1,
                            RegrabSampleWeight=1,
                            WeightUnit = WeightUnit.Kilograms,
                            LotType = LotType.CombinedCertificate,
                            CentreAuction = Centre.AU_BA,
                            SourceCode = SourceCode.Dealer,
                            ReportingFlag = ReportingFlag.R,
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
                            CertificateIdentity = new CertificateIdentity
                            {
                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                CertificateIDNumber = "300000664",
                                CertificateIDSuffix = CertificateIDSuffix.L,
                                CertificateIDCD = 6
                            },
                            DeclaredBreed = DeclaredBreed.A,
                            DeclaredWoolSubCategory = DeclaredWoolSubCategory.N,
                            DeclaredWoolCategory = DeclaredWoolCategory.B,
                            ContactWithExoticBreeds = false,
                            Crutched = false,
                            WoolBase = 26.09,
                            Sex = Sex.E,
                            AgeFrom = 1,
                            CrutchedWithin3MonthsOfShearing = true,
                            AgeTo = 4

                        }
                    }

                }

            };
        }
    }
}
