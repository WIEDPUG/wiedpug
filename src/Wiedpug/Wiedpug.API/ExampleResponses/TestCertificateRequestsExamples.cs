﻿using Microsoft.VisualBasic.FileIO;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates;
using Wiedpug.Domain.Aggregates.StatementsAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class TestCertificateRequestsRequestExample : IExamplesProvider<TestCertificateRequests>
    {
        public TestCertificateRequests GetExamples()
        {
            return new TestCertificateRequests()
            {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = "2020-07-15",
                    DateTransmissionFileCreated = "2016-01-17",
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
                        Version = 1082
                    },
                    Abn = "72001967184"
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
                            ClientsCrossReference = "XXY1255",
                            Bales = 96,
                            Season = 21,
                            CombinationRequest = CombinationRequest.N,
                            AutoAdditionalMeasurementRequired = AutoAdditionalMeasurementRequired.N,
                            AdditionalPrintRequirements = AdditionalPrintRequirements.NoAdditionalRequirements,
                            IsPrintingTEAM3Hauteur = false,
                            CertificateRequestDetails = new List<CertificateRequestDetail>
                            {
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity
                                    {
                                        CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                        CertificateIDNumber = 15969534,
                                        CertificateIDSuffix = CertificateIDSuffix.P,
                                        CertificateIDCD = 9
                                    },
                                    Woolbase = 63.16,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                            CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                                CertificateIDNumber = 499,
                                                CertificateIDSuffix = CertificateIDSuffix.P,
                                                CertificateIDCD = 7
                                            },
                                    Woolbase = 61.52,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                            CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                                CertificateIDNumber = 499,
                                                CertificateIDSuffix = CertificateIDSuffix.P,
                                                CertificateIDCD = 7
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
                            ClientsCrossReference = "XXZ1635",
                            Bales = 96,
                            Season = 21,
                            CombinationRequest = CombinationRequest.C,
                            AutoAdditionalMeasurementRequired = AutoAdditionalMeasurementRequired.N,
                            AdditionalPrintRequirements = AdditionalPrintRequirements.VMBreakdownAndConfortFactor,
                            IsPrintingTEAM3Hauteur = true,
                            CertificateRequestDetails = new List<CertificateRequestDetail>
                            {
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory, CertificateIDNumber = 499, CertificateIDSuffix = CertificateIDSuffix.P, CertificateIDCD = 7 },
                                    Woolbase = 53.74,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory, CertificateIDNumber = 499, CertificateIDSuffix = CertificateIDSuffix.P, CertificateIDCD = 7 },
                                    Woolbase = 52.01,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory, CertificateIDNumber = 499, CertificateIDSuffix = CertificateIDSuffix.P, CertificateIDCD = 7 },
                                    Woolbase = 54.26,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                }
                            }
                        }
                    }


                }
            };
        }
    }

    public class RequestForDataForTestCertificatesRequestsExample : IExamplesProvider<RequestForData>
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
                RequestForDataType = new DateTimeRangeRequestForDataType
                {
                    StartDateTimeStatusRequest = "2024-03-21T19:25:04Z"
                }
            };
        }
    }

    public class RequestForDataForTestCertificatesRequests200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                
                ApiMessages = [],
                Data = new TestCertificateRequests()
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
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
                            Version = 1082
                        },
                        Abn = "72001967184"
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
                            ClientsCrossReference = "XXY1255",
                            Bales = 96,
                            Season = 21,
                            CombinationRequest = CombinationRequest.N,
                            AutoAdditionalMeasurementRequired = AutoAdditionalMeasurementRequired.N,
                            AdditionalPrintRequirements = AdditionalPrintRequirements.NoAdditionalRequirements,
                            IsPrintingTEAM3Hauteur = false,
                            CertificateRequestDetails = new List<CertificateRequestDetail>
                            {
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity
                                    {
                                        CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                        CertificateIDNumber = 15969534,
                                        CertificateIDSuffix = CertificateIDSuffix.P,
                                        CertificateIDCD = 9
                                    },
                                    Woolbase = 63.16,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                            CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                                CertificateIDNumber = 499,
                                                CertificateIDSuffix = CertificateIDSuffix.P,
                                                CertificateIDCD = 7
                                            },
                                    Woolbase = 61.52,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                            CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                                CertificateIDNumber = 499,
                                                CertificateIDSuffix = CertificateIDSuffix.P,
                                                CertificateIDCD = 7
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
                            ClientsCrossReference = "XXZ1635",
                            Bales = 96,
                            Season = 21,
                            CombinationRequest = CombinationRequest.C,
                            AutoAdditionalMeasurementRequired = AutoAdditionalMeasurementRequired.N,
                            AdditionalPrintRequirements = AdditionalPrintRequirements.VMBreakdownAndConfortFactor,
                            IsPrintingTEAM3Hauteur = true,
                            CertificateRequestDetails = new List<CertificateRequestDetail>
                            {
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory, CertificateIDNumber = 499, CertificateIDSuffix = CertificateIDSuffix.P, CertificateIDCD = 7 },
                                    Woolbase = 53.74,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory, CertificateIDNumber = 499, CertificateIDSuffix = CertificateIDSuffix.P, CertificateIDCD = 7 },
                                    Woolbase = 52.01,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory, CertificateIDNumber = 499, CertificateIDSuffix = CertificateIDSuffix.P, CertificateIDCD = 7 },
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

}
