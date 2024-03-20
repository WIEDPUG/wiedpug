using System.Reflection;
using Wiedpug.API.SchemaFilter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {    
    c.SchemaFilter<DescribeEnumMemberValues>();

    //To automatically add XML comments to Open API Spec.
    var apiXmlFilePath = Path.Combine(System.AppContext.BaseDirectory, "Wiedpug.API.xml");
    c.IncludeXmlComments(apiXmlFilePath);

    var domainXmlFilePath = Path.Combine(System.AppContext.BaseDirectory, "Wiedpug.Domain.xml");
    c.IncludeXmlComments(domainXmlFilePath);
});

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

app.Run();
