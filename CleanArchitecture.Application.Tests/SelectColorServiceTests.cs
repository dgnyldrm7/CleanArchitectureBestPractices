using CleanArchitecture.Application.Services;

namespace CleanArchitecture.Application.Tests
{
    public class SelectColorServiceTests
    {
        [Fact]
        public void SelectColor_ShouldThrowException_WhenColorIsBanned()
        {
            // AAA  design pattern: Arrange, Act, Assert

            // Arrange
            string bannedColors = "blue";
            var selectColorService = new SelectColorService();
            selectColorService.SelectColor(bannedColors);

        }
    }
}