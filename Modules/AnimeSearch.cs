using NetCord.Services.ApplicationCommands;

namespace ActivityPlannerBot.Modules;

public class AnimeSearch : ApplicationCommandModule<ApplicationCommandContext>
{
    [SlashCommand("anime", "Создать мероприятие по просмотру китайских мультиков")]
    public string CreateAnimeActivity() => "Anime test";
}