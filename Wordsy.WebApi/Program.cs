using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using Wordsy.Application;
using Wordsy.Infrastructure;
using Wordsy.Presentation;

var builder = WebApplication.CreateBuilder(args);

builder.Services
	.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
	.AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAdB2C"));

builder.Services
	.AddApplication()
	.AddInfrastructure(builder.Configuration)
	.AddPresentation();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
