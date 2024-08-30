using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.PaymentAdviceAggregate;
using Wiedpug.Domain.Aggregates.PaymentAdviceDetailAggregate;
using Wiedpug.Domain.Aggregates.TestCertificateAggregate;
using Wiedpug.Domain.Aggregates.TextAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class CreateRequestPostsalePrintingOfPresaleCertificatesExample : IExamplesProvider<RequestPostsalePrintingOfPresaleCertificates>
    {
        public RequestPostsalePrintingOfPresaleCertificates GetExamples()
        {
            return new RequestPostsalePrintingOfPresaleCertificates()
            {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = "2020-07-15",
                    DateTransmissionFileCreated = "2016-01-17",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    CurrentReceiver = new Organisation
                    {
                                                OrganisationCode = "ATW",

                    },
                    DocumentOriginator = new Organisation
                    {
                                                OrganisationCode = "ABC",

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
                PrintPreSaleCertificatePostSales = new List<PrintPreSaleCertificatePostSale>
                {
                    new PrintPreSaleCertificatePostSale
                    {
                        CertificateIdentity = new CertificateIdentity
                        {
                            CertificateIdPrefix = CertificateIdPrefix.SydneyLaboratory,
                            CertificateIdNumber = 234567,
                            CertificateIdSuffix = CertificateIdSuffix.F,
                            CertificateIdCd = 6,
                        },
                        WeightNote = new WeightNote{
                            Prefix = "L",
                            Suffix = 1234567,
                        },
                        LotIdentity = "45567L",
                        BuyingOrganisation = new Organisation
                        {
                            OrganisationCode = "AWT",

                        },
                        SaleOutcome = SaleOutcome.BidOrOfferPrice,
                        Bales = 23,
                        Gross = new Weight{ 
                            Value=2340.00,
                            Unit = WeightUnit.Kilograms
                        },
                        SaleIdentity = new SaleIdentity
                {
                    SellingCentreType = "M",
                    SaleNumber = 18
                },
                        CentreStorage = new Centre{
                                Country = CountryCode.AU,
                                CentreCode =  CentreCodeAustralia.A
                        },
                        CertificateDeliveryIndicator = CertificateDeliveryIndicator.ToBrokerOrBuyerAddress
                    }
                }

            };
        }
    }

    public class RequestForRequestPostsalePrintingOfPresaleCertificatesExample : IExamplesProvider<RequestForData>
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

    public class RequestForRequestPostsalePrintingOfPresaleCertificates200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                
                ApiMessages = [],
                Data = new RequestPostsalePrintingOfPresaleCertificates
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        CurrentReceiver = new Organisation
                        {
                                                    OrganisationCode = "ATW",

                        },
                        DocumentOriginator = new Organisation
                        {
                            OrganisationCode = "AWT",

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
                    PrintPreSaleCertificatePostSales = new List<PrintPreSaleCertificatePostSale>
                {
                    new PrintPreSaleCertificatePostSale
                    {
                        CertificateIdentity = new CertificateIdentity
                        {
                            CertificateIdPrefix = CertificateIdPrefix.SydneyLaboratory,
                            CertificateIdNumber = 234567,
                            CertificateIdSuffix = CertificateIdSuffix.F,
                            CertificateIdCd = 6,
                        },
                        WeightNote = new WeightNote{
                            Prefix = "L",
                            Suffix = 1234567,
                        },
                        LotIdentity = "45567L",
                        BuyingOrganisation = new Organisation
                        {
                            OrganisationCode = "AWT",
                        },
                        SaleOutcome = SaleOutcome.BidOrOfferPrice,
                        Bales = 23,
                        Gross = new Weight
                        {
                            Value =2340.00,
                            Unit = WeightUnit.Kilograms
                        },
                        SaleIdentity = new SaleIdentity
                {
                    SellingCentreType = "M",
                    SaleNumber = 18
                },
                        CentreStorage = new Centre{
                                Country = CountryCode.AU,
                                CentreCode =  CentreCodeAustralia.AR
                        },
                        CertificateDeliveryIndicator = CertificateDeliveryIndicator.ToBrokerOrBuyerAddress
                    }
                }

                }
            };
        }
    }
}
