using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates;
using Wiedpug.Domain.Aggregates.OrganisationDetailsAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
using Wiedpug.Domain.ValueObject;

namespace Wiedpug.API.ExampleResponses
{
    public class KeysRequestExample : IExamplesProvider<KeyDataRequest>
    {
        public KeyDataRequest GetExamples()
        {
            return new KeyDataRequest
            {
                EncryptionKey = "\'{\"alg\": \"RS256\",\"kty\": \"RSA\",\"use\": \"enc\",\"x5c\": [\"MIIC+DCCAeCgAwIBAgIJBIGjYW6hFpn2MA…2sc2mlq1i3IashGkkgmo=\"],\"n\": \"yeNlzlub94YgerT030codqEztjfU…W3HoBdjQ\",\"e\": \"AQAB\",\"kid\": \"NjVBRjY5MDlCMUIwNzU4RTA2QzZFMDQ4QzQ2MDAyQjVDNjk1RTM2Qg\",\"x5t\": \"NjVBRjY5MDlCMUIwNzU4RTA2QzZFMDQ4QzQ2MDAyQjVDNjk1RTM2Qg\"}\'",
                Organisation = new Organisation { OrganisationCode = "AWE" }
            };
        }
    }

    public class KeyExample : IExamplesProvider<String>
    {
        public String GetExamples()
        {
            return "\'{\"alg\": \"RS256\",\"kty\": \"RSA\",\"use\": \"enc\",\"x5c\": [\"MIIC+DCCAeCgAwIBAgIJBIGjYW6hFpn2MA…2sc2mlq1i3IashGkkgmo=\"],\"n\": \"yeNlzlub94YgerT030codqEztjfU…W3HoBdjQ\",\"e\": \"AQAB\",\"kid\": \"NjVBRjY5MDlCMUIwNzU4RTA2QzZFMDQ4QzQ2MDAyQjVDNjk1RTM2Qg\",\"x5t\": \"NjVBRjY5MDlCMUIwNzU4RTA2QzZFMDQ4QzQ2MDAyQjVDNjk1RTM2Qg\"}\'";
        }
    }

    public class RequestForKeyRequestExample : IExamplesProvider<Organisation>
    {
        public Organisation GetExamples()
        {
            return new Organisation
            {
                OrganisationCode = "AWE",
            };
        }
    }

    public class Keys200Example : IExamplesProvider<ApiResult<String>>
    {
        public ApiResult<String> GetExamples()
        {
            return new ApiResult<String>()
            {
                
                ApiMessages = [],
                Data = "\'{\"alg\": \"RS256\",\"kty\": \"RSA\",\"use\": \"enc\",\"x5c\": [\"MIIC+DCCAeCgAwIBAgIJBIGjYW6hFpn2MA…2sc2mlq1i3IashGkkgmo=\"],\"n\": \"yeNlzlub94YgerT030codqEztjfU…W3HoBdjQ\",\"e\": \"AQAB\",\"kid\": \"NjVBRjY5MDlCMUIwNzU4RTA2QzZFMDQ4QzQ2MDAyQjVDNjk1RTM2Qg\",\"x5t\": \"NjVBRjY5MDlCMUIwNzU4RTA2QzZFMDQ4QzQ2MDAyQjVDNjk1RTM2Qg\"}\'"
        };
        }
    }

    public class CreateKeys200Example : IExamplesProvider<ApiResult>
    {
        public ApiResult GetExamples()
        {
            return new ApiResult()
            {

                ApiMessages = [],
                Data = "d3c4a0fa-1d2f-4e9e-b45b-007faa22f2a5"
            };
        }
    }

    public class RequestForKeyResponse400Example : IExamplesProvider<ApiErrorResult>
    {
        public ApiErrorResult GetExamples()
        {
            return new ApiErrorResult()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc9110#section-15.5.1",
                Title = "One or more validation errors occurred",
                Status = StatusCodes.Status400BadRequest,
                Detail = string.Empty,
                Errors = new List<CustomError>
                {
                    new CustomError {
                        Errors = new Dictionary<string, string[]>
                        {
                            { "RequestBbody", ["The request body for organisation is required."] },
                        }
                    }
                }
            };
        }
    }


    public class KeysResponse400ArrayRequestPayloadExample : IExamplesProvider<ApiErrorResult>
    {
        public ApiErrorResult GetExamples()
        {
            return new ApiErrorResult()
            {
                Type = "https://datatracker.ietf.org/doc/html/rfc9110#section-15.5.1",
                Title = "One or more validation errors occurred",
                Status = StatusCodes.Status400BadRequest,
                Detail = string.Empty,
                Errors = new List<CustomError>
                {   new CustomError
                    {
                        Errors = new Dictionary<string, string[]>
                        {
                            { "RequestBbody", ["The request body for public encrption key is required."] },
                        }
                    }
                }
            };
        }
    }

}


