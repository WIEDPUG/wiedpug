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
                            TransmissionType = Domain.Enums.TransmissionType.AuctionCatalogues,
                            VersionNumber = "36",
                            ABN = "00000000000"
                        },
                        RequestForDataCollection = new List<Domain.Entities.RequestForData>
                        {
                            new Domain.Entities.RequestForData
                            {
                                TransmissionTypeRequested = Domain.Enums.TransmissionType.AuctionCatalogues,
                                SaleIdentity = new Domain.Entities.SaleIdentity
                                {
                                    SellingCentreType = "F",
                                    SaleNumber = "18"                                    
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

    public class RequestForDataOrStatus200Example : IExamplesProvider<ApiResult>
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
    }

    public class RequestForDataOrStatus400Example : IExamplesProvider<CustomProblemDetails>
    {
        public CustomProblemDetails GetExamples()
        {
            return new CustomProblemDetails()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc9110#section-15.5.1",
                Title = "One or more validation errors occurred",
                Status = StatusCodes.Status400BadRequest,
                Detail = string.Empty,
                Errors = new Dictionary<string, string[]>
                {
                    { "Requests[0].TransmissionHeader.DateFormatLastRevised", ["The field DateFormatLastRevised is required", "The field DateFormatLastRevised must match regulart expression pattern..."] },
                    { "Requests[0].TransmissionHeader.CountryOfOrigin", ["The field CountryOfOrigin is required"] }
                }
            };
        }
    }

    public class RequestForDataOrStatus401Example : IExamplesProvider<CustomProblemDetails>
    {
        public CustomProblemDetails GetExamples()
        {
            return new CustomProblemDetails()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc9110#section-15.5.2",
                Title = "Unauthorized",
                Status = StatusCodes.Status401Unauthorized,
                Detail = "Missing authentication credentials",
                Errors = null
            };
        }
    }

    public class RequestForDataOrStatus403Example : IExamplesProvider<CustomProblemDetails>
    {
        public CustomProblemDetails GetExamples()
        {
            return new CustomProblemDetails()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc9110#section-15.5.4",
                Title = "You don't have permission to access this resource",
                Status = StatusCodes.Status403Forbidden,
                Detail = "You don't have a 'read' access to access this resource",
                Errors = null
            };
        }
    }

    public class RequestForDataOrStatus500Example : IExamplesProvider<CustomProblemDetails>
    {
        public CustomProblemDetails GetExamples()
        {
            return new CustomProblemDetails()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc9110#name-500-internal-server-error",
                Title = "An error occurred while processing your required",
                Status = StatusCodes.Status500InternalServerError,
                Detail = "Error details..",
                Errors = null
            };
        }
    }
}
