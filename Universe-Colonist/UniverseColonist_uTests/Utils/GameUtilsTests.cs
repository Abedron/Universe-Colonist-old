using Game.Utils;
using Xunit;

namespace UniverseColonistTests.Utils
{
    public class GameUtilsTests
    {
        [Theory]
        [InlineData("2019.40.1472", 2019401472)]
        [InlineData("2019.40", 201940)]
        [InlineData("2019.40 Beta", 201940)]
        [InlineData("Without a number", 0)]
        [InlineData("", 0)]
        public void ParseVersion_VersionsInput_ParsedNumbers(string serializedVersion, int expectedVersion)
        {
            // Act
            int version = GameUtils.ParseVersion(serializedVersion);

            // Assert
            Assert.Equal(expectedVersion, version);
        }
    }
}