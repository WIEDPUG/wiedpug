using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.LotInvoicesAggregate;
using Wiedpug.Domain.Aggregates.TextAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class DarkAndMedullatedFibreRiskVerificationRequestExample : IExamplesProvider<DarkAndMedullatedFibreRiskVerification>
    {
        public DarkAndMedullatedFibreRiskVerification GetExamples()
        {
            return new DarkAndMedullatedFibreRiskVerification()
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
                DarkAndMedullatedFibreRiskDetailsCollection = new List<DarkAndMedullatedFibreRiskDetails>
                {
                    new DarkAndMedullatedFibreRiskDetails
                    {
                        DeclaredBreed = DeclaredBreed.A,
                        DeclaredWoolSubCategory=DeclaredWoolSubCategory.W,
                        DeclaredWoolCategory=DeclaredWoolCategory.P,
                        DeclaredQualifierCodes = new List<DeclaredQualifierCode>
                        {
                            DeclaredQualifierCode.A,
                            DeclaredQualifierCode.H,
                            DeclaredQualifierCode.D,
                            DeclaredQualifierCode.H,
                            DeclaredQualifierCode.S,
                            DeclaredQualifierCode.T,
                        },
                        DeclaredQualifierScale =DeclaredQualifierScale.LightOrOdd,
                        IsContactingWithExoticBreeds = true,
                        IsCrutched = true,
                        IsCrutchedWithin3MonthsOfShearing = false,
                        Sex = Sex.E,
                        AgeFrom = 12,
                        AgeTo = 23,
                        DarkAndMedullatedFibreRiskBroker = DarkAndMedullatedFibreRiskBroker.Risklevel1,
                        DarkandMedullatedFibreRisk = DarkAndMedullatedFibreRisk.D,
                        CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                                CertificateIDNumber = 499,
                                                CertificateIDSuffix = CertificateIDSuffix.P,
                                                CertificateIDCD = 7
                                            },
                        WoolBase = 32.14,
                        DMFRErrorFields = new List<string>
                        {
                            "12",
                            "18",
                            "9",
                            "2"
                        }
                    }
                    

                }
            };
        }

        public class RequestForDarkAndMedullatedFibreRiskVerificationExample : IExamplesProvider<RequestForData>
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
                    RequestForDataType = new UseNetworkDateTimeRequestForDataType { IsUsingNetworkDateTime
                    = true }
                };
            }
        }

        public class RequestForDarkAndMedullatedFibreRiskVerification200Example : IExamplesProvider<ApiResult>
        {
            public ApiResult GetExamples()
            {
                return new ApiResult()
                {
                    
                    Message = null,
                    Data =  new DarkAndMedullatedFibreRiskVerification()
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
                        DarkAndMedullatedFibreRiskDetailsCollection = new List<DarkAndMedullatedFibreRiskDetails>
                {
                    new DarkAndMedullatedFibreRiskDetails
                    {
                        DeclaredBreed = DeclaredBreed.A,
                        DeclaredWoolSubCategory=DeclaredWoolSubCategory.W,
                        DeclaredWoolCategory=DeclaredWoolCategory.P,
                        DeclaredQualifierCodes = new List<DeclaredQualifierCode>
                        {
                            DeclaredQualifierCode.A,
                            DeclaredQualifierCode.H,
                            DeclaredQualifierCode.D,
                            DeclaredQualifierCode.H,
                            DeclaredQualifierCode.S,
                            DeclaredQualifierCode.T,
                        },
                        DeclaredQualifierScale =DeclaredQualifierScale.LightOrOdd,
                        IsContactingWithExoticBreeds = true,
                        IsCrutched = true,
                        IsCrutchedWithin3MonthsOfShearing = false,
                        Sex = Sex.E,
                        AgeFrom = 12,
                        AgeTo = 23,
                        DarkAndMedullatedFibreRiskBroker = DarkAndMedullatedFibreRiskBroker.Risklevel1,
                        DarkandMedullatedFibreRisk = DarkAndMedullatedFibreRisk.D,
                        CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                                CertificateIDNumber = 499,
                                                CertificateIDSuffix = CertificateIDSuffix.P,
                                                CertificateIDCD = 7
                                            },
                        WoolBase = 32.14,
                        DMFRErrorFields = new List<string>
                        {
                            "12",
                            "18",
                            "9",
                            "2"
                        }
                    }


                }
                    }
                };
            }
        }


    }
}
