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
    public class CreateLotPriceAndBuyersRequestExample : IExamplesProvider<List<LotPriceAndBuyer>>
    {
        public List<LotPriceAndBuyer> GetExamples()
        {
            return new List<LotPriceAndBuyer>
            {
                    new LotPriceAndBuyer
                    {
                        TransmissionHeader = new TransmissionHeader
                        {
                            DateFormatLastRevised = new UtcDate{ Date="2020-07-15"},
                            DateTransmissionFileCreated = new UtcDate{ Date="2016-01-17" },
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
                                SoftwareCompany = SoftwareCompany.Talman,
                                SoftwareVersion =  1082
                            },
                            Abn = 72001967184
                        },
                        Lots = new List<Lot>
                        {
                            new Lot
                            {
                                 WoolSaleHeaderLot = new WoolSaleHeaderLot
                                 {
                                     ReleasingOrganisation = new Organisation
                                     {
                                            OrganisationCode = "AWC",

                                     },
                                     WoolTypeGroup = WoolTypeGroup.MSKT,
                                     CentreStorage = new Centre {
                                        CountryCode = CountryCode.AU,
                                        CentreCode =  CentreCodeAustralia.A
                                     },
                                     SaleDate = new UtcDate{ Date="2017-01-10"},
                                     WoolState = WoolState._1,
                                     PackType = PackType._9,
                                     CatalogueSection = CatalogueSection.FLC,
                                     IsFinalCatalogue = true,
                                    Season = new Season{SeasonValue= 16},
                                    SaleIdentity = new SaleIdentity { SellingCentreType = "M", SaleNumber = 18 },
                                    InvoicingOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "ABC",

                                    },
                                    SellingOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "ABC",

                                    },
                                    CentreCatalogue = new Centre { CountryCode = CountryCode.AU, CentreCode = CentreCodeAustralia.A }
                                 },
                                 LotPriceAndBuyerDetails = new List<LotPriceAndBuyerDetail>
                                 {
                                     new LotPriceAndBuyerDetail
                                     {
                                         LotIdentity = new LotIdentity{Identity="123456" },
                                         CostPerWeightUnit = 110,
                                         BuyingOrganisation = new Organisation
                                         {
                                                                     OrganisationCode = "WWT",

                                         },
                                         SaleOutcome = SaleOutcome.Sold,
                                         AuctionSaleTime = new UtcDateTime{DateTime="2024-03-21T19:25:04Z"}
                                     },
                                     new LotPriceAndBuyerDetail
                                     {
                                         LotIdentity = new LotIdentity{Identity="123468" },
                                         CostPerWeightUnit = 150,
                                         BuyingOrganisation = new Organisation
                                         {
                                                                     OrganisationCode = "AAT",

                                         },
                                         SaleOutcome = SaleOutcome.Sold,
                                         AuctionSaleTime = new UtcDateTime{DateTime="2024-05-22T19:30:00Z"}
                                     }
                                 },
                                 RecordSaleStatus = new RecordSaleStatus
                                 {
                                     FileCreationDateTime = new UtcDateTime{DateTime="2024-05-22T20:30:00Z"},
                                     TotalLotsOffered = 2,
                                     PercentageSold = 100,
                                     AreTransfersCompleted = true
                                 }
                            }
                        }
 
                    }
            };
        }
    }

    public class RequestForLotPriceAndBuyersRequestExample : IExamplesProvider<List<WoolSaleRequestForData>>
    {
        public List<WoolSaleRequestForData> GetExamples()
        {
            return new List<WoolSaleRequestForData>()
            {
                new WoolSaleRequestForData {
                TransmissionHeader = new TransmissionHeader
                {
                    DateFormatLastRevised = new UtcDate{ Date="2020-07-15"},
                    DateTransmissionFileCreated = new UtcDate{ Date="2016-01-17" },
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
                        SoftwareVersion =  1082
                    },
                    Abn = 72001967184
                },
                WoolSaleRequestForDataType = new WoolSaleRequestForDataType
                {
                    SaleIdentity = new SaleIdentity
                    {
                        SellingCentreType = "M",
                        SaleNumber = 18
                    },
                    OrganisationRequested = new Organisation { OrganisationCode = "ANF", },
                    SaleDateRequested = new UtcDate{ Date="2023-10-31"},
                    WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                    Season = new Season{SeasonValue= 23}
                },
                RequestForDataType = new DateTimeRangeRequestForDataType
                {
                    StartDateTimeStatusRequest = new UtcDateTime{DateTime="2024-03-21T19:25:04Z"}
                }
                }
            };
        }
    }

    public class RequestForLotPriceAndBuyers200Example : IExamplesProvider<ApiResult<List<LotPriceAndBuyer>>>
    {
        public ApiResult<List<LotPriceAndBuyer>> GetExamples()
        {
            return new ApiResult<List<LotPriceAndBuyer>>()
            {
                
                ApiMessages = [],
                Data = new List<LotPriceAndBuyer>
                {
                    new LotPriceAndBuyer
                    {
                        TransmissionHeader = new TransmissionHeader
                        {
                            DateFormatLastRevised = new UtcDate{ Date="2020-07-15"},
                            DateTransmissionFileCreated = new UtcDate{ Date="2016-01-17" },
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
                                SoftwareCompany = SoftwareCompany.Talman,
                                SoftwareVersion =  1082
                            },
                            Abn = 72001967184
                        },
                                                Lots = new List<Lot>
                        {
                            new Lot
                            {
                                 WoolSaleHeaderLot = new WoolSaleHeaderLot
                                 {
                                     ReleasingOrganisation = new Organisation
                                     {
                                        OrganisationCode = "ATS",
                                     },
                                     WoolTypeGroup = WoolTypeGroup.MSKT,
                                     CentreStorage = new Centre { CountryCode = CountryCode.AU, CentreCode = CentreCodeAustralia.A },
                                     SaleDate = new UtcDate{ Date="2017-01-10"},
                                     WoolState = WoolState._1,
                                     PackType = PackType._9,
                                     CatalogueSection = CatalogueSection.FLC,
                                     IsFinalCatalogue = true,
                                    Season = new Season{SeasonValue= 16},
                                    SaleIdentity =  new SaleIdentity
                                    {
                                        SellingCentreType = "M",
                                        SaleNumber = 18
                                    },
                                    InvoicingOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "ABC",
                                    },
                                    SellingOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "ABC",
                                    },
                                    CentreCatalogue = new Centre { CountryCode = CountryCode.AU, CentreCode = CentreCodeAustralia.A }
                                 },
                                 LotPriceAndBuyerDetails = new List<LotPriceAndBuyerDetail>
                                 {
                                     new LotPriceAndBuyerDetail
                                     {
                                         LotIdentity = new LotIdentity{Identity="123456" },
                                         CostPerWeightUnit = 110,
                                         BuyingOrganisation = new Organisation
                                         {
                                                                     OrganisationCode = "WWT",
                                         },
                                         SaleOutcome = SaleOutcome.Sold,
                                         AuctionSaleTime = new UtcDateTime{DateTime="2024-05-22T19:25:04Z"}
                                     },
                                     new LotPriceAndBuyerDetail
                                     {
                                         LotIdentity = new LotIdentity{Identity="123468" },
                                         CostPerWeightUnit = 150,
                                         BuyingOrganisation = new Organisation
                                         {
                                                                     OrganisationCode = "AAT",
                                         },
                                         SaleOutcome = SaleOutcome.Sold,
                                         AuctionSaleTime = new UtcDateTime{DateTime="2024-05-22T19:30:00Z"}
                                     }
                                 },
                                 RecordSaleStatus = new RecordSaleStatus
                                 {
                                     FileCreationDateTime = new UtcDateTime{DateTime="2024-05-22T20:30:00Z"},
                                     TotalLotsOffered = 2,
                                     PercentageSold = 100,
                                     AreTransfersCompleted = true
                                 }
                            }
                        }
                    }
                }
            };
        }
    }
}
