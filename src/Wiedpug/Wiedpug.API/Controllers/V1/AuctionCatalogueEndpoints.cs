using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.ExampleResponses;
using Wiedpug.API.Model;
using Wiedpug.Domain.Aggregates.AuctionCatalogueAggregate;
using Wiedpug.Domain.Entities;
namespace Wiedpug.API.Controllers.V1;

public static class AuctionCatalogueEndpoints
{
    public static void MapAuctionCatalogueEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/auction-catalogue")
            .MapToApiVersion(1,0)
            .WithTags("Auction Catalogue");
            ////Uncomment below to mark all endpoints in this file as Deprecated
            //.WithOpenApi(o => new(o)
            //{
            //    Deprecated = true,
            //});

        group.MapPost("/",            
            [SwaggerRequestExample(typeof(List<AuctionCatalogue>), typeof(AuctionCatalogueRequestExamples))]            
            [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CommonResponse200Example))]
            [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
            [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
            [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoWritePermissionExample))]
            [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] List<AuctionCatalogue> model) =>
        {
            //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
        })        
        .WithOpenApi(o => new(o)
        {
            ////Uncoment to mark this particular endpoint as Deprecated
            //Deprecated = true,
            Summary = "Transmit new Auction Catalogues and Private Catalogues",
            Description = "Used by brokers to transmit Original broadcast and private auction catalogue data to the Network for auctions regulated by the Australian Wool Exchange Limited.",            
        })        
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

        group.MapPost("/updates",
            [SwaggerRequestExample(typeof(List<AuctionCatalogue>), typeof(AuctionCatalogueUpdatesRequestExample))]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CommonResponse200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoWritePermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] List<AuctionCatalogue> model) =>
            {
                //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
            })        
        .WithOpenApi(o => new(o)
        {
            Summary = "Transmit Auction Catalogue Updates",
            Description = "Used by brokers to transmit broadcast and private auction catalogue data updates to the Network for auctions regulated by the Australian Wool Exchange Limited."
        })        
        .Produces<ApiResult>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");

        group.MapPost("/data",
            //[SwaggerRequestExample(typeof(List<RequestForDataForAuctionCatalogue>), typeof(RequestForDataAuctionCatalogueRequestExamples))]            
            [SwaggerResponseExample(StatusCodes.Status200OK, typeof(RequestForDataAuctionCatalogue200Example))]
        [SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(CommonResponse400ArrayRequestPayloadExample))]
        [SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(CommonResponse401Example))]
        [SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(CommonResponse403NoReadPermissionExample))]
        [SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(CommonResponse500Example))]
        ([FromBody] List<RequestForDataForAuctionCatalogue> model) =>
        {
            //return TypedResults.Created($"/api/AuctionCatalogues/{model.ID}", model);
        })        
        .WithOpenApi(o => new(o)
        {
            Summary = "Request for Data relating to Auction Catalogue, Private Catalogue and Auction Catalogue Updates",
            Description = "Used by brokers to request Private and Broadcast data, as well as Re-requesting data for Auction Catalogues, Private Catalogues, and Auction Catalogue Updates"
        })        
        .Produces<ApiResult<List<AuctionCatalogue>>>(StatusCodes.Status200OK, contentType: "application/json")
        .Produces<CustomProblemDetails>(StatusCodes.Status400BadRequest, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status401Unauthorized, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status403Forbidden, contentType: "application/problem+json")
        .Produces<CustomProblemDetails>(StatusCodes.Status500InternalServerError, contentType: "application/problem+json");
    }
}
