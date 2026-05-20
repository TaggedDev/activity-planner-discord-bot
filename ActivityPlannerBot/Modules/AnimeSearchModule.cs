using ActivityPlannerBot.Services.AnimeFetcher;
using NetCord.Services.ApplicationCommands;

namespace ActivityPlannerBot.Modules;

public class AnimeSearchModule(AnimeParser animeParser) : ApplicationCommandModule<ApplicationCommandContext>
{
    [SlashCommand("anime", "Создать мероприятие по просмотру китайских мультиков")]
    public string CreateAnimeActivity(string query)
    {
        AnimeData animeData = animeParser.GetAnimeByQuery(query);
        return $"По вашему запросу нашлось: {animeData.Name}: Это {animeData.Description}";
    }
}