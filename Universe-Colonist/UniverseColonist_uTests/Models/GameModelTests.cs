using System.Linq;
using Game.Configurations;
using Game.Models;
using Game.PlayDataService;
using Game.Services;
using Moq;
using Xunit;

namespace UniverseColonistTests.Models
{
    public class GameModelTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(4)]
        [InlineData(123)]
        public void CtorGameModel_InitializeGameGoods_LevelAndXpIsInitialized(int expectedLevel)
        {
            // Arrange
            IPlayData playData = TestEnvironment.SetupPlayData(expectedLevel);
            AllDefinitions allDefinitions = TestEnvironment.AllDefinitionsFake;

            // Act
            var gameModel = new GameModel(playData, allDefinitions);

            // Assert
            Assert.Equal(expectedLevel, gameModel.PlayerGoods.Level);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1300)]
        [InlineData(1800000)]
        public void CtorGameModel_InitializeXp_XpIsInitialized(int expectedXp)
        {
            // Arrange
            IPlayData playData = TestEnvironment.SetupPlayDataXp(expectedXp);
            AllDefinitions allDefinitions = TestEnvironment.AllDefinitionsFake;

            // Act
            var gameModel = new GameModel(playData, allDefinitions);

            // Assert
            Assert.Equal(expectedXp, gameModel.PlayerGoods.Xp);
        }

        [Theory]
        [InlineData((int)GoodsType.Player, 12)]
        [InlineData((int)GoodsType.BaseStation, 23)]
        [InlineData((int)GoodsType.LaunchTower, 34)]
        [InlineData((int)GoodsType.RecruitmentOfColonist, 45)]
        [InlineData((int)GoodsType.FuelRefinery, 56)]
        [InlineData((int)GoodsType.ResearchLaboratory, 67)]
        [InlineData((int)GoodsType.AntimatterCatcher, 78)]
        [InlineData((int)GoodsType.ResourceObservatory, 89)]
        public void GetLevel_InitializePlayData_ReturnExpectedLevel(int goodsType, int expectedLevel)
        {
            // Arrange
            IPlayData playData = TestEnvironment.SetupPlayData(0);
            IGoods goods = playData.Goods.FirstOrDefault(d => d.BuildingType == goodsType);
            Mock.Get(goods).Setup(d => d.Level).Returns(expectedLevel);

            var gameModel = new GameModel(playData, TestEnvironment.AllDefinitionsFake);

            // Act
            int level = gameModel.GetLevel((GoodsType) goodsType);

            // Assert
            Assert.Equal(expectedLevel, level);
        }

        [Fact]
        public void GetLevel_InitializePlayData_ReturnZeroLevel()
        {
            // Arrange
            var gameModel = new GameModel(TestEnvironment.SetupPlayData(0), TestEnvironment.AllDefinitionsFake);

            // Act
            int level = gameModel.GetLevel(GoodsType.None);

            // Assert
            Assert.Equal(0, level);
        }

        [Fact]
        public void TryGoodsRaiseLevel_InitializePlayData_ReturnZeroLevel()
        {
            // Arrange
            var expected = new GoodsType[]
            {
                GoodsType.Player,
                GoodsType.BaseStation,
                GoodsType.AntimatterCatcher,
                GoodsType.LaunchTower,
                GoodsType.RecruitmentOfColonist,
                GoodsType.ResourceObservatory
            };

            var gameModel = new GameModel(TestEnvironment.SetupPlayData(0), TestEnvironment.AllDefinitionsFake);

            // Act 
            var goodsRaiseLevel = gameModel.TryGoodsRaiseLevel(1100);

            // Assert
            Assert.Equal(expected, goodsRaiseLevel);
            
        }
    }
}