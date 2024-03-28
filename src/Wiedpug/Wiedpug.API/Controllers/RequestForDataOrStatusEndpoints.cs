using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.AggregatesModel.RequestForDataOrStatusAggregate;
namespace Wiedpug.API.Controllers;

public static class RequestForDataOrStatusEndpoints
{
    public static void MapApiResultEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/request-for-details-or-status").WithTags("Request for Data/Status");
        group.MapPost("/",
            [SwaggerRequestExample(typeof(RequestForDataOrStatus), typeof(RequestForDataRequestExample))]
            [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RequestForDataOrStatus200Example))]
            [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(RequestForDataOrStatus400Example))]
            [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(RequestForDataOrStatus401Example))]
            [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(RequestForDataOrStatus403Example))]
            [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(RequestForDataOrStatus500Example))]
        ([FromBody] RequestForDataOrStatus model) =>
        {            
            //return TypedResults.Created($"/api/ApiResults/{model.ID}", model);
        })        
        .WithOpenApi(o => new(o) {
            Summary = "Retrieves the requested details or status"
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");
        
    }
}
