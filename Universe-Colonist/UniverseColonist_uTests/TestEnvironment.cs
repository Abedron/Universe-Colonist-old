using System.Collections.Generic;
using Game.Configurations;
using Game.Services;
using Game.Services.Definitions;
using Game.Services.Definitions.Buildings;
using Game.StockService;
using Moq;

namespace UniverseColonistTests
{
    public static class TestEnvironment
    {
        private static MockRepository MockRepository { get; } = new MockRepository(MockBehavior.Default){DefaultValue = DefaultValue.Mock};

        public static IRaiseDefinition[] BaseStationDefinitionsFake { get; } =
        {
            new BaseStationDefinition() {Xp = 0, Level = 0},
            new BaseStationDefinition() {Xp = 1100, Level = 1},
            new BaseStationDefinition() {Xp = 1200, Level = 2},
            new BaseStationDefinition() {Xp = 1300, Level = 3},
            new BaseStationDefinition() {Xp = 1400, Level = 4},
            new BaseStationDefinition() {Xp = 1600, Level = 5},
            new BaseStationDefinition() {Xp = 1700, Level = 6}
        };

        public static AllDefinitions AllDefinitionsFake { get; } = new AllDefinitions()
        {
            Version = "2019.41.1472",
            Game = new []
            {
                new GameDefinition() {Xp = 0, Level = 0},
                new GameDefinition() {Xp = 1100, Level = 1},
                new GameDefinition() {Xp = 1200, Level = 2},
                new GameDefinition() {Xp = 1300, Level = 3},
                new GameDefinition() {Xp = 1400, Level = 4}
            },
            Buildings =
            {
                BaseStation = BaseStationDefinitionsFake,
                AntimatterCatcher = new []
                {
                    new AntimatterCatcherDefinition() {Xp = 0, Level = 0},
                    new AntimatterCatcherDefinition() {Xp = 1100, Level = 1},
                    new AntimatterCatcherDefinition() {Xp = 1200, Level = 2},
                    new AntimatterCatcherDefinition() {Xp = 1300, Level = 3},
                    new AntimatterCatcherDefinition() {Xp = 1400, Level = 4}
                },
                FuelRefinery = new []
                {
                    new FuelRefineryDefinition() {Xp = 0, Level = 0},
                    new FuelRefineryDefinition() {Xp = 1100, Level = 1},
                    new FuelRefineryDefinition() {Xp = 1200, Level = 2},
                    new FuelRefineryDefinition() {Xp = 1300, Level = 3},
                    new FuelRefineryDefinition() {Xp = 1400, Level = 4}
                },
                LaunchTowerRockets = new []
                {
                    new LaunchTowerRocketsDefinition() {Xp = 0, Level = 0},
                    new LaunchTowerRocketsDefinition() {Xp = 1100, Level = 1},
                    new LaunchTowerRocketsDefinition() {Xp = 1200, Level = 2},
                    new LaunchTowerRocketsDefinition() {Xp = 1300, Level = 3},
                    new LaunchTowerRocketsDefinition() {Xp = 1400, Level = 4}
                },
                ResearchLaboratory = new []
                {
                    new ResearchLaboratoryDefinition() {Xp = 0, Level = 0},
                    new ResearchLaboratoryDefinition() {Xp = 1100, Level = 1},
                    new ResearchLaboratoryDefinition() {Xp = 1200, Level = 2},
                    new ResearchLaboratoryDefinition() {Xp = 1300, Level = 3},
                    new ResearchLaboratoryDefinition() {Xp = 1400, Level = 4}
                },
                ResourceObservatory = new []
                {
                    new ResourceObservatoryDefinition() {Xp = 0, Level = 0},
                    new ResourceObservatoryDefinition() {Xp = 1100, Level = 1},
                    new ResourceObservatoryDefinition() {Xp = 1200, Level = 2},
                    new ResourceObservatoryDefinition() {Xp = 1300, Level = 3},
                    new ResourceObservatoryDefinition() {Xp = 1400, Level = 4}
                },
                RecruitmentOfColonist = new []
                {
                    new RecruitmentOfColonistDefinition() {Xp = 0, Level = 0},
                    new RecruitmentOfColonistDefinition() {Xp = 1100, Level = 1},
                    new RecruitmentOfColonistDefinition() {Xp = 1200, Level = 2},
                    new RecruitmentOfColonistDefinition() {Xp = 1300, Level = 3},
                    new RecruitmentOfColonistDefinition() {Xp = 1400, Level = 4}
                },
            }
        };

        public static IConfigurationStock SetupConfigurationStock(int xp, int gameLevel)
        {
            var goods = new List<IGoods>();
            var goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)GoodsType.Game);
            goodsMock.Setup(d => d.Level).Returns(gameLevel);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)GoodsType.AntimatterCatcher);
            goodsMock.Setup(d => d.Level).Returns(2);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)GoodsType.BaseStation);
            goodsMock.Setup(d => d.Level).Returns(2);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)GoodsType.FuelRefinery);
            goodsMock.Setup(d => d.Level).Returns(2);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)GoodsType.LaunchTower);
            goodsMock.Setup(d => d.Level).Returns(2);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)GoodsType.RecruitmentOfColonist);
            goodsMock.Setup(d => d.Level).Returns(2);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)GoodsType.ResearchLaboratory);
            goodsMock.Setup(d => d.Level).Returns(2);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)GoodsType.ResourceObservatory);
            goodsMock.Setup(d => d.Level).Returns(2);
            goods.Add(goodsMock.Object);

            var configurationStockMock = MockRepository.Create<IConfigurationStock>();
            configurationStockMock.Setup(d => d.Xp).Returns(xp);
            configurationStockMock.Setup(d => d.Goods).Returns(goods.ToArray);


            return configurationStockMock.Object;
        }
    }
}