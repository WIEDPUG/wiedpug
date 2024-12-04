using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.RequestForStatusAggregate;
using Wiedpug.Domain.Aggregates.StatusReplyAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class RequestForStatusRequestExample : IExamplesProvider<RequestForStatus>
    {
        public RequestForStatus GetExamples()
        {
            return new RequestForStatus
            {
                TransmissionHeader = new Domain.Entities.TransmissionHeader
                {
                    DateFormatLastRevised = new LiteralDate{ Date="2022-07-25"},
                    DateTransmissionFileCreated = new LiteralDate{ Date="2024-03-21"},
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = new Organisation { 
                                                OrganisationCode = "AWX", },
                    CurrentReceiver = new Organisation
                    {
                                                OrganisationCode = "ATW",
                    },
                    VersionNumber = "1.10.1",
                    Abn = 72001967184
                },
                RequestForStatusFilters = new List<RequestForStatusFilter>
                {
                    new RequestForStatusFilter
                    {
                        TransmissionTypeRequested = Domain.Enums.TransmissionType.AuctionCatalogues,
                        SaleIdentity = new SaleIdentity
                        {
                            SellingCentreType = "M",
                            SaleNumber = 18
                        },
                        OrganisationRequested = "AWNF",
                        SaleDateRequested = new LiteralDate{ Date="2023-10-31"},
                        IsUsingNetworkDateTime = false,
                        WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                        Season = new Season{SeasonValue= 23}
                    }
                }
            };
        }
    }

    public class RequestForStatusResponse200Example : IExamplesProvider<ApiResult<StatusReply>>
    {
        public ApiResult<StatusReply> GetExamples()
        {
            return new ApiResult<StatusReply>()
            {
                
                ApiMessages = [],
                Data = new StatusReply
                {
                    TransmissionHeader = new Domain.Entities.TransmissionHeader
                    {
                        DateFormatLastRevised = new LiteralDate{ Date="2022-07-25"},
                        DateTransmissionFileCreated = new LiteralDate{ Date="2024-03-21"},
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        CurrentReceiver = new Organisation
                        {
                                                    OrganisationCode = "ATW",
                        },
                        DocumentOriginator = new Organisation
                        {
                                                    OrganisationCode = "AWX",
                        },
                        VersionNumber = "1.10.1",
                        Abn = 72001967184
                    },
                    TransmissionResponses = new List<TransmissionResponse>
                    {
                        new TransmissionResponse
                        {
                            Text = "08/04/92 11:32 DALS S01/91 07/04/92 888"
                        }
                    }
                }
            };
        }
    }
}
