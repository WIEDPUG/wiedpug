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
                    DateFormatLastRevised = "2022-07-25",
                    DateTransmissionFileCreated = "2024-03-21",
                    CountryOfOrigin = Domain.Enums.CountryCode.AU,
                    DocumentOriginator = new Organisation { OrganisationId = "AWTX" },
                    VersionNumber = 36,
                    ABN = "72001967184"
                },
                Filters = new List<RequestForStatusFilter>
                {
                    new RequestForStatusFilter
                    {
                        TransmissionTypeRequested = Domain.Enums.TransmissionType.AuctionCatalogues,
                        SaleIdentity = new Domain.Entities.SaleIdentity
                        {
                            SellingCentreType = SellingCentreType.AU_F,
                            SaleNumber = 18
                        },
                        OrganisationRequested = "AWNF",
                        SaleDateRequested = "2023-10-31",
                        UseNetworkDateTime = false,
                        WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                        Season = 23
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
                IsSuccessful = true,
                Message = null,
                Data = new StatusReply
                {
                    TransmissionHeader = new Domain.Entities.TransmissionHeader
                    {
                        DateFormatLastRevised = "2022-07-25",
                        DateTransmissionFileCreated = "2024-03-21",
                        CountryOfOrigin = Domain.Enums.CountryCode.AU,
                        DocumentOriginator = new Organisation
                        {
                            OrganisationId = "AWTX"
                        },
                        VersionNumber = 36,
                        ABN = "72001967184"
                    },
                    Responses = new List<TransmissionResponse>
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
