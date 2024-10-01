using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.TestCertificateAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Interface;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class CreateTestCertificatesRequestExample : IExamplesProvider<List<TestCertificates>>
    {
        public List<TestCertificates> GetExamples()
        {
            return new List<TestCertificates>()
            {
                new TestCertificates {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = new UtcDate{ Date="2020-07-15"},
                    DateTransmissionFileCreated = new UtcDate{ Date="2016-01-17" },
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
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.Talman,
                        SoftwareVersion =  1082
                    },
                    Abn = 72001967184
                },
                TestCertificateDetails = new List<TestCertificateDetail>
                {
                    new TestCertificateDetail {
                        TestDataHeader = new TestDataHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationCode = "ATW",
                            },
                            NumberOfBales = new NumberOfBales{BalesCount=1 },
                            Gross =new Weight
                        {
                            Value =1.00,
                            WeightCode = WeightCode.KG
                        },
                            Tare = new Weight
                        {
                            Value =10.00,
                            WeightCode = WeightCode.KG
                        },
                            LotIdentityOrGroupNumber = "234234",
                            RegrabSampleWeight = new Weight
                            {
                                Value = 1.00,
                                WeightCode = WeightCode.KG
                            },
                            LotType = LotType.ObjectivelyMatchedInterlot,
                            CentreAuction = new Centre{
                                CountryCode = CountryCode.AU,
                                CentreCode =  CentreCodeAustralia.A
                            },
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.R,
                            ScouredType = ScouredType.NotScoured,
                            IsGstApplicable = false,
                            IsCompanyAbnApplicable = false
                        },
                            TestDetail =new TestDetail
                            {
                                CertificateIdentity =  new CertificateIdentity{
                                    CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                                    CertificateIdNumber = 23456787,
                                    CertificateIdSuffix = CertificateIdSuffix.D,
                                    CertificateIdCd = 7
                                },
                                TestDetailsType = TestDetailType.P,
                                Charge = new Currency { Value = 100.00, CurrencyCode = CurrencyCode.AUD },
                                Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                WoolBase = 20.00,
                                Vmb = 10.0,
                                HardHeadsBase =3.5,
                                Yields = new List<Yield>
                                            {
                                                new Yield
                                                {
                                                    YieldValue = 74.40,
                                                    YieldType = YieldType.Reserved
                                                },
                                                new Yield
                                                {
                                                    YieldValue = 78.50,
                                                    YieldType = YieldType.IWTOScouredYieldAt16PercentsRegain
                                                },
                                                new Yield
                                                {
                                                    YieldValue = 75.70,
                                                    YieldType = YieldType.IWTOCleanWoolContentAt17PercentsRegain
                                                },
                                                new Yield
                                                {
                                                    YieldValue = 72.10,
                                                    YieldType = YieldType.Reserved
                                                },

                                            },
                                RetestFlag = RetestFlag.NormalTest,
                                ReissueChargeFlag = ReissueChargeFlag.OriginalCertificateCharge,
                                Vm1 = 20.0
                            },
                        FibreDiameterHistograms = new List<FibreDiameterHistogram> {
                            new FibreDiameterHistogram
                            {
                                FibreDiameterHistogramHeader = new FibreDiameterHistogramHeader
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
                                     CoreTestSamplingDate = new UtcDate{ Date="2017-01-10"},
                                     DateIssued = new UtcDate{ Date="2017-01-10"}
                                },
                                FibreDiameterHistogramDetailMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
                                        {
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 23,
                                                FibresMeasuredPercentage = 0.2345
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 24,
                                                FibresMeasuredPercentage = 0.2228
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 25,
                                                FibresMeasuredPercentage = 0.2543
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 27,
                                                FibresMeasuredPercentage = 0.3262
                                            }
                                }
                            }
                        }

                    },
                    new TestCertificateDetail
                    {
                        TestDataHeader = new TestDataHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationCode = "ATC",

                            },
                            NumberOfBales = new NumberOfBales{BalesCount=1 },
                            Gross = new Weight { Value = 40.00, WeightCode = WeightCode.KG },
                            Tare = new Weight
                            {
                                Value =10.00,
                                WeightCode = WeightCode.KG
                            },
                            RegrabSampleWeight= new Weight
                            {
                                Value = 1.00,
                                WeightCode = WeightCode.KG
                            },
                            LotIdentityOrGroupNumber = "123456",
                            LotType = LotType.SubjectivelyMatchedInterlot,
                            CentreAuction = new Centre{
                                CountryCode = CountryCode.AU,
                                CentreCode =  CentreCodeAustralia.A
                        },
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.U,
                            ScouredType = ScouredType.NotScoured,
                            IsGstApplicable = false,
                            IsCompanyAbnApplicable = false
                        },
                        LengthAndStrengthTestDetail =
                            new LengthAndStrengthTestDetail{
                                CertificateIdentity =  new CertificateIdentity{
                                        CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                                        CertificateIdNumber = 23456787,
                                        CertificateIdSuffix = CertificateIdSuffix.D,
                                        CertificateIdCd = 7
                                    },
                                lengthAndStrengthTestDetailsType = LengthAndStrengthTestDetailType.K,
                                Charge = new Currency { Value = 123.25, CurrencyCode = CurrencyCode.AUD },
                                ReissueChargeFlag = ReissueChargeFlag.OriginalCertificateCharge,
                                Laboratory = Laboratory.NZWoolTestingAuthority,
                                StapleLength = 13,
                                StapleLengthCvPercentage = 25,
                                StapleStrength = 14,
                                StapleLengthMinimum = 13,
                                StapleLengthMaximum = 14,
                                StapleStrengthMinimum = 234,
                                StapleStrengthMaximum = 230,
                                PositionOfBreakPercentageTip = 26,
                                PositionOfBreakPercentageMiddle = 34,
                                PositionOfBreakPercentageBase = 27,
                                LsCertType = LsCertType.LengthAndStrengthTested,
                                IsLsSampleSecured = false,
                                DateIssued = new UtcDate{ Date="2024-01-22"}
                            },
                        SublotCertificateNumbers = new List<CertificateIdentity>
                        {
                            new CertificateIdentity{
                                    CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                                    CertificateIdNumber = 23456787,
                                    CertificateIdSuffix = CertificateIdSuffix.D,
                                    CertificateIdCd = 7
                                },
                        },
                        FibreDiameterHistograms = new List<FibreDiameterHistogram> {
                            new FibreDiameterHistogram
                            {
                                FibreDiameterHistogramHeader = new FibreDiameterHistogramHeader
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
                                     CoreTestSamplingDate = new UtcDate{ Date="2017-01-10"},
                                     DateIssued = new UtcDate{ Date="2017-01-10"}
                                },
                                FibreDiameterHistogramDetailMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
                                        {
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 23,
                                                FibresMeasuredPercentage = 0.2345
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 24,
                                                FibresMeasuredPercentage = 0.2228
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 25,
                                                FibresMeasuredPercentage = 0.2543
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 27,
                                                FibresMeasuredPercentage = 0.3262
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

    public class GetTestCertificatesRequestExample : IExamplesProvider<List<RequestForData>>
    {
        public List<RequestForData> GetExamples()
        {
        return new List<RequestForData>
            {
                new RequestForData {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = new UtcDate{ Date="2020-07-15" },
                    DateTransmissionFileCreated = new UtcDate{ Date="2016-01-17" },
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
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.AWTA,
                        SoftwareVersion =  1082
                    },
                    Abn = 72001967184
                },
                RequestForDataType = new DateTimeRangeRequestForDataType {
                    StartDateTimeStatusRequest = new UtcDateTime{DateTime="2024-03-21T19:25:04Z"}
                }
                }
            };
        }
    }

    public class GetTestCertificates200Example : IExamplesProvider<ApiResult<List<TestCertificates>>>
    {
        public ApiResult<List<TestCertificates>> GetExamples()
        {
            return new ApiResult<List<TestCertificates>> ()
            {
                
                ApiMessages = [],
                Data = new List<TestCertificates>
                {   
                    new TestCertificates {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = new UtcDate{ Date="2020-07-15"},
                        DateTransmissionFileCreated = new UtcDate{ Date="2016-01-17" },
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                            OrganisationCode = "ATW",
                        },
                        CurrentReceiver = new Organisation
                        {
                            OrganisationCode = "ATW",
                        },
                        VersionNumber = 31,
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = SoftwareCompany.Talman,
                            SoftwareVersion =  1082
                        },
                        Abn = 72001967184
                    },
                    TestCertificateDetails = new List<TestCertificateDetail>
                    {
                    new TestCertificateDetail
                    {
                        TestDataHeader = new TestDataHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationCode = "ATW",
                            },
                            LotIdentityOrGroupNumber = "123456",
                            NumberOfBales = new NumberOfBales{BalesCount=1 },
                            Gross = new Weight { Value = 40.00, WeightCode = WeightCode.KG },
                            Tare = new Weight
                            {
                                Value =10.00,
                                WeightCode = WeightCode.KG
                            },
                            RegrabSampleWeight=new Weight { Value = 1.00, WeightCode = WeightCode.KG },
                            LotType = LotType.CombinedCertificate,
                            CentreAuction = new Centre{
                                CountryCode = CountryCode.AU,
                                CentreCode =  CentreCodeAustralia.A
                        },
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.R,
                            ScouredType = ScouredType.NotScoured,
                            IsGstApplicable = false,
                            IsCompanyAbnApplicable = false
                        },
                        TestDetail =
                            new TestDetail
                            {
                                CertificateIdentity =  new CertificateIdentity{
                                    CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                                    CertificateIdNumber = 23456787,
                                    CertificateIdSuffix = CertificateIdSuffix.D,
                                    CertificateIdCd = 7
                                },
                                TestDetailsType = TestDetailType.P,
                                Charge = new Currency { Value = 100.00, CurrencyCode = CurrencyCode.AUD },
                                Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                WoolBase = 20.00,
                                Vmb = 10.0,
                                HardHeadsBase =3.5,
                                            Yields = new List<Yield>
                                            {
                                                new Yield
                                                {
                                                    YieldValue = 74.40,
                                                    YieldType = YieldType.Reserved
                                                },
                                                new Yield
                                                {
                                                    YieldValue = 78.50,
                                                    YieldType = YieldType.IWTOScouredYieldAt16PercentsRegain
                                                },
                                                new Yield
                                                {
                                                    YieldValue = 75.70,
                                                    YieldType = YieldType.IWTOCleanWoolContentAt17PercentsRegain
                                                },
                                                new Yield
                                                {
                                                    YieldValue = 72.10,
                                                    YieldType = YieldType.Reserved
                                                },

                                            },
                                RetestFlag = RetestFlag.NormalTest,
                                ReissueChargeFlag = ReissueChargeFlag.OriginalCertificateCharge,
                                Vm1 = 20.0
                            },
                        FibreDiameterHistograms = new List<FibreDiameterHistogram>
                        {
                            new FibreDiameterHistogram
                            {
                                FibreDiameterHistogramHeader = new FibreDiameterHistogramHeader
                                {
                                     CoefficientOfVariation = 19.9,
                                     ComfortFactorPercentage = 98.7,
                                     FibresMeasured = 4000,
                                     ReportingFlag = ReportingFlag.U,
                                     Instrument = Instrument.LaserScan,
                                     SubSamplingMethod = SubSamplingMethod.Minicore,
                                     NumberOfSpecimens = 4,
                                     Mean = 20.1,
                                     StandardDeviation = 4.0,
                                     CurvatureMeanDegPerMm = 61,
                                     CoreTestSamplingDate = new UtcDate{ Date="2017-01-10"},
                                     DateIssued = new UtcDate{ Date="2017-01-10"}
                                },
                                FibreDiameterHistogramDetailMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
                                        {
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 23,
                                                FibresMeasuredPercentage = 0.2345
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 24,
                                                FibresMeasuredPercentage = 0.2228
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 25,
                                                FibresMeasuredPercentage = 0.2543
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 27,
                                                FibresMeasuredPercentage = 0.3262
                                            }
                                }
                            }
                        }

                    },
                    new TestCertificateDetail
                    {
                        TestDataHeader = new TestDataHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationCode = "ATW",
                            },
                            NumberOfBales = new NumberOfBales{BalesCount=1 },
                            Gross = new Weight { Value = 40.00, WeightCode = WeightCode.KG },
                            Tare = new Weight
                            {
                                Value =10.00,
                                WeightCode = WeightCode.KG
                            },
                            RegrabSampleWeight=new Weight { Value = 1.00, WeightCode = WeightCode.KG },
                            LotIdentityOrGroupNumber = "123456",
                            LotType = LotType.CombinedCertificate,
                            CentreAuction = new Centre{
                                CountryCode = CountryCode.AU,
                                CentreCode =  CentreCodeAustralia.A
                        },
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.C,
                            ScouredType = ScouredType.NotScoured,
                            IsGstApplicable = false,
                            IsCompanyAbnApplicable = false
                        },
                        LengthAndStrengthTestDetail =
                            new LengthAndStrengthTestDetail{
                            CertificateIdentity =  new CertificateIdentity{
                                    CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                                    CertificateIdNumber = 23456787,
                                    CertificateIdSuffix = CertificateIdSuffix.D,
                                    CertificateIdCd = 7
                             },
                            lengthAndStrengthTestDetailsType = LengthAndStrengthTestDetailType.K,
                            Laboratory = Laboratory.NZWoolTestingAuthority,
                            StapleLength = 13,
                            Charge = new Currency { Value = 156.34, CurrencyCode = CurrencyCode.AUD },
                            ReissueChargeFlag = ReissueChargeFlag.ReissuedWithAdditionalCharge,
                            StapleLengthCvPercentage = 25,
                            StapleStrength = 14,
                            StapleLengthMinimum = 13,
                            StapleLengthMaximum = 14,
                            StapleStrengthMinimum = 234,
                            StapleStrengthMaximum = 230,
                            PositionOfBreakPercentageTip = 26,
                            PositionOfBreakPercentageMiddle = 34,
                            PositionOfBreakPercentageBase = 27,
                            LsCertType = LsCertType.LengthAndStrengthTested,
                            IsLsSampleSecured = false,
                            DateIssued = new UtcDate{ Date="2024-01-22"}
                            },
                        SublotCertificateNumbers = new List<CertificateIdentity>
                        {
                            new CertificateIdentity{
                                    CertificateIdPrefix = CertificateIdPrefix.FremantleLaboratory,
                                    CertificateIdNumber = 23456787,
                                    CertificateIdSuffix = CertificateIdSuffix.D,
                                    CertificateIdCd = 7
                             }
                        },
                        FibreDiameterHistograms = new List<FibreDiameterHistogram> {
                            new FibreDiameterHistogram
                            {
                                FibreDiameterHistogramHeader = new FibreDiameterHistogramHeader
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
                                     CoreTestSamplingDate = new UtcDate{ Date="2017-01-10"},
                                     DateIssued = new UtcDate{ Date="2017-01-10"}
                                },
                                FibreDiameterHistogramDetailMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
                                        {
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 23,
                                                FibresMeasuredPercentage = 0.2345
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 24,
                                                FibresMeasuredPercentage = 0.2228
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 25,
                                                FibresMeasuredPercentage = 0.2543
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 27,
                                                FibresMeasuredPercentage = 0.3262
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
}
