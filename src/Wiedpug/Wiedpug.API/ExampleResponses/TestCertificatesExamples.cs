using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.TestCertificateAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
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
                    DateFormatLastRevised = "200715",
                    DateTransmissionFileCreated = "160117",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = "ABCD",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXLC",
                    FinalReceiver = "AWXLC",
                    TransmissionType = TransmissionType.TestCertificate,
                    VersionNumber = "31",
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = "Talman",
                        Version = 10820
                    },
                    ABN = "72001967184"
                },
                TestCertificateCollection = new List<TestCertificate>
                {
                    new TestCertificate {
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
                            CentreAuction = Centre.AU_A,
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.R,
                            ScouredType = ScouredType.NotScoured,
                            IsGSTApplicable = false,
                            IsCompanyABNApplicable = false
                        },
                        OMLDetails = new OMLDetails
                            {
                                CertificateIdentity =  "SFSF",
                                Charge = 100.00,
                                Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                WoolBase = 200.00,
                                Vmb = 10.0,
                                HardHeadsBase =3.5,
                                Yield1 = 1.2,
                                YieldType1 = YieldType.Reserved,
                                RetestFlag = RetestFlag.NormalTest,
                                ReissueChargeFlag = ReissueChargeFlag.OriginalCertificateCharge,
                                Vm1 = 20.0

                        },
                        CombinationDetails = new CombinationDetails
                        {
                            CleanWeight1 = 10
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
                                     MeanMinimum = null,
                                     MeanMaximum = null,
                                     CoreTestSamplingDate = "170110",
                                     DateIssued = "170110",
                                     FactorLaserscanNumerator = null,
                                     FactorLaserscanDenominator = null
                                },
                                FibreDiameterHistogramDetails = new List<FibreDiameterHistogramDetail>
                                {
                                    new FibreDiameterHistogramDetail
                                    {
                                        FibreMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
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
                                        FibreMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
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
                                        FibreMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
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
                    new TestCertificate
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
                            LotType = LotType.SubjectivelyMatchedInterlot,
                            CentreAuction = Centre.AU_A,
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.U,
                            ScouredType = ScouredType.NotScoured,
                            IsGSTApplicable = false,
                            IsCompanyABNApplicable = false
                        },
                        LengthAndStrengthCombDetails = new LengthAndStrengthCombDetails
                        {
                            CertificateIdentity = "dsfafhdfa",
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
                        SublotCertificateNumbers = new List<string>
                        {
                            "fdsafsdaf",
                            "ygdfgdfdf"
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
                                     MeanMinimum = null,
                                     MeanMaximum = null,
                                     CoreTestSamplingDate = "170110",
                                     DateIssued = "170110",
                                     FactorLaserscanNumerator = null,
                                     FactorLaserscanDenominator = null
                                },
                                FibreDiameterHistogramDetails = new List<FibreDiameterHistogramDetail>
                                {
                                    new FibreDiameterHistogramDetail
                                    {
                                        FibreMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
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
                                        FibreMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
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
                                        FibreMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
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

    public class GetTestCertificatesRequestExample : IExamplesProvider<GetTestCertificatesRequest>
    {
        public GetTestCertificatesRequest GetExamples()
        {
            return new GetTestCertificatesRequest()
            {
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = "ABCD",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXLC",
                    FinalReceiver = "AWXLC",
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = "Talman",
                        Version = 10820
                    },
                    ABN = "72001967184"
            };
        }
    }

    public class GetTestCertificates200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = true,
                Message = null,
                Data = new TestCertificates 
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "200715",
                        DateTransmissionFileCreated = "160117",
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = "ABCD",
                        CurrentTransmitter = "AWTM",
                        CurrentReceiver = "AWXLC",
                        FinalReceiver = "AWXLC",
                        AccessPassword = "1111111111",
                        AccessPasswordReplacement = null,
                        TransmissionType = TransmissionType.TestCertificate,
                        VersionNumber = "31",
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = "Talman",
                            Version = 10820
                        },
                        ABN = "72001967184"
                    },
                    TestCertificateCollection = new List<TestCertificate>
                    {
                    new TestCertificate 
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
                            LotType = LotType.CombinedCertificate,
                            CentreAuction = Centre.AU_A,
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.R,
                            ScouredType = ScouredType.NotScoured,
                            IsGSTApplicable = false,
                            IsCompanyABNApplicable = false
                        },
                        OMLDetails = new OMLDetails
                        {
                            CertificateIdentity =  "SFSF",
                            Charge = 100.00,
                            Laboratory = Laboratory.AustralianWoolTestingAuthority,
                            WoolBase = 200.00,
                            Vmb = 10.0,
                            HardHeadsBase =3.5,
                            Yield1 = 1.2,
                            YieldType1 = YieldType.Reserved,
                            RetestFlag = RetestFlag.NormalTest,
                            ReissueChargeFlag = ReissueChargeFlag.OriginalCertificateCharge,
                            Vm1 = 20.0
                        },
                        CombinationDetails = new CombinationDetails
                        {
                            CleanWeight1 = 10
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
                                     MeanMinimum = null,
                                     MeanMaximum = null,
                                     CoreTestSamplingDate = "170110",
                                     DateIssued = "170110",
                                     FactorLaserscanNumerator = null,
                                     FactorLaserscanDenominator = null
                                },
                                FibreDiameterHistogramDetails = new List<FibreDiameterHistogramDetail>
                                {
                                    new FibreDiameterHistogramDetail
                                    {
                                        FibreMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
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
                                        FibreMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
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
                                        FibreMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
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
                    new TestCertificate
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
                            LotType = LotType.CombinedCertificate,
                            CentreAuction = Centre.AU_A,
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.C,
                            ScouredType = ScouredType.NotScoured,
                            IsGSTApplicable = false,
                            IsCompanyABNApplicable = false
                        },
                        LengthAndStrengthCombDetails = new LengthAndStrengthCombDetails
                        {
                            CertificateIdentity = "dsfafhdfa",
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
                            DateIssued = "240122"
                        },
                        SublotCertificateNumbers = new List<string>
                        {
                            "fdsafsdaf",
                            "ygdfgdfdf"
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
                                     MeanMinimum = null,
                                     MeanMaximum = null,
                                     CoreTestSamplingDate = "170110",
                                     DateIssued = "170110",
                                     FactorLaserscanNumerator = null,
                                     FactorLaserscanDenominator = null
                                },
                                FibreDiameterHistogramDetails = new List<FibreDiameterHistogramDetail>
                                {
                                    new FibreDiameterHistogramDetail
                                    {
                                        FibreMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
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
                                        FibreMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
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
                                        FibreMeasurements = new List<FibreDiameterHistogramDetailMeasurement>
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
