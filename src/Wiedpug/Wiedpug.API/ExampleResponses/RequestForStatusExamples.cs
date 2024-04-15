using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.RequestForStatusAggregate;
using Wiedpug.Domain.Aggregates.StatusReplyAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;

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
                    DocumentOriginator = "AWTX",
                    CurrentTransmitter = "AWTX",
                    CurrentReceiver = "AWTM",
                    FinalReceiver = "AWTM",
                    AccessPassword = "1111111111",
                    TransmissionType = Domain.Enums.TransmissionType.AuctionCatalogues,
                    VersionNumber = 36,
                    Abn = "00000000000"
                },
                Filters = new List<RequestForStatusFilter>
                {
                    new RequestForStatusFilter
                    {
                        TransmissionTypeRequested = Domain.Enums.TransmissionType.AuctionCatalogues,
                        SaleIdentity = new Domain.Entities.SaleIdentity
                        {
                            SellingCentreType = "F",
                            SaleNumber = 18
                        },
                        OrganisationRequested = "AWNF",
                        SaleDateRequested = "2023-10-31",
                        UserNetworkDateTime = false,
                        WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                        RecordTypesToBeExcluded = new List<RecordTypesToBeExcludedForAuctionCatalogue>
                        {
                            RecordTypesToBeExcludedForAuctionCatalogue._79B,
                            RecordTypesToBeExcludedForAuctionCatalogue._32A,
                            RecordTypesToBeExcludedForAuctionCatalogue._84,
                        },
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
                        DocumentOriginator = "AWTX",
                        CurrentTransmitter = "AWTX",
                        CurrentReceiver = "AWTM",
                        FinalReceiver = "AWTM",
                        AccessPassword = "1111111111",
                        TransmissionType = Domain.Enums.TransmissionType.AuctionCatalogues,
                        VersionNumber = 36,
                        Abn = "00000000000"
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
