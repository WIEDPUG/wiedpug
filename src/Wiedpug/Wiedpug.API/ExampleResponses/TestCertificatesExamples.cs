using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.TestCertificateAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.Interface;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class CreateTestCertificatesRequestExample : IExamplesProvider<TestCertificates>
    {
        public TestCertificates GetExamples()
        {
            return new TestCertificates()
            {
                TransmissionHeader = new TransmissionHeader
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
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.Talman,
                        Version = 1082
                    },
                    Abn = "72001967184"
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
                            Bales = 1,
                            Gross =new Weight
                        {
                            Value =1.00,
                            Unit = WeightUnit.Kilograms
                        },
                            Tare = new Weight
                        {
                            Value =10.00,
                            Unit = WeightUnit.Kilograms
                        },
                            LotIdentityOrGroupNumber = "234234",
                            RegrabSampleWeight = new Weight
                            {
                                Value = 1.00,
                                Unit = WeightUnit.Kilograms
                            },
                            LotType = LotType.ObjectivelyMatchedInterlot,
                            CentreAuction = new Centre{
                                Country = CountryCode.AU,
                                CentreCode =  CentreCodeAustralia.A
                            },
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.R,
                            ScouredType = ScouredType.NotScoured,
                            IsGSTApplicable = false,
                            IsCompanyAbnApplicable = false
                        },
                            TestDetail =new TestDetail
                            {
                                CertificateIdentity =  new CertificateIdentity{
                                    CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                                    CertificateIDNumber = 23456787,
                                    CertificateIDSuffix = CertificateIDSuffix.D,
                                    CertificateIDCD = 7
                                },
                                TestDetailsType = TestDetailType.P,
                                Charge = new Currency { Value = 100.00, CurrencyUnit = CurrencyUnit.AUD },
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
                                     CoreTestSamplingDate = "2017-01-10",
                                     DateIssued = "2017-01-10"
                                },
                                FibreDiameterHistogramDetails = new List<FibreDiameterHistogramDetail>
                                {
                                    new FibreDiameterHistogramDetail
                                    {
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
                                            }
                                        }
                                    },
                                    new FibreDiameterHistogramDetail
                                    {
                                        FibreDiameterHistogramDetailMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
                                        {
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
                                    },
                                    new FibreDiameterHistogramDetail
                                    {
                                        FibreDiameterHistogramDetailMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
                                        {
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 21,
                                                FibresMeasuredPercentage = 0.1740
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 21,
                                                FibresMeasuredPercentage = 0.1955
                                            }
                                        }
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
                            Bales = 1,
                            Gross = new Weight { Value = 40.00, Unit = WeightUnit.Kilograms },
                            Tare = new Weight
                            {
                                Value =10.00,
                                Unit = WeightUnit.Kilograms
                            },
                            RegrabSampleWeight= new Weight
                            {
                                Value = 1.00,
                                Unit = WeightUnit.Kilograms
                            },
                            LotIdentityOrGroupNumber = "123456",
                            LotType = LotType.SubjectivelyMatchedInterlot,
                            CentreAuction = new Centre{
                                Country = CountryCode.AU,
                                CentreCode =  CentreCodeAustralia.A
                        },
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.U,
                            ScouredType = ScouredType.NotScoured,
                            IsGSTApplicable = false,
                            IsCompanyAbnApplicable = false
                        },
                        LengthAndStrengthTestDetail = 
                            new LengthAndStrengthTestDetail{
                                CertificateIdentity =  new CertificateIdentity{
                                        CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                                        CertificateIDNumber = 23456787,
                                        CertificateIDSuffix = CertificateIDSuffix.D,
                                        CertificateIDCD = 7
                                    },
                                lengthAndStrengthTestDetailsType = LengthAndStrengthTestDetailType.K,
                                Charge = new Currency { Value = 123.25, CurrencyUnit = CurrencyUnit.AUD },
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
                                DateIssued = "2024-01-22"
                            },
                        SublotCertificateNumbers = new List<CertificateIdentity>
                        {
                            new CertificateIdentity{
                                    CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                                    CertificateIDNumber = 23456787,
                                    CertificateIDSuffix = CertificateIDSuffix.D,
                                    CertificateIDCD = 7
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
                                     CoreTestSamplingDate = "2017-01-10",
                                     DateIssued = "2017-01-10"
                                },
                                FibreDiameterHistogramDetails = new List<FibreDiameterHistogramDetail>
                                {
                                    new FibreDiameterHistogramDetail
                                    {
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
                                            }
                                        }
                                    },
                                    new FibreDiameterHistogramDetail
                                    {
                                        FibreDiameterHistogramDetailMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
                                        {
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
                                    },
                                    new FibreDiameterHistogramDetail
                                    {
                                        FibreDiameterHistogramDetailMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
                                        {
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 21,
                                                FibresMeasuredPercentage = 0.1740
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 21,
                                                FibresMeasuredPercentage = 0.1955
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

    public class GetTestCertificatesRequestExample : IExamplesProvider<RequestForData>
    {
        public RequestForData GetExamples()
        {
            return new RequestForData()
            {
                TransmissionHeader = new TransmissionHeader
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
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.AWTA,
                        Version = 1082
                    },
                    Abn = "72001967184"
                },
                RequestForDataType = new DateTimeRangeRequestForDataType { 
                    StartDateTimeStatusRequest = "2024-03-21T19:25:04Z"
                }
            };
        }
    }

    public class GetTestCertificates200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                
                ApiMessages = [],
                Data = new TestCertificates 
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
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
                            Version = 1082
                        },
                        Abn = "72001967184"
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
                            Bales = 1,
                            Gross = new Weight { Value = 40.00, Unit = WeightUnit.Kilograms },
                            Tare = new Weight
                            {
                                Value =10.00,
                                Unit = WeightUnit.Kilograms
                            },
                            RegrabSampleWeight=new Weight { Value = 1.00, Unit = WeightUnit.Kilograms },
                            LotType = LotType.CombinedCertificate,
                            CentreAuction = new Centre{
                                Country = CountryCode.AU,
                                CentreCode =  CentreCodeAustralia.A
                        },
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.R,
                            ScouredType = ScouredType.NotScoured,
                            IsGSTApplicable = false,
                            IsCompanyAbnApplicable = false
                        },
                        TestDetail = 
                            new TestDetail
                            {
                                CertificateIdentity =  new CertificateIdentity{
                                    CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                                    CertificateIDNumber = 23456787,
                                    CertificateIDSuffix = CertificateIDSuffix.D,
                                    CertificateIDCD = 7
                                },
                                TestDetailsType = TestDetailType.P,
                                Charge = new Currency { Value = 100.00, CurrencyUnit = CurrencyUnit.AUD },
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
                                     CoreTestSamplingDate = "2017-01-10",
                                     DateIssued = "2017-01-10"
                                },
                                FibreDiameterHistogramDetails = new List<FibreDiameterHistogramDetail>
                                {
                                    new FibreDiameterHistogramDetail
                                    {
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
                                             }
                                        }
                                    },
                                    new FibreDiameterHistogramDetail
                                    {
                                        FibreDiameterHistogramDetailMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
                                        {
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
                                    },
                                    new FibreDiameterHistogramDetail
                                    {
                                        FibreDiameterHistogramDetailMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
                                        {
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 21,
                                                FibresMeasuredPercentage = 0.1740
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 21,
                                                FibresMeasuredPercentage = 0.1955
                                            }
                                        }
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
                            Bales = 1,
                            Gross = new Weight { Value = 40.00, Unit = WeightUnit.Kilograms },
                            Tare = new Weight
                            {
                                Value =10.00,
                                Unit = WeightUnit.Kilograms
                            },
                            RegrabSampleWeight=new Weight { Value = 1.00, Unit = WeightUnit.Kilograms },
                            LotIdentityOrGroupNumber = "123456",
                            LotType = LotType.CombinedCertificate,
                            CentreAuction = new Centre{
                                Country = CountryCode.AU,
                                CentreCode =  CentreCodeAustralia.A
                        },
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.C,
                            ScouredType = ScouredType.NotScoured,
                            IsGSTApplicable = false,
                            IsCompanyAbnApplicable = false
                        },
                        LengthAndStrengthTestDetail = 
                            new LengthAndStrengthTestDetail{
                            CertificateIdentity =  new CertificateIdentity{
                                    CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                                    CertificateIDNumber = 23456787,
                                    CertificateIDSuffix = CertificateIDSuffix.D,
                                    CertificateIDCD = 7
                             },
                            lengthAndStrengthTestDetailsType = LengthAndStrengthTestDetailType.K,
                            Laboratory = Laboratory.NZWoolTestingAuthority,
                            StapleLength = 13,
                            Charge = new Currency { Value = 156.34, CurrencyUnit = CurrencyUnit.AUD },
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
                            DateIssued = "2024-01-22"
                            },
                        SublotCertificateNumbers = new List<CertificateIdentity>
                        {
                            new CertificateIdentity{
                                    CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                                    CertificateIDNumber = 23456787,
                                    CertificateIDSuffix = CertificateIDSuffix.D,
                                    CertificateIDCD = 7
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
                                     CoreTestSamplingDate = "2017-01-10",
                                     DateIssued = "2017-01-10"
                                },
                                FibreDiameterHistogramDetails = new List<FibreDiameterHistogramDetail>
                                {
                                    new FibreDiameterHistogramDetail
                                    {
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
                                            }
                                        }
                                    },
                                    new FibreDiameterHistogramDetail
                                    {
                                        FibreDiameterHistogramDetailMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
                                        {
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
                                    },
                                    new FibreDiameterHistogramDetail
                                    {
                                        FibreDiameterHistogramDetailMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
                                        {
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 21,
                                                FibresMeasuredPercentage = 0.1740
                                            },
                                            new FibreDiameterHistogramDetailMeasurement
                                            {
                                                FibreDiameter = 21,
                                                FibresMeasuredPercentage = 0.1955
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
}
