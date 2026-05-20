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

// Add commands using minimal APIs
host.AddSlashCommand("game", "Создать мероприятие для гэймеров", () => "Здарова геймеры!");

host.AddModules(typeof(AnimeSearch).Assembly);

await host.RunAsync();