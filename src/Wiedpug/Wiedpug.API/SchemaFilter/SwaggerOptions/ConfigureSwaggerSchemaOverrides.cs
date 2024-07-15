//using Microsoft.Extensions.Options;
//using Microsoft.OpenApi.Models;
//using Swashbuckle.AspNetCore.SwaggerGen;
//using Wiedpug.Domain.Enums;

//namespace Wiedpug.API.SwaggerOptions
//{
//    /// <summary>
//    /// Override properties here where Data Type references a Enum.
//    /// This is so Swagger UI can properly display what Data Type the property really requires instead of showing Enum as the data type.
//    /// More details: https://github.com/domaindrivendev/Swashbuckle.AspNetCore?tab=readme-ov-file#override-schema-for-specific-types
//    /// </summary>
//    public class ConfigureSwaggerSchemaOverrides : IConfigureNamedOptions<SwaggerGenOptions>
//    {
//        public void Configure(string? name, SwaggerGenOptions options)
//        {
//            Configure(options);
//        }

//        public void Configure(SwaggerGenOptions options)
//        {
//            //Define the real data type of each enum
//            options.MapType<BaleDetailType>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<CalculationBasis>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<CalibrationFlag>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<CatalogueSection>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<CatalogueSymbol>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<Centre>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<CombinationFlag>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<CountryCode>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<DarkAndMedullatedFibreRisk>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<DeliveryBasis>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<Instrument>(() => new OpenApiSchema { Type = "integer" });            
//            options.MapType<InvoiceMassFlag>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<Laboratory>(() => new OpenApiSchema { Type = "integer" });
//            options.MapType<LotType>(() => new OpenApiSchema { Type = "integer" });
//            options.MapType<LsCertType>(() => new OpenApiSchema { Type = "integer" });
//            options.MapType<MulesingStatus>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<OfferType>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<PackCondition>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<PackMaterial>(() => new OpenApiSchema { Type = "string" });            
//            options.MapType<PackType>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<PriceBasis>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<QualityScheme>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<RecordTypesToBeExcludedForAuctionCatalogue>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<ReissueChargeFlag>(() => new OpenApiSchema { Type = "integer" });
//            options.MapType<ReportingFlag>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<RequestType>(() => new OpenApiSchema { Type = "integer" });
//            options.MapType<RequestTypeForData>(() => new OpenApiSchema { Type = "integer" });
//            options.MapType<RetestFlag>(() => new OpenApiSchema { Type = "integer" });
//            options.MapType<SaleType>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<ScouredType>(() => new OpenApiSchema { Type = "integer" });
//            options.MapType<SourceCode>(() => new OpenApiSchema { Type = "integer" });
//            options.MapType<SubSamplingMethod>(() => new OpenApiSchema { Type = "integer" });
//            options.MapType<TransmissionType>(() => new OpenApiSchema { Type = "integer" });
//            options.MapType<TransmissionTypeForAuctionCatalogue>(() => new OpenApiSchema { Type = "integer" });
//            options.MapType<UpdateType>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<WeightUnit>(() => new OpenApiSchema { Type = "integer" });            
//            options.MapType<WoolState>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<WoolTypeGroup>(() => new OpenApiSchema { Type = "string" });
//            options.MapType<YieldType>(() => new OpenApiSchema { Type = "integer" });
            
//        }
//    }

//}
