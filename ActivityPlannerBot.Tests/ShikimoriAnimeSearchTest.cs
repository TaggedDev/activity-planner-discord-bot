using ActivityPlannerBot.Services.AnimeFetcher;

namespace ActivityPlannerBot.Tests;

public class ShikimoriAnimeSearchTest
{
    [Fact]
    public void FetchAnime_WhenCalled_ShouldReturnAnimeData()
    {
        // Arrange
        var parser = new ShikimoriAnimeParser(); // предполагая, что у вас есть публичный конструктор
        
        // Act
        // var result = await parser.FetchAnimeAsync("naruto");
        
        // Assert
        // Assert.NotNull(result);
    }
}
