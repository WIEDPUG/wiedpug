using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.PaymentAdviceAggregate;
using Wiedpug.Domain.Aggregates.PaymentAdviceDetailAggregate;
using Wiedpug.Domain.Aggregates.TestCertificateAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class CreatePaymentAdvicesRequestExample : IExamplesProvider<PaymentAdvices>
    {
        public PaymentAdvices GetExamples()
        {
            return new PaymentAdvices()
            {
                PaymentAdviceCollection = new List<PaymentAdvice>
                {
                    new PaymentAdvice
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
                    CurrentReceiver = new Organisation
                    {
                        OrganisationId = "ATWA"
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
                FinalreceiverList = new List<Organisation>
                {
                    new Organisation
                    {
                        OrganisationId = "ABEF"
                    },
                    new Organisation
                    {
                        OrganisationId = "ABFF"
                    },
                },
                PaymentAdviceDetailList = new List<PaymentAdviceDetail>
                {
                    new PaymentAdviceDetail
                    {
                            WoolSaleHeaderLots = new PaymentAdviceWoolSaleHeaderLots
                                {
                                    Season = 16,
                                    SaleIdentity = new Domain.Entities.SaleIdentity
                                    {
                                        SellingCentreType = SellingCentreType.AU_M,
                                        SaleNumber = 29
                                    },
                                    CentreStorage = Centre.AU_AR,
                                    SaleDate = "2017-01-19",
                                    WoolState = WoolState.A,
                                    PackType = PackType._2,
                                    InvoicingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },

                                    SellingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },

                                    CentreCatalogue = Centre.AU_G,
                                    StorageOrganisation = "ABCD",
                                    StorageDescription = "45 MAIN ST",
                                    DiscountRate = 1.50,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = "2017-01-24",
                                    StorageChargePerBalePerDay = 0.245,
                                    PenaltyInterestRate = 11.35,
                                },
                            LotPaymentDetails = new List<LotPaymentDetail>
                            {
                                new LotPaymentDetail
                                {
                                    LotIdentity = "123256",
                                    LotLastCost = 23.45

                                }
                            },
                            PaymentSummary = new PaymentSummary
                            {
                                LastCostPaid =67,
                                DiscountAmount=23,
                                NetAmountPaid=77,
                                DatePaymentMade="2024-05-24"
                            }

                    }
                },
                Comments = new List<Comment>
                {
                    new Comment
                    {
                        Text = "dfsfbsdfafsafs fdsa"
                    }
                }
                    }
                }
            };
        }
    }

    public class RequestForPaymentAdvicesRequestExample : IExamplesProvider<RequestForPaymentAdvice>
    {
        public RequestForPaymentAdvice GetExamples()
        {
            return new RequestForPaymentAdvice()
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

    public class RequestForPaymentAdvices200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = true,
                Message = null,
                Data = new PaymentAdvices
                {
                    PaymentAdviceCollection = new List<PaymentAdvice>
                    {
                        new PaymentAdvice
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
                        CurrentReceiver = new Organisation
                        {
                            OrganisationId = "MNCL"
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
                    PaymentAdviceDetailList = new List<PaymentAdviceDetail>
                {
                    new PaymentAdviceDetail
                    {
                                WoolSaleHeaderLots = new PaymentAdviceWoolSaleHeaderLots
                                {
                                    Season = 16,
                                    SaleIdentity = new Domain.Entities.SaleIdentity
                                    {
                                        SellingCentreType = SellingCentreType.AU_M,
                                        SaleNumber = 29
                                    },
                                    CentreStorage = Centre.AU_AR,
                                    SaleDate = "2017-01-19",
                                    WoolState = WoolState.A,
                                    PackType = PackType._2,
                                    InvoicingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },

                                    SellingOrganisation = new Organisation
                            {
                                OrganisationId = "ABCD"
                            },

                                    CentreCatalogue = Centre.AU_G,
                                    StorageOrganisation = "ABCD",
                                    StorageDescription = "45 MAIN ST",
                                    DiscountRate = 1.50,
                                    MaximumDaysDiscount = 0,
                                    DateStorageChargeCommences = "2017-01-24",
                                    StorageChargePerBalePerDay = 0.245,
                                    PenaltyInterestRate = 11.35,
                                },
                            LotPaymentDetails = new List<LotPaymentDetail>
                            {
                                new LotPaymentDetail
                                {
                                    LotIdentity = "123256",
                                    LotLastCost = 23.45

                                }
                            },
                            PaymentSummary = new PaymentSummary
                            {
                                LastCostPaid =67,
                                DiscountAmount=23,
                                NetAmountPaid=77,
                                DatePaymentMade="2024-05-24"
                            }

                    }
                },
                    Comments = new List<Comment>
                {
                    new Comment
                    {
                        Text = "dfsfbsdfafsafs fdsa"
                    }
                }
                        }
                    }

                }
            };
        }
    }
}
