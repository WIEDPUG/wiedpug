using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.TextAggregate;
using Wiedpug.Domain.Entities;
namespace Wiedpug.API.Controllers.V0;

public static class RequestPostsalePrintingOfPresaleCertificatesEndpoints
{
    public static void MapRequestPostsalePrintingOfPresaleCertificatesEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("postsale-printing-of-presale-certificates").WithTags("Request Postsale Printing Of Presale Certificates");

        group.MapPost("/",
        [SwaggerRequestExample(typeof(RequestPostsalePrintingOfPresaleCertificates), typeof(CreatePaymentConfirmationRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CommonResponse200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400SingleObjectRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] RequestPostsalePrintingOfPresaleCertificates model) =>
            {
                //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
            })
        .WithName("CreateRequestPostsalePrintingOfPresaleCertificates")
        .WithOpenApi(o => new(o)
        {
            Summary = "Request Postsale Printing Of Presale Certificates",
            Description = "Used to provide request postsale printing of presale certificates"
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

        group.MapPost("/data",
        [SwaggerRequestExample(typeof(RequestForRequestPostsalePrintingOfPresaleCertificates), typeof(RequestForRequestPostsalePrintingOfPresaleCertificatesExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RequestForRequestPostsalePrintingOfPresaleCertificates200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status404NotFound, typeof(CommonResponse404NotFoundExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] RequestForRequestPostsalePrintingOfPresaleCertificates model) =>
        {
            //return TypedResults.Created($"/api/ApiResults/{model.ID}", model);
        })
        .WithName("RequestForRequestPostsalePrintingOfPresaleCertificates")
        .WithOpenApi(o => new(o)
        {
            Summary = "Retrieves the request postsale printing of presale certificates"
        })
        .Produces<ApiResult<RequestPostsalePrintingOfPresaleCertificates>>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status404NotFound, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");
    }
}
