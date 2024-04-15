using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.TestCertificateAggregate;
namespace Wiedpug.API.Controllers;

public static class TestCertificatesEndpoints
{
    public static void MapTestCertificatesApiResultEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/test-certificates").WithTags("Test Certificates");

        group.MapPost("/",
        [SwaggerRequestExample(typeof(TestCertificates), typeof(TestCertificatesRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(TestCertificates200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(TestCertificates400Example))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(TestCertificates401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(TestCertificates403Example))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(TestCertificates500Example))]
        ([FromBody] TestCertificates model) =>
        {
            //return TypedResults.Created($"/api/ApiResults/{model.ID}", model);
        })
        .WithName("CreateTestCertificates")
        .WithOpenApi(o => new(o)
        {
            Summary = "Upload the test certificates"
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

        group.MapGet("/",
        [SwaggerRequestExample(typeof(TestCertificates), typeof(TestCertificatesRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(TestCertificates200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(TestCertificates400Example))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(TestCertificates401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(TestCertificates403Example))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(TestCertificates500Example))]
        ([FromBody] TestCertificates model) =>
        {
            //return TypedResults.Created($"/api/ApiResults/{model.ID}", model);
        })
        .WithName("GetTestCertificates")
        .WithOpenApi(o => new(o)
        {
            Summary = "Retrieves the requested test certificates"
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");
    }
}