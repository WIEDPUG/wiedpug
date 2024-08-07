﻿using Swashbuckle.AspNetCore.Filters;
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
                                SoftwareCompany = SoftwareCompany.Talman,
                                Version = 1082
                            },
                            ABN = "72001967184"
                        },
                        Lots = new List<Lot>
                        {
                            new Lot
                            {
                                 WoolSaleHeaderLots = new WoolSaleHeaderLots
                                 {
                                     ReleasingOrganisation = new Organisation
                                     {
                                            OrganisationCode = "AWC",

                                     },
                                     WoolTypeGroup = WoolTypeGroup.MSKT,
                                     CentreStorage = new Centre {
                                        Country = CountryCode.AU,
                                        CentreCode =  CentreCodeAustralia.A
                                     },
                                     SaleDate = "2017-01-19",
                                     WoolState = WoolState._1,
                                     PackType = PackType._9,
                                     CatalogueSection = CatalogueSection.FLC,
                                     IsFinalCatalogue = true,
                                    Season = 16,
                                    SaleIdentity = "M29",
                                    InvoicingOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "ABC",

                                    },
                                    SellingOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "ABC",

                                    },
                                    CentreCatalogue = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.A }
                                 },
                                 LotPriceAndBuyerDetails = new List<LotPriceAndBuyerDetail>
                                 {
                                     new LotPriceAndBuyerDetail
                                     {
                                         LotIdentity = "123456",
                                         CostPerWeightUnit = 110,
                                         BuyingOrganisation = new Organisation
                                         {
                                                                     OrganisationCode = "WWT",

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
                                                                     OrganisationCode = "AAT",

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
                                     AreTransfersCompleted = true
                                 }
                            }
                        }
 
                    }
            };
        }
    }

    public class RequestForLotPriceAndBuyersRequestExample : IExamplesProvider<RequestForDataRework>
    {
        public RequestForDataRework GetExamples()
        {
            return new RequestForDataRework()
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
                    ABN = "72001967184"
                },
                SaleIdentity = "M18",
                OrganisationRequested = new Organisation { OrganisationCode = "ANF", },
                SaleDateRequested = "2023-10-31",
                IsUsingNetworkDateTime = false,
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
                
                Message = null,
                Data = new List<LotPriceAndBuyer>
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
                                Version = 1082
                            },
                            ABN = "72001967184"
                        },
                                                Lots = new List<Lot>
                        {
                            new Lot
                            {
                                 WoolSaleHeaderLots = new WoolSaleHeaderLots
                                 {
                                     ReleasingOrganisation = new Organisation
                                     {
                                        OrganisationCode = "ATS",
                                     },
                                     WoolTypeGroup = WoolTypeGroup.MSKT,
                                     CentreStorage = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.A },
                                     SaleDate = "2017-01-19",
                                     WoolState = WoolState._1,
                                     PackType = PackType._9,
                                     CatalogueSection = CatalogueSection.FLC,
                                     IsFinalCatalogue = true,
                                    Season = 16,
                                    SaleIdentity = "M29",
                                    InvoicingOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "ABC",
                                    },
                                    SellingOrganisation = new Organisation
                                    {
                                                                OrganisationCode = "ABC",
                                    },
                                    CentreCatalogue = new Centre { Country = CountryCode.AU, CentreCode = CentreCodeAustralia.A }
                                 },
                                 LotPriceAndBuyerDetails = new List<LotPriceAndBuyerDetail>
                                 {
                                     new LotPriceAndBuyerDetail
                                     {
                                         LotIdentity = "123456",
                                         CostPerWeightUnit = 110,
                                         BuyingOrganisation = new Organisation
                                         {
                                                                     OrganisationCode = "WWT",
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
                                                                     OrganisationCode = "AAT",
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
