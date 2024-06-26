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
                    DateFormatLastRevised = "2020-07-15",
                    DateTransmissionFileCreated = "2016-01-17",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                        OrganisationId = "ABCD"
                    },
                    VersionNumber = 31,
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.Talman,
                        Version = 1082
                    },
                    ABN = "72001967184"
                },
                TestCertificateCollection = new List<TestCertificate>
                {
                    new TestCertificate {
                        TestDataHeader = new TestCertificateTestDataHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationId = "AWTA"
                            },
                            Bales = 1,
                            Gross = 1,
                            Tare = 1,
                            LotIdentityOrGroupName = new LotIdentityOrGroupName
                            {
                                LotIdentity = "234234"
                            },
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
                        OMLDetails = new TestCertificateOMLDetails
                            {
                                CertificateIdentity =  new CertificateIdentity{
                                    CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                                    CertificateIDNumber = "23456787",
                                    CertificateIDSuffix = CertificateIDSuffix.D,
                                    CertificateIDCD = 7
                                },
                                Charge = 100.00,
                                Laboratory = Laboratory.AustralianWoolTestingAuthority,
                                WoolBase = 20.00,
                                Vmb = 10.0,
                                HardHeadsBase =3.5,
                                Yield1 = 1.20,
                                YieldType1 = YieldType.Reserved,
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
                        TestDataHeader = new TestCertificateTestDataHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationId = "AWTA"
                            },
                            Bales = 1,
                            Gross = 1,
                            Tare = 1,
                            RegrabSampleWeight=1,
                            LotIdentityOrGroupName = new LotIdentityOrGroupName
                            {
                                LotIdentity = "123456"
                            },
                            WeightUnit = WeightUnit.Kilograms,
                            LotType = LotType.SubjectivelyMatchedInterlot,
                            CentreAuction = Centre.AU_A,
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.U,
                            ScouredType = ScouredType.NotScoured,
                            IsGSTApplicable = false,
                            IsCompanyABNApplicable = false
                        },
                        LengthAndStrengthCombDetails = new TestCertificateLengthAndStrengthCombDetails
                        {
                            CertificateIdentity =  new CertificateIdentity{
                                    CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                                    CertificateIDNumber = "23456787",
                                    CertificateIDSuffix = CertificateIDSuffix.D,
                                    CertificateIDCD = 7
                                },
                            Charge = 123.25,
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
                                    CertificateIDNumber = "23456787",
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
                SaleIdentity = new Domain.Entities.SaleIdentity
                {
                    SellingCentreType = SellingCentreType.AU_F,
                    SaleNumber = 18
                },
                OrganisationRequested = "AWNF",
                SaleDateRequested = "2023-10-31",
                UseNetworkDateTime = false,
                RequestType = Domain.Enums.RequestTypeForData.BroadcastDataRequest,
                WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                Season = 23
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
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                            OrganisationId = "AWTA"
                        },
                        VersionNumber = 31,
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = SoftwareCompany.Talman,
                            Version = 1082
                        },
                        ABN = "72001967184"
                    },
                    TestCertificateCollection = new List<TestCertificate>
                    {
                    new TestCertificate 
                    {
                        TestDataHeader = new TestCertificateTestDataHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationId = "AWTA"
                            },
                            LotIdentityOrGroupName = new LotIdentityOrGroupName
                            {
                                LotIdentity = "123456"
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
                        OMLDetails = new TestCertificateOMLDetails
                        {
                           CertificateIdentity =  new CertificateIdentity{
                                    CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                                    CertificateIDNumber = "23456787",
                                    CertificateIDSuffix = CertificateIDSuffix.D,
                                    CertificateIDCD = 7
                           },
                            Charge = 100.00,
                            Laboratory = Laboratory.AustralianWoolTestingAuthority,
                            WoolBase = 20.00,
                            Vmb = 10.0,
                            HardHeadsBase =3.5,
                            Yield1 = 1.20,
                            YieldType1 = YieldType.Reserved,
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
                        TestDataHeader = new TestCertificateTestDataHeader
                        {
                            Client = new Organisation
                            {
                                OrganisationId = "AWTA"
                            },
                            Bales = 1,
                            Gross = 1,
                            Tare = 1,
                            RegrabSampleWeight=1,
                            LotIdentityOrGroupName = new LotIdentityOrGroupName
                            {
                                LotIdentity = "123456"
                            },
                            WeightUnit = WeightUnit.Kilograms,
                            LotType = LotType.CombinedCertificate,
                            CentreAuction = Centre.AU_A,
                            SourceCode = SourceCode.Grower,
                            ReportingFlag = ReportingFlag.C,
                            ScouredType = ScouredType.NotScoured,
                            IsGSTApplicable = false,
                            IsCompanyABNApplicable = false
                        },
                        LengthAndStrengthCombDetails = new TestCertificateLengthAndStrengthCombDetails
                        {
                            CertificateIdentity =  new CertificateIdentity{
                                    CertificateIDPrefix = CertificateIDPrefix.FremantleLaboratory,
                                    CertificateIDNumber = "23456787",
                                    CertificateIDSuffix = CertificateIDSuffix.D,
                                    CertificateIDCD = 7
                             },
                            Laboratory = Laboratory.NZWoolTestingAuthority,
                            StapleLength = 13,
                            Charge = 156.34,
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
                                    CertificateIDNumber = "23456787",
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
