using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate;
using Wiedpug.Domain.Aggregates.StatusReplyAggregate;
using Wiedpug.Domain.Entities;
using Wiedpug.Domain.Enums;
namespace Wiedpug.API.Controllers;

public static class AuctionCatalogueEndpoints
{    
    public static void MapAuctionCatalogueEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("auction-catalogue").WithTags("Auction Catalogue");

       
        group.MapPost("/",
            [SwaggerRequestExample(typeof(List<AuctionCatalogue>), typeof(AuctionCatalogueRequestExamples))]
            [SwaggerResponseExample(StatusCodes.Status200OK, typeof(AuctionCatalogueResponse200Example))]
            [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
            [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
            [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoWritePermissionExample))]
            [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] List<AuctionCatalogue> model) =>
        {
            //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
        })
        .WithName("Create")
        .WithOpenApi(o => new(o)
        {
            Summary = "Used by brokers to transmit Original broadcast and private auction catalogue data to the Network for auctions regulated by the Australian Wool Exchange Limited."
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

        group.MapPost("/updates",
            [SwaggerRequestExample(typeof(List<AuctionCatalogue>), typeof(AuctionCatalogueUpdatesRequestExample))]
            [SwaggerResponseExample(StatusCodes.Status200OK, typeof(AuctionCatalogueResponse200Example))]
            [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
            [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
            [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoWritePermissionExample))]
            [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] List<AuctionCatalogue> model) =>
            {
                //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
            })
        .WithName("CreateUpdates")
        .WithOpenApi(o => new(o)
        {
            Summary = "Used by brokers to transmit broadcast and private auction catalogue data updates to the Network for auctions regulated by the Australian Wool Exchange Limited."
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

        group.MapGet("/data",
            //[SwaggerRequestExample(typeof(List<RequestForDataForAuctionCatalogue>), typeof(RequestForDataAuctionCatalogueRequestExamples))]
            [SwaggerResponseExample(StatusCodes.Status200OK, typeof(AuctionCatalogueResponse200Example))]
            [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
            [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
            [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
            [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] List<RequestForDataForAuctionCatalogue> model) =>
        {
            //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
        })
        .WithName("GetData")
        .WithOpenApi(o => new(o)
        {
            Summary = "Used by brokers to request Private and Broadcast data, as well as Re-requesting data for Auction Catalogues, Private Catalogues, and Auction Catalogue Updates"
        })
        .Produces<ApiResult<AuctionCatalogue>>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");        
    }
}
