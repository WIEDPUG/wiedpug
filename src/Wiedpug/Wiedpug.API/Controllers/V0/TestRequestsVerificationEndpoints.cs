using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.TestRequestsVerificationAggregate;
using Wiedpug.Domain.Aggregates.TextAggregate;
using Wiedpug.Domain.Entities;
namespace Wiedpug.API.Controllers.V0;

public static class TestRequestsVerificationEndpoints
{
    public static void MapTestRequestsVerificationEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("test-requests-verifications").WithTags("Test Requests Verifications");

        group.MapPost("/",
        [SwaggerRequestExample(typeof(List<TestRequestsVerification>), typeof(TestRequestsVerificationRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CommonResponse200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400SingleObjectRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] List<TestRequestsVerification> model) =>
            {
                //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
            })
            .WithName("CreateTestRequestsVerifications")
        .WithOpenApi(o => new(o)
        {
            Summary = "Test Request Verifications",
            Description = "Sent by an organisation that has already requested a test by paper to the Test House, as a verification of the paper request"
        })
        .Produces<List<ApiResult>>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<ApiErrorResult>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");


        group.MapPost("/data",
        [SwaggerRequestExample(typeof(List<RequestForData>), typeof(RequestForTestRequestsVerificationExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RequestForTestRequestsVerification200Example))]
        [SwaggerResponseExample(StatusCodes.Status204NoContent, typeof(CommonResponse204Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status404NotFound, typeof(CommonResponse404NotFoundExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] List<RequestForData> model) =>
        {
            //return TypedResults.Created($"/api/ApiResults/{model.ID}", model);
        })
        .WithName("RequestForTestRequestsVerification")
        .WithOpenApi(o => new(o)
        {
            Summary = "Retrieves the test requests verification"
        })
        .Produces<List<ApiResult<List<TestRequestsVerification>>>>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<ApiResult>(StatusCodes.Status204NoContent, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status404NotFound, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

    }
}
