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
                    DocumentOriginator = "ABCD",
                    CurrentTransmitter = "AWTM",
                    CurrentReceiver = "AWXLC",
                    FinalReceiver = "AWXLC",
                    TransmissionType = TransmissionType.TestCertificateRequests,
                    VersionNumber = "31",
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = "Talman",
                        Version = 10820
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
                            DeclaredGross = null,
                            DeclaredTare = null,
                            SampleWeightRemoved = null,
                            Bales = 96,
                            Season = 21,
                            SaleIdentity = null,
                            LotIdentity = null,
                            PrintFlag = null,
                            CombinationRequest = CombinationRequest.N,
                            AutoAdditionalMeasurementRequired = AutoAdditionalMeasurementRequired.N,
                            AdditionalPrintRequirements = AdditionalPrintRequirements.NoAdditionalRequirements,
                            TEAM3HauteurPrint = false,
                            CommitType = null,
                            CertificateRequestDetails = new List<CertificateRequestDetail>
                            {
                                new CertificateRequestDetail {
                                    CertificateIdentity = "315969534P9",
                                    Woolbase = 63.16,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = "315998357P0",
                                    Woolbase = 61.52,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = "316022762P9",
                                    Woolbase = 61.44,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                }
                            }
                        },
                        BaleHeader = null
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
                            DeclaredGross = null,
                            DeclaredTare = null,
                            SampleWeightRemoved = null,
                            Bales = 96,
                            Season = 21,
                            SaleIdentity = null,
                            LotIdentity = null,
                            PrintFlag = null,
                            CombinationRequest = CombinationRequest.C,
                            AutoAdditionalMeasurementRequired = AutoAdditionalMeasurementRequired.N,
                            AdditionalPrintRequirements = AdditionalPrintRequirements.VMBreakdownAndConfortFactor,
                            TEAM3HauteurPrint = true,
                            CommitType = null,
                            CertificateRequestDetails = new List<CertificateRequestDetail>
                            {
                                new CertificateRequestDetail {
                                    CertificateIdentity = "568369534L6",
                                    Woolbase = 53.74,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = "455818307B3",
                                    Woolbase = 52.01,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                },
                                new CertificateRequestDetail {
                                    CertificateIdentity = "226932560N1",
                                    Woolbase = 54.26,
                                    Laboratory = Laboratory.AustralianWoolTestingAuthority
                                }
                            }
                        },
                        BaleHeader = null
                    }


                }
            };
        }
    }
}
