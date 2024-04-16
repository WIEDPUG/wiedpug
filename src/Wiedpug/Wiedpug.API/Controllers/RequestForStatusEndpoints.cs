using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.RequestForStatusAggregate;
using Wiedpug.Domain.Aggregates.StatusReplyAggregate;
namespace Wiedpug.API.Controllers;

public static class RequestForStatusEndpoints
{
    public static void MapRequestForStatusEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("status").WithTags("Request for Status");

        group.MapPost("/",
            [SwaggerRequestExample(typeof(RequestForStatus), typeof(RequestForStatusRequestExample))]
            [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RequestForStatusResponse200Example))]
            [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400SingleObjectRequestPayloadExample))]
            [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
            [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
            [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] RequestForStatus model) =>
            {
                //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
            })
        .WithName("RequestForStatus")
        .WithOpenApi(o => new(o)
        {
            Summary = "Used by brokers to request status"
        })
        .Produces<ApiResult<StatusReply>>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");
    }
}
