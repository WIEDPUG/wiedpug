using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate;
namespace Wiedpug.API.Controllers;

public static class AuctionCatalogueEndpoints
{
    public static void MapAuctionCatalogueEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("auction-catalogue").WithTags("Auction Catalogue");

       
        group.MapPost("/", (AuctionCatalogue model) =>
        {
            //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
        })
        .WithName("CreateAuctionCatalogue")
        .WithOpenApi(o => new(o)
        {
            Summary = "Used by brokers to transmit auction catalogue data to the Network for auctions regulated by the Australian Wool Exchange Limited."
        })
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

    }
}
