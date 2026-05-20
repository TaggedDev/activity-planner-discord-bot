using ActivityPlannerBot.Modules;
using Microsoft.Extensions.Hosting;
using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services;
using NetCord.Hosting.Services.ApplicationCommands;

var builder = Host.CreateApplicationBuilder(args);

builder.Services
    .AddDiscordGateway()
    .AddApplicationCommands();

var host = builder.Build();
host.AddModules(typeof(AnimeSearchModule).Assembly);

await host.RunAsync();