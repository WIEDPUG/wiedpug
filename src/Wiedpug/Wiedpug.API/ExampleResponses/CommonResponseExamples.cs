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
                IsSuccessful = true,
                Message = "Success message if applicable, otherwise can be set to Null",
                Data = "{Response Data depending on the document type's data structure e.g. Auction Catalogue Data}"
            };
        }
    }

    public class CommonResponse400ArrayRequestPayloadExample : IExamplesProvider<CustomProblemDetails>
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

    public class CommonResponse400SingleObjectRequestPayloadExample : IExamplesProvider<CustomProblemDetails>
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
                    { "TransmissionHeader.DateFormatLastRevised", ["The field DateFormatLastRevised is required", "The field DateFormatLastRevised must match regulart expression pattern..."] },
                    { "TransmissionHeader.CountryOfOrigin", ["The field CountryOfOrigin is required"] }
                }
            };
        }
    }

    public class CommonResponse401Example : IExamplesProvider<CustomProblemDetails>
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

    public class CommonResponse403NoReadPermissionExample : IExamplesProvider<CustomProblemDetails>
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

    public class CommonResponse403NoWritePermissionExample : IExamplesProvider<CustomProblemDetails>
    {
        public CustomProblemDetails GetExamples()
        {
            return new CustomProblemDetails()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc9110#section-15.5.4",
                Title = "You don't have permission to access this resource",
                Status = StatusCodes.Status403Forbidden,
                Detail = "You don't have a 'write' access to access this resource",
                Errors = null
            };
        }
    }

    public class CommonResponse500Example : IExamplesProvider<CustomProblemDetails>
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
