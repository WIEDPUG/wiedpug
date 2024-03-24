using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.AggregatesModel.RequestForDataOrStatusAggregate;

namespace Wiedpug.API.ExampleResponses
{
    public class RequestForDataRequestExample : IExamplesProvider<RequestForDataOrStatus>
    {
        public RequestForDataOrStatus GetExamples()
        {
            return new RequestForDataOrStatus()
            {
                Requests = new List<RequestForDataGroup>
                {
                    new RequestForDataGroup
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
                        RequestForDataCollection = new List<Domain.Entities.RequestForData>
                        {
                            new Domain.Entities.RequestForData
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
                                RequestType = Domain.Enums.RequestType.BroadcastDataRequest,
                                WoolTypeGroup = Domain.Enums.WoolTypeGroup.MFLC,
                                RecordTypesToBeExcluded = new List<string>
                                {
                                    "79B","32A","84"
                                },
                                Season = 23
                            }
                        }
                    }
                }
            };
        }
    }

    public class RequestForDataOrStatus200Example : IMultipleExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = true,
                Message = "Success message if applicable, otherwise can be set to Null",
                Data = "{Response Data depending on the document type's data structure e.g. Auction Catalogue Data}"
            };
        }

        IEnumerable<SwaggerExample<ApiResult>> IMultipleExamplesProvider<ApiResult>.GetExamples()
        {
            yield return SwaggerExample.Create(
                "Example 1",
                new ApiResult
                {
                    IsSuccessful = true,
                    Message = string.Empty,
                    Data = "{Auction Catalogue Data}"
                });

            yield return SwaggerExample.Create(
                "Example 2",
                new ApiResult
                {
                    IsSuccessful = true,
                    Message = string.Empty,
                    Data = "{Private Catalogue Data to be generated}"
                });
        }
    }

    public class RequestForDataOrStatus400Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                IsSuccessful = false,
                Message = "Validation error message",
                Data = null
            };
        }
    }
}
