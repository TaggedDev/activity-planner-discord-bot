using ActivityPlannerBot.Services.AnimeFetcher;
using NetCord.Services.ApplicationCommands;

namespace ActivityPlannerBot.Modules;

public class AnimeSearchModule(ShikimoriAnimeParser shikimoriAnimeParser) : ApplicationCommandModule<ApplicationCommandContext>
{
    [SlashCommand("anime", "Создать мероприятие по просмотру китайских мультиков")]
    public async Task<string> CreateAnimeActivity(string query)
    {
        AnimeData animeData = await shikimoriAnimeParser.GetAnimeByQuery(query);
        return $"По вашему запросу нашлось: {animeData.Name}: Это {animeData.Description}";
    }
}