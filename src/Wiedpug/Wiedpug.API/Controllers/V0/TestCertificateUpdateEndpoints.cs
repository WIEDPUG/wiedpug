using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.TestCertificateUpdateAggregate;
namespace Wiedpug.API.Controllers.V0;

public static class TestCertificateUpdateEndpoints
{
    public static void MapTestCertificateUpdateEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("test-certificate-update").WithTags("Test Certificate Update");

        group.MapPost("/",
        [SwaggerRequestExample(typeof(TestCertificateUpdate), typeof(TestCertificateUpdateRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CommonResponse200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400SingleObjectRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] TestCertificateUpdate model) =>
            {
                //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
            })        
        .WithOpenApi(o => new(o)
        {
            Summary = "Test Certificate Update",
            Description = "Sent to a test house to advise changes to an existing Certificate. A new Certificate will be reissued with the updated data."
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");
    }
}
