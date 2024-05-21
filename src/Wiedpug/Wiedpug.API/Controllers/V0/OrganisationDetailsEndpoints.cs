using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.OrganisationDetailsAggregate;
using Wiedpug.Domain.Entities;
namespace Wiedpug.API.Controllers.V0;

public static class OrganisationDetailsEndpoints
{
    public static void MapOrganisationDetailsEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/organisation-details").WithTags("Organisation Details");

        group.MapPost("/",
        [SwaggerRequestExample(typeof(OrganisationDetails), typeof(OrganisationDetailsRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CreateOrganisationDetails200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] OrganisationDetails model) =>
        {
            //return TypedResults.Created($"/api/ApiResults/{model.ID}", model);
        })
        .WithName("CreateOrganisationDetails")
        .WithOpenApi(o => new(o)
        {
            Summary = "Create or upload the organisation details"
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status404NotFound, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

        group.MapPost("/data",
        [SwaggerRequestExample(typeof(GetOrganisationDetailsRequest), typeof(GetOrganisationDetailsRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(GetOrganisationDetails200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status404NotFound, typeof(CommonResponse404NotFoundExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] GetOrganisationDetailsRequest model) =>
        {
            //return TypedResults.Created($"/api/ApiResults/{model.ID}", model);
        })
        .WithName("GetOrganisationDetails")
        .WithOpenApi(o => new(o)
        {
            Summary = "Retrieves the organisationdetails"
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status404NotFound, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

        group.MapGet("/{id}",
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(OrganisationDetailExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status404NotFound, typeof(CommonResponse404NotFoundExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        (string id) =>
        {
            //return TypedResults.Created($"/api/ApiResults/{model.ID}", model);
        })
        .WithName("GetOrganisationDetailsById")
        .WithOpenApi(o => new(o)
        {
            Summary = "Retrieves the organisationdetail by id"
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status404NotFound, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

        group.MapPut("/{id}",
        [SwaggerRequestExample(typeof(OrganisationDetails), typeof(OrganisationDetailRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(OrganisationDetailExample))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status404NotFound, typeof(CommonResponse404NotFoundExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        (string id, [FromBody] OrganisationDetail model) =>
        {
            //return TypedResults.Created($"/api/ApiResults/{model.ID}", model);
        })
        .WithName("UpdateOrganisationDetailsById")
        .WithOpenApi(o => new(o)
        {
            Summary = "Update the organisation detail by id"
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status404NotFound, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

        group.MapDelete("/{id}",
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CommonNoDataResponse200Example))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status404NotFound, typeof(CommonResponse404NotFoundExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        (string id) =>
        {
            //return TypedResults.Created($"/api/ApiResults/{model.ID}", model);
        })
        .WithName("DeleteOrganisationDetailsById")
        .WithOpenApi(o => new(o)
        {
            Summary = "Delete or Deactivate organisation detail by id"
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status404NotFound, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");
    }
}