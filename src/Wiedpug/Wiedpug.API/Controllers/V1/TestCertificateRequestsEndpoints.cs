using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates;
namespace Wiedpug.API.Controllers.V1;

public static class TestCertificateRequestsEndpoints
{
    public static void MapTestCertificateRequestsEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("test-certificate-requests").WithTags("Test Certificate Requests");

        group.MapPost("/",
        [SwaggerRequestExample(typeof(TestCertificateRequests), typeof(TestCertificateRequestsRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CommonResponse200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400SingleObjectRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] TestCertificateRequests model) =>
            {
                //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
            })        
        .WithOpenApi(o => new(o)
        {
            Summary = "Test Certificate Request",
            Description = "Sent to a Test House to initiate the printing of a certificate."
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");
    }
}
