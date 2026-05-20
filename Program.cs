using ActivityPlannerBot.Modules;
using ActivityPlannerBot.Services.AnimeFetcher;
using Microsoft.Extensions.Hosting;
using NetCord.Hosting.Gateway;
using NetCord.Hosting.Services;
using NetCord.Hosting.Services.ApplicationCommands;
using Microsoft.Extensions.DependencyInjection;

var builder = Host.CreateApplicationBuilder(args);

builder.Services
    .AddDiscordGateway()
    .AddTransient<AnimeParser>()
    .AddApplicationCommands();
    


var host = builder.Build();
host.AddModules(typeof(AnimeSearchModule).Assembly);

await host.RunAsync();