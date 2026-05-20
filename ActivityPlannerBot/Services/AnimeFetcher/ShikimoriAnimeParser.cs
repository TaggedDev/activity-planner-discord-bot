namespace ActivityPlannerBot.Services.AnimeFetcher;

public class ShikimoriAnimeParser
{
    public async Task<AnimeData> GetAnimeByQuery(string query) 
        => new("Example1", "Description1");
}