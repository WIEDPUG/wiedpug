using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.LotPriceAndBuyerAggregate;
using Wiedpug.Domain.Aggregates.LotPriceAndBuyersAggregate;
using Wiedpug.Domain.Aggregates.PaymentAdviceAggregate;
using Wiedpug.Domain.Aggregates.PaymentAdviceDetailAggregate;
using Wiedpug.Domain.Aggregates.StatementsAggregate;
using Wiedpug.Domain.Aggregates.TestCertificateAggregate;
using Wiedpug.Domain.Aggregates.TextAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class CreateLotPriceAndBuyersRequestExample : IExamplesProvider<LotPriceAndBuyers>
    {
        public LotPriceAndBuyers GetExamples()
        {
            return new LotPriceAndBuyers()
            {
                LotPriceAndBuyerCollection = new List<LotPriceAndBuyer>
                {
                    new LotPriceAndBuyer
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
                                SoftwareCompany = SoftwareCompany.Talman,
                                Version = 1082
                            },
                            ABN = "72001967184"
                        },
                        Lots = new List<Lot>
                        {
                            new Lot
                            {
                                 WoolSaleHeaderLots = new LotPriceAndBuyerWoolSaleHeaderLots
                                 {
                                     ReleasingOrganisation = new Organisation
                                     {
                                         OrganisationId="WTTA"
                                     },
                                     WoolTypeGroup = WoolTypeGroup.MSKT,
                                     CentreStorage = Centre.AU_AD,
                                     SaleDate = "2017-01-19",
                                     WoolState = WoolState._1,
                                     PackType = PackType._9,
                                     Currency = "AUD",
                                     WeightUnit = WeightUnit.Kilograms,
                                     CatalogueSection = CatalogueSection.FLC,
                                     IsFinalCatalogue = true,
                                    Season = 16,
                                    SaleIdentity = new Domain.Entities.SaleIdentity
                                    {
                                        SellingCentreType = SellingCentreType.AU_M,
                                        SaleNumber = 29
                                    },
                                    InvoicingOrganisation = new Organisation
                                    {
                                        OrganisationId = "ABCD"
                                    },
                                    SellingOrganisation = new Organisation
                                    {
                                        OrganisationId = "ABCD"
                                    },
                                    CentreCatalogue = Centre.AU_G
                                 },
                                 LotPriceAndBuyerDetails = new List<LotPriceAndBuyerDetail>
                                 {
                                     new LotPriceAndBuyerDetail
                                     {
                                         LotIdentity = "123456",
                                         CostPerWeightUnit = 110,
                                         BuyingOrganisation = new Organisation
                                         {
                                             OrganisationId = "WWTA"
                                         },
                                         SaleOutcome = SaleOutcome.Sold,
                                         AuctionSaleTime = "2024-05-22T19:25:04Z"
                                     },
                                     new LotPriceAndBuyerDetail
                                     {
                                         LotIdentity = "123468",
                                         CostPerWeightUnit = 150,
                                         BuyingOrganisation = new Organisation
                                         {
                                             OrganisationId = "AATA"
                                         },
                                         SaleOutcome = SaleOutcome.Sold,
                                         AuctionSaleTime = "2024-05-22T19:30:00Z"
                                     }
                                 },
                                 RecordSaleStatus = new RecordSaleStatus
                                 {
                                     FileCreationDateTime = "2024-05-22T20:30:00Z",
                                     TotalLotsOffered = 2,
                                     PercentageSold = 100,
                                     IsTransferCompleted = true
                                 }
                            }
                        }
 
                    }
                }

            };
        }
    }

    public class RequestForLotPriceAndBuyersRequestExample : IExamplesProvider<RequestForLotPriceAndBuyers>
    {
        public RequestForLotPriceAndBuyers GetExamples()
        {
            return new RequestForLotPriceAndBuyers()
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

    public class RequestForLotPriceAndBuyers200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = true,
                Message = null,
                Data = new LotPriceAndBuyers
                {
                    LotPriceAndBuyerCollection = new List<LotPriceAndBuyer>
                {
                    new LotPriceAndBuyer
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
                                SoftwareCompany = SoftwareCompany.Talman,
                                Version = 1082
                            },
                            ABN = "72001967184"
                        },
                                                Lots = new List<Lot>
                        {
                            new Lot
                            {
                                 WoolSaleHeaderLots = new LotPriceAndBuyerWoolSaleHeaderLots
                                 {
                                     ReleasingOrganisation = new Organisation
                                     {
                                         OrganisationId="WTTA"
                                     },
                                     WoolTypeGroup = WoolTypeGroup.MSKT,
                                     CentreStorage = Centre.AU_AD,
                                     SaleDate = "2017-01-19",
                                     WoolState = WoolState._1,
                                     PackType = PackType._9,
                                     Currency = "AUD",
                                     WeightUnit = WeightUnit.Kilograms,
                                     CatalogueSection = CatalogueSection.FLC,
                                     IsFinalCatalogue = true,
                                    Season = 16,
                                    SaleIdentity = new Domain.Entities.SaleIdentity
                                    {
                                        SellingCentreType = SellingCentreType.AU_M,
                                        SaleNumber = 29
                                    },
                                    InvoicingOrganisation = new Organisation
                                    {
                                        OrganisationId = "ABCD"
                                    },
                                    SellingOrganisation = new Organisation
                                    {
                                        OrganisationId = "ABCD"
                                    },
                                    CentreCatalogue = Centre.AU_G
                                 },
                                 LotPriceAndBuyerDetails = new List<LotPriceAndBuyerDetail>
                                 {
                                     new LotPriceAndBuyerDetail
                                     {
                                         LotIdentity = "123456",
                                         CostPerWeightUnit = 110,
                                         BuyingOrganisation = new Organisation
                                         {
                                             OrganisationId = "WWTA"
                                         },
                                         SaleOutcome = SaleOutcome.Sold,
                                         AuctionSaleTime = "2024-05-22T19:25:04Z"
                                     },
                                     new LotPriceAndBuyerDetail
                                     {
                                         LotIdentity = "123468",
                                         CostPerWeightUnit = 150,
                                         BuyingOrganisation = new Organisation
                                         {
                                             OrganisationId = "AATA"
                                         },
                                         SaleOutcome = SaleOutcome.Sold,
                                         AuctionSaleTime = "2024-05-22T19:30:00Z"
                                     }
                                 },
                                 RecordSaleStatus = new RecordSaleStatus
                                 {
                                     FileCreationDateTime = "2024-05-22T20:30:00Z",
                                     TotalLotsOffered = 2,
                                     PercentageSold = 100,
                                     IsTransferCompleted = true
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
