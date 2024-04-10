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
            [SwaggerRequestExample(typeof(AuctionCatalogue), typeof(AuctionCatalogueRequestExample))]            
        ([FromBody] AuctionCatalogue model) =>
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
            [SwaggerRequestExample(typeof(AuctionCatalogue), typeof(AuctionCatalogueUpdatesRequestExample))]
        ([FromBody] AuctionCatalogue model) =>
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
            [SwaggerRequestExample(typeof(RequestForDataForAuctionCatalogue), typeof(RequestForDataAuctionCatalogueRequestExample))]
        ([FromBody] RequestForDataForAuctionCatalogue model) =>
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

        group.MapGet("/status",
            [SwaggerRequestExample(typeof(RequestForDataForAuctionCatalogue), typeof(RequestForStatusAuctionCatalogueRequestExample))]
        ([FromBody] RequestForStatusForAuctionCatalogue model) =>
        {
            //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
        })
        .WithName("GetStatus")
        .WithOpenApi(o => new(o)
        {
            Summary = "Used by brokers to request status for Auction Catalogues, Private Catalogues, and Auction Catalogue Updates"
        })
        .Produces<ApiResult<StatusReply>>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");
    }
}
