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
    public class DarkAndMedullatedFibreRiskVerificationRequestExample : IExamplesProvider<List<DarkAndMedullatedFibreRiskVerification>>
    {
        public List<DarkAndMedullatedFibreRiskVerification> GetExamples()
        {
            return new List<DarkAndMedullatedFibreRiskVerification>()
            {
                new DarkAndMedullatedFibreRiskVerification() {
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
                    VersionNumber = "1.10.1",
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.AWTA,
                        SoftwareVersion =  1082
                    },
                    Abn = 72001967184
                },
                DarkAndMedullatedFibreRiskDetails = new List<DarkAndMedullatedFibreRiskDetail>
                {
                    new DarkAndMedullatedFibreRiskDetail
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
                        DarkAndMedullatedFibreRisk = DarkAndMedullatedFibreRisk.D,
                        CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory,
                                                CertificateIdNumber = 499,
                                                CertificateIdSuffix = CertificateIdSuffix.P,
                                                CertificateIdCd = 7
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

        public class RequestForDarkAndMedullatedFibreRiskVerificationExample : IExamplesProvider<List<RequestForData>>
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
                        VersionNumber = "1.10.1",
                        SoftwareIdentifier = new SoftwareIdentifier
                        {
                            ProgramName = "NETR",
                            SoftwareCompany = SoftwareCompany.AWTA,
                            SoftwareVersion =  1082
                        },
                        Abn = 72001967184
                    },
                    RequestForDataType = new UseNetworkDateTimeRequestForDataType { IsUsingNetworkDateTime
                    = true }
                    }
                };
            }
        }

        public class RequestForDarkAndMedullatedFibreRiskVerification200Example : IExamplesProvider<ApiResult<List<DarkAndMedullatedFibreRiskVerification>>>
        {
            public ApiResult<List<DarkAndMedullatedFibreRiskVerification>> GetExamples()
            {
                return new ApiResult<List<DarkAndMedullatedFibreRiskVerification>>()
                {
                    
                    ApiMessages = [],
                    Data =  new List<DarkAndMedullatedFibreRiskVerification>()
                    {
                        new DarkAndMedullatedFibreRiskVerification{
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
                            VersionNumber = "1.10.1",
                            SoftwareIdentifier = new SoftwareIdentifier
                            {
                                ProgramName = "NETR",
                                SoftwareCompany = SoftwareCompany.AWTA,
                                SoftwareVersion =  1082
                            },
                            Abn = 72001967184
                        },
                        DarkAndMedullatedFibreRiskDetails = new List<DarkAndMedullatedFibreRiskDetail>
                {
                    new DarkAndMedullatedFibreRiskDetail
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
                        DarkAndMedullatedFibreRisk = DarkAndMedullatedFibreRisk.D,
                        CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIdPrefix = CertificateIdPrefix.MelbourneLaboratory,
                                                CertificateIdNumber = 499,
                                                CertificateIdSuffix = CertificateIdSuffix.P,
                                                CertificateIdCd = 7
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
                    }
                };
            }
        }


    }
}
