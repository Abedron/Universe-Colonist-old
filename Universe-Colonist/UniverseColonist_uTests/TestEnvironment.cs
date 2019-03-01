using System.Collections.Generic;
using Game.Articles;
using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;
using Moq;

namespace UniverseColonistTests
{
    public static class TestEnvironment
    {
        private static MockRepository MockRepository { get; } = new MockRepository(MockBehavior.Default){DefaultValue = DefaultValue.Mock};

        public static IRaiseDefinition[] BaseStationDefinitionsFake { get; } =
        {
            new BaseStationDefinition() {Xp = 1100, Level = 1},
            new BaseStationDefinition() {Xp = 1600, Level = 2},
            new BaseStationDefinition() {Xp = 7400, Level = 3},
            new BaseStationDefinition() {Xp = 189000, Level = 4}
        };

        public static AllDefinitions AllDefinitionsFake { get; } = new AllDefinitions()
        {
            Version = "2019.41.1472",
            Player = new []
            {
                new GameDefinition() {Xp = 1100, Level = 1},
                new GameDefinition() {Xp = 1200, Level = 2},
                new GameDefinition() {Xp = 1300, Level = 3},
                new GameDefinition() {Xp = 1400, Level = 4},
                new GameDefinition() {Xp = 1600, Level = 5},
                new GameDefinition() {Xp = 1700, Level = 6},
                new GameDefinition() {Xp = 1900, Level = 7},
                new GameDefinition() {Xp = 2100, Level = 8},
                new GameDefinition() {Xp = 2300, Level = 9},
                new GameDefinition() {Xp = 2500, Level = 10}
            },
            Buildings =
            {
                BaseStation = BaseStationDefinitionsFake,
                AntimatterCatcher = new []
                {
                    new AntimatterCatcherDefinition() {Xp = 1100, Level = 1},
                    new AntimatterCatcherDefinition() {Xp = 1200, Level = 2},
                    new AntimatterCatcherDefinition() {Xp = 1600, Level = 3},
                    new AntimatterCatcherDefinition() {Xp = 2100, Level = 4},
                    new AntimatterCatcherDefinition() {Xp = 3400, Level = 5},
                    new AntimatterCatcherDefinition() {Xp = 7400, Level = 6}
                },
                FuelRefinery = new []
                {
                    new FuelRefineryDefinition() {Xp = 1600, Level = 1, Value = "0.8"},
                    new FuelRefineryDefinition() {Xp = 2100, Level = 2, Value = "1.2"},
                    new FuelRefineryDefinition() {Xp = 2500, Level = 3, Value = "2"},
                    new FuelRefineryDefinition() {Xp = 3400, Level = 4, Value = "3.2"},
                    new FuelRefineryDefinition() {Xp = 7400, Level = 5, Value = "5.2"},
                    new FuelRefineryDefinition() {Xp = 25500, Level = 6, Value = "8.4"},
                    new FuelRefineryDefinition() {Xp = 189000, Level = 7, Value = "13.6"},
                    new FuelRefineryDefinition() {Xp = 4830000, Level = 8, Value = "22"}
                },
                LaunchTower = new []
                {
                    new FuelRefineryDefinition() {Xp = 1100, Level = 1, Value = "1"},
                    new FuelRefineryDefinition() {Xp = 1300, Level = 2, Value = "2"},
                    new FuelRefineryDefinition() {Xp = 1600, Level = 3, Value = "3"},
                    new FuelRefineryDefinition() {Xp = 2100, Level = 4, Value = "4"},
                    new FuelRefineryDefinition() {Xp = 3400, Level = 5, Value = "5"},
                    new FuelRefineryDefinition() {Xp = 7400, Level = 6, Value = "8"},
                    new FuelRefineryDefinition() {Xp = 25500, Level = 7, Value = "13"},
                    new FuelRefineryDefinition() {Xp = 189000, Level = 8, Value = "21"},
                    new FuelRefineryDefinition() {Xp = 4830000, Level = 9, Value = "34"}
                },
                ResearchLaboratory = new []
                {
                    new LaunchTowerDefinition() {Xp = 7400, Level = 1}
                },
                ResourceObservatory = new []
                {
                    new ResourceObservatoryDefinition() {Xp = 1100, Level = 1, Value = "Mars,Venus"},
                    new ResourceObservatoryDefinition() {Xp = 1300, Level = 2, Value = "Mercury,Vesta"},
                    new ResourceObservatoryDefinition() {Xp = 1600, Level = 3, Value = "Ceres,Asteroids"},
                    new ResourceObservatoryDefinition() {Xp = 2100, Level = 4, Value = "Jupiter,Antuel"}
                },
                RecruitmentOfColonist = new []
                {
                    new RecruitmentOfColonistDefinition() {Xp = 1100, Level = 1, Value = "1"},
                    new RecruitmentOfColonistDefinition() {Xp = 1600, Level = 2, Value = "2"},
                    new RecruitmentOfColonistDefinition() {Xp = 7400, Level = 3, Value = "3"},
                    new RecruitmentOfColonistDefinition() {Xp = 189000, Level = 4, Value = "5"},
                    new RecruitmentOfColonistDefinition() {Xp = 4830000, Level = 5, Value = "8"}
                },
            }
        };

        public static IPlayData SetupPlayData(int gameGoodsLevel)
        {
            var goods = new List<IGoods>();
            var goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)RaisingType.Player);
            goodsMock.Setup(d => d.Level).Returns(gameGoodsLevel);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)RaisingType.AntimatterCatcher);
            goodsMock.Setup(d => d.Level).Returns(0);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)RaisingType.BaseStation);
            goodsMock.Setup(d => d.Level).Returns(0);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)RaisingType.FuelRefinery);
            goodsMock.Setup(d => d.Level).Returns(0);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)RaisingType.LaunchTower);
            goodsMock.Setup(d => d.Level).Returns(0);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)RaisingType.RecruitmentOfColonist);
            goodsMock.Setup(d => d.Level).Returns(0);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)RaisingType.ResearchLaboratory);
            goodsMock.Setup(d => d.Level).Returns(0);
            goods.Add(goodsMock.Object);
            goodsMock = MockRepository.Create<IGoods>();
            goodsMock.Setup(d => d.BuildingType).Returns((int)RaisingType.ResourceObservatory);
            goodsMock.Setup(d => d.Level).Returns(0);
            goods.Add(goodsMock.Object);

            var configurationPlayData = SetupPlayerXp(0);
            Mock.Get(configurationPlayData).Setup(d => d.Goods).Returns(goods.ToArray);
            Mock.Get(configurationPlayData).Setup(d => d.Wallet).Returns(SetupResourceDataData(1000));

            return configurationPlayData;
        }

        public static IResourceData SetupResourceDataData(int money)
        {
            var resourceData = new ResourceData()
            {
                Stars = money,
                Colonist = money,
                HyperMetal = money,
                Minerals = money,
                Ore = money,
                Food = money,
                Fuel = money
            };

            return resourceData;
        }

        public static Player SetupPlayerXp(int xp)
        {
            var player = new Player();
            player.Xp = xp;

            return player;
        }
    }
}