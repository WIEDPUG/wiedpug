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
                        OrganisationId = "ATWA"
                    },
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
                PrintPreSaleCertificatePostSales = new List<PrintPreSaleCertificatePostSale>
                {
                    new PrintPreSaleCertificatePostSale
                    {
                        CertificateIdentity = new CertificateIdentity
                        {
                            CertificateIDPrefix = CertificateIDPrefix.SydneyLaboratory,
                            CertificateIDNumber = "234567",
                            CertificateIDSuffix = CertificateIDSuffix.F,
                            CertificateIDCD = 6,
                        },
                        WeightNote = new WeightNote{
                            Prefix = "L",
                            Suffix = "1234567",
                        },
                        LotIdentity = "45567L",
                        BuyingOrganisation = new Organisation
                        {
                            OrganisationId="ATWM"
                        },
                        SaleOutcome = SaleOutcome.BidOrOfferPrice,
                        Bales = 23,
                        Gross = 2340,
                        SaleIdentity = new SaleIdentity
                        {
                            SellingCentreType = SellingCentreType.AU_AU,
                            SaleNumber = 23
                        },
                        CentreStorage = Centre.AU_AR,
                        CertificateDeliveryIndicator = CertificateDeliveryIndicator.ToBrokerOrBuyerAddress
                    }
                }

            };
        }
    }

    public class RequestForRequestPostsalePrintingOfPresaleCertificatesExample : IExamplesProvider<RequestForRequestPostsalePrintingOfPresaleCertificates>
    {
        public RequestForRequestPostsalePrintingOfPresaleCertificates GetExamples()
        {
            return new RequestForRequestPostsalePrintingOfPresaleCertificates()
            {
                SaleIdentity = new Domain.Entities.SaleIdentity
                {
                    SellingCentreType = SellingCentreType.AU_M,
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

    public class RequestForRequestPostsalePrintingOfPresaleCertificates200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = true,
                Message = null,
                Data = new RequestPostsalePrintingOfPresaleCertificates
                {
                    TransmissionHeader = new TransmissionHeader
                    {
                        DateFormatLastRevised = "2020-07-15",
                        DateTransmissionFileCreated = "2016-01-17",
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        CurrentReceiver = new Organisation
                        {
                            OrganisationId = "ATWA"
                        },
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
                    PrintPreSaleCertificatePostSales = new List<PrintPreSaleCertificatePostSale>
                {
                    new PrintPreSaleCertificatePostSale
                    {
                        CertificateIdentity = new CertificateIdentity
                        {
                            CertificateIDPrefix = CertificateIDPrefix.SydneyLaboratory,
                            CertificateIDNumber = "234567",
                            CertificateIDSuffix = CertificateIDSuffix.F,
                            CertificateIDCD = 6,
                        },
                        WeightNote = new WeightNote{
                            Prefix = "L",
                            Suffix = "1234567",
                        },
                        LotIdentity = "45567L",
                        BuyingOrganisation = new Organisation
                        {
                            OrganisationId="ATWM"
                        },
                        SaleOutcome = SaleOutcome.BidOrOfferPrice,
                        Bales = 23,
                        Gross = 2340,
                        SaleIdentity = new SaleIdentity
                        {
                            SellingCentreType = SellingCentreType.AU_AU,
                            SaleNumber = 23
                        },
                        CentreStorage = Centre.AU_AR,
                        CertificateDeliveryIndicator = CertificateDeliveryIndicator.ToBrokerOrBuyerAddress
                    }
                }

                }
            };
        }
    }
}
