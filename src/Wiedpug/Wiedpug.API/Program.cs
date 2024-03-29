﻿using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Wiedpug.API.SchemaFilter;
using Wiedpug.API.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {

    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Wiedpug.API", Version = "v1" });

    c.SchemaFilter<DescribeEnumMemberValues>();

    //To automatically add XML comments to Open API Spec.
    var apiXmlFilePath = Path.Combine(System.AppContext.BaseDirectory, "Wiedpug.API.xml");
    c.IncludeXmlComments(apiXmlFilePath);

    var domainXmlFilePath = Path.Combine(System.AppContext.BaseDirectory, "Wiedpug.Domain.xml");
    c.IncludeXmlComments(domainXmlFilePath);

    c.ExampleFilters(); //To support examples
});

builder.Services.AddSwaggerExamplesFromAssemblyOf<Program>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapApiResultEndpoints();

app.MapAuctionCatalogueEndpoints();

app.Run();
