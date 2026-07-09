var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddOrchardCms()
    .AddSetupFeatures("OrchardCore.AutoSetup");

var app = builder.Build();

app.UseStaticFiles();
app.UseOrchardCore();

app.Run();
