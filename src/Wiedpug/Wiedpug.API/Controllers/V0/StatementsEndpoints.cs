﻿using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.StatementsAggregate;
using Wiedpug.Domain.Entities;
namespace Wiedpug.API.Controllers.V0;

public static class StatementsEndpoints
{
    public static void MapStatementsEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("statements").WithTags("Statements");

        group.MapPost("/",
        [SwaggerRequestExample(typeof(Statements), typeof(CreateStatementsRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CommonResponse200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400SingleObjectRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] Statements model) =>
            {
                //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
            })
        .WithName("CreateStatements")
        .WithOpenApi(o => new(o)
        {
            Summary = "Statements",
            Description = "Used to provide statements"
        })
        .Produces<List<ApiResult>>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<ApiErrorResult>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

        group.MapPost("/data",
        [SwaggerRequestExample(typeof(RequestForData), typeof(RequestForStatementsRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RequestForStatements200Example))]
        [SwaggerResponseExample(StatusCodes.Status204NoContent, typeof(CommonResponse204Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status404NotFound, typeof(CommonResponse404NotFoundExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] RequestForData model) =>
        {
            //return TypedResults.Created($"/api/ApiResults/{model.ID}", model);
        })
        .WithName("RequestForStatements")
        .WithOpenApi(o => new(o)
        {
            Summary = "Retrieves the statements"
        })
        .Produces<List<ApiResult<Statements>>>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<ApiResult>(StatusCodes.Status204NoContent, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status404NotFound, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");
    }
}
