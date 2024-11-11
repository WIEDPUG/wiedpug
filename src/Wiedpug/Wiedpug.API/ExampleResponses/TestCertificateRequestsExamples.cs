using Microsoft.VisualBasic.FileIO;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates;
using Wiedpug.Domain.Aggregates.StatementsAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class TestCertificateRequestsRequestExample : IExamplesProvider<List<TestCertificateRequests>>
    {
        public List<TestCertificateRequests> GetExamples()
        {
            return new List<TestCertificateRequests>()
            {
                new TestCertificateRequests() {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = new LiteralDate{ Date="2020-07-15"},
                    DateTransmissionFileCreated = new LiteralDate{ Date="2016-01-17" },
                    CountryOfOrigin = CountryCode.AU,
                    DocumentOriginator = new Organisation
                    {
                        OrganisationCode = "ATC",
                    },
                    CurrentReceiver = new Organisation
                    {
                        OrganisationCode = "ATT",
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
                TestCertificateRequestDetails = new List<TestCertificateRequestDetail>
                {
                    new TestCertificateRequestDetail
                    {
                        CertificateRequest = new CertificateRequest
                        {
                            CertificateType = CertificateType.C,
                            PrintRequirements = PrintRequirements.OriginalCertificateCharge,
                            YieldType1 = YieldType.Reserved_1,
                            YieldType2 = YieldType.SchlumbergerCombedDry1PercentTFM,
                            CertificateReference = "XXY1255",
                            ClientCrossReference = "XXY1255",
                           NumberOfBales = new NumberOfBales{BalesCount=96},
                            Season = new Season{SeasonValue= 21},
                            CombinationRequest = CombinationRequest.N,
                            AutoAdditionalMeasurementRequired = AutoAdditionalMeasurementRequired.N,
                            AdditionalPrintRequirements = AdditionalPrintRequirements.NoAdditionalRequirements,
                            IsPrintingTeam3Hauteur = false,
                            CertificateRequestDetails = new List<CertificateRequestDetail>
                            {
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity
                                    {
                                        CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory,
                                        CertificateIdNumber = 15969534,
                                        CertificateIdSuffix = CertificateIdSuffix.P,
                                        CertificateIdCd = 9
                                    },
                                    Woolbase = 63.16,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                            CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory,
                                                CertificateIdNumber = 499,
                                                CertificateIdSuffix = CertificateIdSuffix.P,
                                                CertificateIdCd = 7
                                            },
                                    Woolbase = 61.52,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                            CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory,
                                                CertificateIdNumber = 499,
                                                CertificateIdSuffix = CertificateIdSuffix.P,
                                                CertificateIdCd = 7
                                            },
                                    Woolbase = 61.44,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                }
                            }
                        }
                    },
                                        new TestCertificateRequestDetail
                    {
                        CertificateRequest = new CertificateRequest
                        {
                            CertificateType = CertificateType.B,
                            PrintRequirements = PrintRequirements.OriginalCertificateCharge,
                            YieldType1 = YieldType.Reserved,
                            YieldType2 = YieldType.UnitedStatesCustomClean,
                            CertificateReference = "XXY1205",
                            ClientCrossReference = "XXZ1635",
                           NumberOfBales = new NumberOfBales{BalesCount=96},
                            Season = new Season{SeasonValue= 21},
                            CombinationRequest = CombinationRequest.C,
                            AutoAdditionalMeasurementRequired = AutoAdditionalMeasurementRequired.N,
                            AdditionalPrintRequirements = AdditionalPrintRequirements.VMBreakdownAndConfortFactor,
                            IsPrintingTeam3Hauteur = true,
                            CertificateRequestDetails = new List<CertificateRequestDetail>
                            {
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory, CertificateIdNumber = 499, CertificateIdSuffix = CertificateIdSuffix.P, CertificateIdCd = 7 },
                                    Woolbase = 53.74,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory, CertificateIdNumber = 499, CertificateIdSuffix = CertificateIdSuffix.P, CertificateIdCd = 7 },
                                    Woolbase = 52.01,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory, CertificateIdNumber = 499, CertificateIdSuffix = CertificateIdSuffix.P, CertificateIdCd = 7 },
                                    Woolbase = 54.26,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                }
                            }
                        }
                    }


                }
                }
            };
        }
    }

    public class RequestForDataForTestCertificatesRequestsExample : IExamplesProvider<List<RequestForData>>
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
                    VersionNumber = 31,
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

    public class RequestForDataForTestCertificatesRequests200Example : IExamplesProvider<ApiResult<List<TestCertificateRequests>>>
    {
        public ApiResult<List<TestCertificateRequests>> GetExamples()
        {
            return new ApiResult<List<TestCertificateRequests>>()
            {
                
                ApiMessages = [],
                Data = new List<TestCertificateRequests>
                {
                    new TestCertificateRequests {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = new LiteralDate{ Date="2020-07-15"},
                        DateTransmissionFileCreated = new LiteralDate{ Date="2016-01-17" },
                        CountryOfOrigin = CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                            OrganisationCode = "ATC",
                        },
                        CurrentReceiver = new Organisation
                        {
                            OrganisationCode = "ATT",
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
                    TestCertificateRequestDetails = new List<TestCertificateRequestDetail>
                {
                    new TestCertificateRequestDetail
                    {
                        CertificateRequest = new CertificateRequest
                        {
                            CertificateType = CertificateType.F,
                            PrintRequirements = PrintRequirements.OriginalCertificateCharge,
                            YieldType1 = YieldType.Reserved_1,
                            YieldType2 = YieldType.SchlumbergerCombedDry1PercentTFM,
                            CertificateReference = "XXY1255",
                            ClientCrossReference = "XXY1255",
                            NumberOfBales = new NumberOfBales{BalesCount=96},
                            Season = new Season{SeasonValue= 21},
                            CombinationRequest = CombinationRequest.N,
                            AutoAdditionalMeasurementRequired = AutoAdditionalMeasurementRequired.N,
                            AdditionalPrintRequirements = AdditionalPrintRequirements.NoAdditionalRequirements,
                            IsPrintingTeam3Hauteur = false,
                            CertificateRequestDetails = new List<CertificateRequestDetail>
                            {
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity
                                    {
                                        CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory,
                                        CertificateIdNumber = 15969534,
                                        CertificateIdSuffix = CertificateIdSuffix.P,
                                        CertificateIdCd = 9
                                    },
                                    Woolbase = 63.16,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                            CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory,
                                                CertificateIdNumber = 499,
                                                CertificateIdSuffix = CertificateIdSuffix.P,
                                                CertificateIdCd = 7
                                            },
                                    Woolbase = 61.52,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                            CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory,
                                                CertificateIdNumber = 499,
                                                CertificateIdSuffix = CertificateIdSuffix.P,
                                                CertificateIdCd = 7
                                            },
                                    Woolbase = 61.44,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                }
                            }
                        }
                    },
                                        new TestCertificateRequestDetail
                    {
                        CertificateRequest = new CertificateRequest
                        {
                            CertificateType = CertificateType.C,
                            PrintRequirements = PrintRequirements.OriginalCertificateCharge,
                            YieldType1 = YieldType.Reserved,
                            YieldType2 = YieldType.UnitedStatesCustomClean,
                            CertificateReference = "XXY1205",
                            ClientCrossReference = "XXZ1635",
                            NumberOfBales = new NumberOfBales{BalesCount=96},
                            Season = new Season{SeasonValue= 21},
                            CombinationRequest = CombinationRequest.C,
                            AutoAdditionalMeasurementRequired = AutoAdditionalMeasurementRequired.N,
                            AdditionalPrintRequirements = AdditionalPrintRequirements.VMBreakdownAndConfortFactor,
                            IsPrintingTeam3Hauteur = true,
                            CertificateRequestDetails = new List<CertificateRequestDetail>
                            {
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory, CertificateIdNumber = 499, CertificateIdSuffix = CertificateIdSuffix.P, CertificateIdCd = 7 },
                                    Woolbase = 53.74,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory, CertificateIdNumber = 499, CertificateIdSuffix = CertificateIdSuffix.P, CertificateIdCd = 7 },
                                    Woolbase = 52.01,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory, CertificateIdNumber = 499, CertificateIdSuffix = CertificateIdSuffix.P, CertificateIdCd = 7 },
                                    Woolbase = 54.26,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
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
