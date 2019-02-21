using System.Linq;
using Game.Configurations;
using Game.DataModel.Runtime;
using Game.Goods;
using Game.GameModels;
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

        [Fact]
        public void AddXp_InitializeDefinitions_IncreaseXp()
        {
            // Arrange
            int initialXp = 200;
            int increaseXp = 1200;
            int expectedXp = initialXp + increaseXp;
            var gameModel = new GameModel(null, TestEnvironment.AllDefinitionsFake);
            gameModel.PlayerGoods.Xp = initialXp;

            // Act
            gameModel.AddXp(increaseXp);

            // Assert
            Assert.Equal(expectedXp, gameModel.PlayerGoods.Xp);
        }

        [Theory]
        [InlineData(GoodsType.BaseStation)]
        [InlineData(GoodsType.LaunchTower)]
        [InlineData(GoodsType.RecruitmentOfColonist)]
        [InlineData(GoodsType.FuelRefinery)]
        [InlineData(GoodsType.ResearchLaboratory)]
        [InlineData(GoodsType.AntimatterCatcher)]
        [InlineData(GoodsType.ResourceObservatory)]
        public void Build_InitializeDefinitions_IsBuilt(GoodsType goodsType)
        {
            // Arrange
            var gameModel = new GameModel(null, TestEnvironment.AllDefinitionsFake);
            IRaising expectedGoodsRaising = gameModel.AllGoods[goodsType];

            // Act
            gameModel.Build(goodsType);

            // Assert
            Assert.True(expectedGoodsRaising.IsBuilt);
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
        [InlineData(GoodsType.Player, 12)]
        [InlineData(GoodsType.BaseStation, 23)]
        [InlineData(GoodsType.LaunchTower, 34)]
        [InlineData(GoodsType.RecruitmentOfColonist, 45)]
        [InlineData(GoodsType.FuelRefinery, 56)]
        [InlineData(GoodsType.ResearchLaboratory, 67)]
        [InlineData(GoodsType.AntimatterCatcher, 78)]
        [InlineData(GoodsType.ResourceObservatory, 89)]
        public void GetLevel_InitializePlayData_ReturnExpectedLevel(GoodsType goodsType, int expectedLevel)
        {
            // Arrange
            IPlayData playData = TestEnvironment.SetupPlayData(0);
            IGoods goods = playData.Goods.FirstOrDefault(d => d.BuildingType == (int)goodsType);
            Mock.Get(goods).Setup(d => d.Level).Returns(expectedLevel);

            var gameModel = new GameModel(playData, TestEnvironment.AllDefinitionsFake);

            // Act
            int level = gameModel.GetLevel(goodsType);

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