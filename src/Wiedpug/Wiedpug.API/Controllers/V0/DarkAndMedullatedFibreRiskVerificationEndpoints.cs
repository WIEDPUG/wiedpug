using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.LotInvoicesAggregate;
using Wiedpug.Domain.Aggregates.TestRequestsVerificationAggregate;
using Wiedpug.Domain.Aggregates.TextAggregate;
using Wiedpug.Domain.Entities;
using static Wiedpug.API.ExampleResponses.DarkAndMedullatedFibreRiskVerificationRequestExample;
namespace Wiedpug.API.Controllers.V0;

public static class DarkAndMedullatedFibreRiskVerificationEndpoints
{
    public static void MapDarkAndMedullatedFibreRiskVerificationEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("dark-and-medullated-fibre-risk-verifications").WithTags("Dark And Medullated Fibre Risk Verifications");

        group.MapPost("/",
        [SwaggerRequestExample(typeof(List<DarkAndMedullatedFibreRiskVerification>), typeof(DarkAndMedullatedFibreRiskVerificationRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CommonResponse200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400SingleObjectRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] List<DarkAndMedullatedFibreRiskVerification> model) =>
            {
               
            })
            .WithName("CreateDarkAndMedullatedFibreRiskVerifications")
        .WithOpenApi(o => new(o)
        {
            Summary = "Dark And Medullated Fibre Risk Verifications",
            Description = "Sent by a broker organisation to AWTA to include the Dark and Medullated Fibre Risk (DMFR) on a Certificate that has been issued."
        })
        .Produces<List<ApiResult>>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<ApiErrorResult>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");


        group.MapPost("/data",
        [SwaggerRequestExample(typeof(List<RequestForData>), typeof(RequestForDarkAndMedullatedFibreRiskVerificationExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RequestForDarkAndMedullatedFibreRiskVerification200Example))]
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
        .WithName("RequestForDarkAndMedullatedFibreRiskVerifications")
        .WithOpenApi(o => new(o)
        {
            Summary = "Retrieves the dark and medullated fibre risk verifications"
        })
        .Produces<List<ApiResult<List<DarkAndMedullatedFibreRiskVerification>>>>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<ApiResult>(StatusCodes.Status204NoContent, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status404NotFound, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");


    }
}
