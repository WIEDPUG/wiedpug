using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.LotInvoicesAggregate;
using Wiedpug.Domain.Aggregates.TestRequestsVerificationAggregate;
namespace Wiedpug.API.Controllers.V0;

public static class DarkAndMedullatedFibreRiskVerificationEndpoints
{
    public static void MapDarkAndMedullatedFibreRiskVerificationEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("dark-and-medullated-fibre-risk-verification").WithTags("Dark And Medullated Fibre Risk Verification");

        group.MapPost("/",
        [SwaggerRequestExample(typeof(DarkAndMedullatedFibreRiskVerification), typeof(DarkAndMedullatedFibreRiskVerificationRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CommonResponse200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400SingleObjectRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] TestRequestsVerification model) =>
            {
               
            })        
        .WithOpenApi(o => new(o)
        {
            Summary = "Dark And Medullated Fibre Risk Verification",
            Description = "Sent by a broker organisation to AWTA to include the Dark and Medullated Fibre Risk (DMFR) on a Certificate that has been issued."
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");
    }
}
