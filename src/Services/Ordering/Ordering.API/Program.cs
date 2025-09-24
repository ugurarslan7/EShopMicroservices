using Ordering.API;
using Ordering.Application;
using Ordering.Infrastructure.Data.Extensions;
using Ordering.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices(builder.Configuration)
                .AddInfrastructureServices(builder.Configuration)
                .AddApiServices(builder.Configuration);

var app = builder.Build();

app.UseApiServices();

if (app.Environment.IsDevelopment())
{
    await app.InitialiseDatabaseAsync();
}

app.Run();
