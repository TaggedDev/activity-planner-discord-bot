using ActivityPlannerBot.Services.AnimeFetcher;
using NetCord.Services.ApplicationCommands;

namespace ActivityPlannerBot.Modules;

public class AnimeSearchModule(ShikimoriAnimeParser shikimoriAnimeParser) : ApplicationCommandModule<ApplicationCommandContext>
{
    [SlashCommand("anime", "Создать мероприятие по просмотру китайских мультиков")]
    public string CreateAnimeActivity(string query)
    {
        AnimeData animeData = shikimoriAnimeParser.GetAnimeByQuery(query);
        return $"По вашему запросу нашлось: {animeData.Name}: Это {animeData.Description}";
    }
}