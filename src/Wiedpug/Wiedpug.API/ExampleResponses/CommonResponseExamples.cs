using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;

namespace Wiedpug.API.ExampleResponses
{
    public class CommonResponse200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                
                Message = null,
                Data = null
            };
        }
    }

    public class CommonNoDataResponse200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {
                
                Message = null,
                Data = null
            };
        }
    }

    public class CommonResponse400ArrayRequestPayloadExample : IExamplesProvider<ApiErrorResult>
    {
        public ApiErrorResult GetExamples()
        {
            return new ApiErrorResult()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc9110#section-15.5.1",
                Title = "One or more validation errors occurred",
                Status = StatusCodes.Status400BadRequest,
                Detail = string.Empty,
                Errors = new CustomErrors
                {
                    Errors = new Dictionary<string, string[]>
                    {
                        { "Requests[0].TransmissionHeader.DateFormatLastRevised", ["The field DateFormatLastRevised is required", "The field DateFormatLastRevised must match regulart expression pattern..."] },
                        { "Requests[0].TransmissionHeader.CountryOfOrigin", ["The field CountryOfOrigin is required"] }
                    }
                }
            };
        }
    }

    public class CommonResponse400SingleObjectRequestPayloadExample : IExamplesProvider<ApiErrorResult>
    {
        public ApiErrorResult GetExamples()
        {
            return new ApiErrorResult()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc9110#section-15.5.1",
                Title = "One or more validation errors occurred",
                Status = StatusCodes.Status400BadRequest,
                Detail = string.Empty,
                Errors = new CustomErrors
                {
                    Errors = new Dictionary<string, string[]>
                    {
                        { "Requests[0].TransmissionHeader.DateFormatLastRevised", ["The field DateFormatLastRevised is required", "The field DateFormatLastRevised must match regulart expression pattern..."] },
                        { "Requests[0].TransmissionHeader.CountryOfOrigin", ["The field CountryOfOrigin is required"] }
                    }
                }
            };
        }
    }

    public class CommonResponse401Example : IExamplesProvider<ApiErrorResult>
    {
        public ApiErrorResult GetExamples()
        {
            return new ApiErrorResult()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc9110#section-15.5.2",
                Title = "Unauthorized",
                Status = StatusCodes.Status401Unauthorized,
                Detail = "Missing authentication credentials",
                Errors = null
            };
        }
    }

    public class CommonResponse403NoReadPermissionExample : IExamplesProvider<ApiErrorResult>
    {
        public ApiErrorResult GetExamples()
        {
            return new ApiErrorResult()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc9110#section-15.5.4",
                Title = "You don't have permission to access this resource",
                Status = StatusCodes.Status403Forbidden,
                Detail = "You don't have a 'read' access to access this resource",
                Errors = null
            };
        }
    }

    public class CommonResponse403NoWritePermissionExample : IExamplesProvider<ApiErrorResult>
    {
        public ApiErrorResult GetExamples()
        {
            return new ApiErrorResult()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc9110#section-15.5.4",
                Title = "You don't have permission to access this resource",
                Status = StatusCodes.Status403Forbidden,
                Detail = "You don't have a 'write' access to access this resource",
                Errors = null
            };
        }
    }

    public class CommonResponse404NotFoundExample : IExamplesProvider<ApiErrorResult>
    {
        public ApiErrorResult GetExamples()
        {
            return new ApiErrorResult()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc9110#section-15.5.4",
                Title = "Resource not found",
                Status = StatusCodes.Status404NotFound,
                Detail = null,
                Errors = null
            };
        }
    }

    public class CommonResponse500Example : IExamplesProvider<ApiErrorResult>
    {
        public ApiErrorResult GetExamples()
        {
            return new ApiErrorResult()
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
