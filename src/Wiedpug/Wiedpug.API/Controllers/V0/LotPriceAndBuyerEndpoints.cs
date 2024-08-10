using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.LotPriceAndBuyerAggregate;
using Wiedpug.Domain.Aggregates.LotPriceAndBuyersAggregate;
using Wiedpug.Domain.Aggregates.StatementsAggregate;
using Wiedpug.Domain.Aggregates.TextAggregate;
using Wiedpug.Domain.Entities;
namespace Wiedpug.API.Controllers.V0;

public static class LotPriceAndBuyerEndpoints
{
    public static void MapLotPriceAndBuyerEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("lot-price-and-buyer").WithTags("Lot Price And Buyer");

        group.MapPost("/",
        [SwaggerRequestExample(typeof(List<LotPriceAndBuyer>), typeof(CreateLotPriceAndBuyersRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CommonResponse200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400SingleObjectRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] List<LotPriceAndBuyer> model) =>
            {
                //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
            })
        .WithName("CreateLotPriceAndBuyer")
        .WithOpenApi(o => new(o)
        {
            Summary = "LotPriceAndBuyer",
            Description = "Used to provide lot price And buyer"
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<ApiErrorResult>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

        group.MapPost("/data",
        [SwaggerRequestExample(typeof(WoolSaleRequestForData), typeof(RequestForLotPriceAndBuyersRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RequestForLotPriceAndBuyers200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status404NotFound, typeof(CommonResponse404NotFoundExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] WoolSaleRequestForData model) =>
        {
            //return TypedResults.Created($"/api/ApiResults/{model.ID}", model);
        })
        .WithName("RequestForLotPriceAndBuyer")
        .WithOpenApi(o => new(o)
        {
            Summary = "Retrieves the lot price and buyer"
        })
        .Produces<ApiResult<List<LotPriceAndBuyer>>>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<ApiErrorResult>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status404NotFound, contentType: "application/problem+json")
        .Produces<ApiErrorResult>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");
    }
}
