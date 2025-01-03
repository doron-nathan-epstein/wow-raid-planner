using RaidPlanner.Application;
using RaidPlanner.Infrastructure;
using RaidPlanner.Presentation.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
  .AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddBlazorBootstrap();

builder.Services
  .AddApplication()
  .AddInfrastructure();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
