﻿using Microsoft.AspNetCore.Mvc;
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
        var group = routes.MapGroup("test-resquests-verification").WithTags("Test Requests Verification");

        group.MapPost("/",
        [SwaggerRequestExample(typeof(TestRequestsVerification), typeof(TestRequestsVerificationRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CommonResponse200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400SingleObjectRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] TestRequestsVerification model) =>
            {
                //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
            })        
        .WithOpenApi(o => new(o)
        {
            Summary = "Test Request Verification",
            Description = "Sent by an organisation that has already requested a test by paper to the Test House, as a verification of the paper request"
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");


        group.MapPost("/data",
        [SwaggerRequestExample(typeof(RequestForData), typeof(RequestForTestRequestsVerificationExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RequestForTestRequestsVerification200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status404NotFound, typeof(CommonResponse404NotFoundExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] RequestForData model) =>
        {
            //return TypedResults.Created($"/api/ApiResults/{model.ID}", model);
        })
        .WithName("RequestForTestRequestsVerification")
        .WithOpenApi(o => new(o)
        {
            Summary = "Retrieves the test requests verification"
        })
        .Produces<ApiResult<TestRequestsVerification>>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status404NotFound, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

    }
}
