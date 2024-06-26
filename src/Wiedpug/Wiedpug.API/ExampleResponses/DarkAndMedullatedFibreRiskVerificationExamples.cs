using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.Domain.Aggregates.LotInvoicesAggregate;
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
                        OrganisationId = "ABCD"
                    },
                    VersionNumber = 31,
                    SoftwareIdentifier = new SoftwareIdentifier
                    {
                        ProgramName = "NETR",
                        SoftwareCompany = SoftwareCompany.AWTA,
                        Version = 1082
                    },
                    ABN = "72001967184"
                },
                DarkAndMedullatedFibreRiskDetailsCollection = new List<DarkAndMedullatedFibreRiskDetails>
                {
                    new DarkAndMedullatedFibreRiskDetails
                    {
                        DeclaredBreed = DeclaredBreed.A,
                        DeclaredWoolSubCategory=DeclaredWoolSubCategory.W,
                        DeclaredWoolCategory=DeclaredWoolCategory.P,
                        DeclaredQualifierCode1=DeclaredQualifierCode.H,
                        DeclaredQualifierCode2 = DeclaredQualifierCode.D,
                        DeclaredQualifierCode3 = DeclaredQualifierCode.H,
                        DeclaredQualifierCode4 = DeclaredQualifierCode.S,
                        DeclaredQualifierCode5 = DeclaredQualifierCode.T,
                        DeclaredQualifierScale =DeclaredQualifierScale.LightOrOdd,
                        ContactWithExoticBreeds = true,
                        Crutched = true,
                        CrutchedWithin3MonthsOfShearing = false,
                        Sex = Sex.E,
                        AgeFrom = 12,
                        AgeTo = 23,
                        DarkAndMedullatedFibreRiskBroker = DarkAndMedullatedFibreRiskBroker.Risklevel1,
                        DarkandMedullatedFibreRisk = DarkAndMedullatedFibreRisk.D,
                        CertificateIdentity = new CertificateIdentity
                                            {
                                                CertificateIDPrefix = CertificateIDPrefix.MelbourneLaboratory,
                                                CertificateIDNumber = "00000499",
                                                CertificateIDSuffix = CertificateIDSuffix.P,
                                                CertificateIDCD = 7
                                            },
                        WoolBase = 32.14,
                        DMFRErrorField1 = 12,
                        DMFRErrorField2 = 18,
                        DMFRErrorField3 = 9,
                        DMFRErrorField4 = 2
                    }
                    

                }
            };
        }
    }
}
