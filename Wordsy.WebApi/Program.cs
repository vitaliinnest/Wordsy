using Wordsy.Application;
using Wordsy.Infrastructure;
using Wordsy.Presentation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddPresentation();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
