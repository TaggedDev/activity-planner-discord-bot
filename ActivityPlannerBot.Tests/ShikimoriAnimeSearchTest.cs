using ActivityPlannerBot.Services.AnimeFetcher;

namespace ActivityPlannerBot.Tests;

public class ShikimoriAnimeSearchTest
{
    [Fact]
    public async Task GetAnimeByQuery_WhenCalled_ShouldReturnAnimeData()
    {
        // Arrange
        var fetcher = new ShikimoriAnimeParser();
    
        // Act
        var result = await fetcher.GetAnimeByQuery("Naruto");
        
        // Assert
        Assert.NotNull(result);
        Assert.Equal("Example1", result.Name);
    }
}
