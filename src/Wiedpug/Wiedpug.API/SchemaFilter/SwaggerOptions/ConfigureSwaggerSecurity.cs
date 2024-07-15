using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Wiedpug.API.SchemaFilter.SwaggerOptions
{
    public class ConfigureSwaggerSecurity : IConfigureNamedOptions<SwaggerGenOptions>
    {
        public void Configure(string? name, SwaggerGenOptions options)
        {
            Configure(options);
        }

        public void Configure(SwaggerGenOptions options)
        {
            //This is the Security definition for the Bearer authentication.
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = "JWT Access Token that is added in the Authorization header of the HTTP request. Example: \"Authorization: Bearer {token}\". The JWT serves as a credential that proves the identity of the client to the server.",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
            });

            //This is the Security definition for OAuth2 authentication which is used for obtaining a Bearer token.
            //It is important to include this in, so that the authentication process can be documentated in Swagger UI.
            options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
            {
                Type = SecuritySchemeType.OAuth2,
                Description = "Authentication for client applications by providing Client ID and Client Secret for an JWT Access Token.",
                Flows = new OpenApiOAuthFlows
                {
                    ClientCredentials = new OpenApiOAuthFlow
                    {
                        TokenUrl = new Uri("/auth-server/oauth/token", UriKind.Relative)
                    }
                }
            });

            //This is the default global security requirement. This means that all endpoints require a Bearer token.
            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
                    },
                    new string[] { }
                }
            });
        }

    }
}
