using Microsoft.VisualBasic.FileIO;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.Domain.Aggregates;
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
                        OrganisationCode = "AWTX"
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
                TestCertificateRequestCollection = new List<TestCertificateRequest>
                {
                    new TestCertificateRequest
                    {
                        CertificateRequest = new CertificateRequest
                        {
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
                            TEAM3HauteurPrint = false,
                            CertificateRequestDetails = new List<CertificateRequestDetail>
                            {
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity
                                    {
                                        CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                        CertificateIDNumber = "15969534",
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
                                                CertificateIDNumber = "00000499",
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
                                                CertificateIDNumber = "00000499",
                                                CertificateIDSuffix = CertificateIDSuffix.P,
                                                CertificateIDCD = 7
                                            },
                                    Woolbase = 61.44,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                }
                            }
                        }
                    },
                                        new TestCertificateRequest
                    {
                        CertificateRequest = new CertificateRequest
                        {
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
                            TEAM3HauteurPrint = true,
                            CertificateRequestDetails = new List<CertificateRequestDetail>
                            {
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory, CertificateIDNumber = "00000499", CertificateIDSuffix = CertificateIDSuffix.P, CertificateIDCD = 7 },
                                    Woolbase = 53.74,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory, CertificateIDNumber = "00000499", CertificateIDSuffix = CertificateIDSuffix.P, CertificateIDCD = 7 },
                                    Woolbase = 52.01,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = new CertificateIdentity { CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory, CertificateIDNumber = "00000499", CertificateIDSuffix = CertificateIDSuffix.P, CertificateIDCD = 7 },
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
}
