using Game.Articles;
using Game.DataModel.Runtime;
using Game.Services.Definitions;
using Moq;

namespace UniverseColonistTests
{
    public static class TestEnvironment
    {
        private static MockRepository MockRepository { get; } = new MockRepository(MockBehavior.Default) { DefaultValue = DefaultValue.Mock };

        public static BaseStationDefinition[] BaseStationDefinitionsFake { get; } =
        {
            new BaseStationDefinition{AccessFromPlayerLevel = 1,  Level = 1},
            new BaseStationDefinition{AccessFromPlayerLevel = 3,  Level = 2},
            new BaseStationDefinition{AccessFromPlayerLevel = 5,  Level = 3},
            new BaseStationDefinition{AccessFromPlayerLevel = 8,  Level = 4},
            new BaseStationDefinition{AccessFromPlayerLevel = 13, Level = 5},
            new BaseStationDefinition{AccessFromPlayerLevel = 21, Level = 6},
            new BaseStationDefinition{AccessFromPlayerLevel = 34, Level = 7},
            new BaseStationDefinition{AccessFromPlayerLevel = 55, Level = 8},
            new BaseStationDefinition{AccessFromPlayerLevel = 89, Level = 9}
        };

        public static LaunchTowerDefinition[] LaunchTowerDefinitionsFake { get; } =
        {
            new LaunchTowerDefinition() { BaseStationLevel = 1, Level = 1, Capacity = 1},
            new LaunchTowerDefinition() { BaseStationLevel = 2, Level = 2, Capacity = 2},
            new LaunchTowerDefinition() { BaseStationLevel = 3, Level = 3, Capacity = 3},
            new LaunchTowerDefinition() { BaseStationLevel = 4, Level = 4, Capacity = 4},
            new LaunchTowerDefinition() { BaseStationLevel = 5, Level = 5, Capacity = 5},
            new LaunchTowerDefinition() { BaseStationLevel = 6, Level = 6, Capacity = 8},
            new LaunchTowerDefinition() { BaseStationLevel = 7, Level = 7, Capacity = 13},
            new LaunchTowerDefinition() { BaseStationLevel = 8, Level = 8, Capacity = 21},
            new LaunchTowerDefinition() { BaseStationLevel = 9, Level = 9, Capacity = 34}
        };

        public static AllDefinitions AllDefinitionsFake { get; } = new AllDefinitions()
        {
            Version = "2019.41.1472",
            Player = new[]
            {
                new PlayerDefinition() {Xp = 1100, Level = 1},
                new PlayerDefinition() {Xp = 1200, Level = 2},
                new PlayerDefinition() {Xp = 1300, Level = 3},
                new PlayerDefinition() {Xp = 1400, Level = 4},
                new PlayerDefinition() {Xp = 1600, Level = 5},
                new PlayerDefinition() {Xp = 1700, Level = 6},
                new PlayerDefinition() {Xp = 1900, Level = 7},
                new PlayerDefinition() {Xp = 2100, Level = 8},
                new PlayerDefinition() {Xp = 2300, Level = 9},
                new PlayerDefinition() {Xp = 2500, Level = 10}
            },
            Rockets =
            {
                AccessRocketsDefinitions = new[]
                {
                    new AccessRocketsDefinition()
                    {
                        AccessFromLevel = 1,
                        RocketType = 1,
                        MaxCount = 2
                    },
                    new AccessRocketsDefinition()
                    {
                        AccessFromLevel = 3,
                        RocketType = 2,
                        MaxCount = 2
                    }
                },
                BlueLight = new[]
                {
                    new  RocketDefinitionBase()
                    {
                        BaseStationLevel = 1,
                        Level = 1,
                        Cargo = 1,
                        Colonist = 100,
                        Coins = 0,
                        Stars = 0,
                        HyperMetal = 0,
                        Fuel = 0,
                        Ore = 0,
                        Minerals = 0,
                        Food = 0
                    }
                },
                NeoV = new[]
                {
                    new  RocketDefinitionBase()
                    {
                        BaseStationLevel = 1,
                        Level = 1,
                        Cargo = 1,
                        Colonist = 100,
                        Coins = 0,
                        Stars = 0,
                        HyperMetal = 0,
                        Fuel = 0,
                        Ore = 0,
                        Minerals = 0,
                        Food = 0
                    }
                }
            },
            Buildings =
            {
                BaseStation = BaseStationDefinitionsFake,
               /* AntimatterCatcher = new []
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
                    new FuelRefineryDefinition() {Xp = 1600, Level = 1, RocketSpeed = 0.8f},
                    new FuelRefineryDefinition() {Xp = 2100, Level = 2, RocketSpeed = 1.2f},
                    new FuelRefineryDefinition() {Xp = 2500, Level = 3, RocketSpeed = 2},
                    new FuelRefineryDefinition() {Xp = 3400, Level = 4, RocketSpeed = 3.2f},
                    new FuelRefineryDefinition() {Xp = 7400, Level = 5, RocketSpeed = 5.2f},
                    new FuelRefineryDefinition() {Xp = 25500, Level = 6, RocketSpeed = 8.4f},
                    new FuelRefineryDefinition() {Xp = 189000, Level = 7, RocketSpeed = 13.6f},
                    new FuelRefineryDefinition() {Xp = 4830000, Level = 8, RocketSpeed = 22}
                },
                LaunchTower = new []
                {
                    new LaunchTowerDefinition() {Xp = 1100, Level = 1, FlyingRocketCount = 1},
                    new LaunchTowerDefinition() {Xp = 1300, Level = 2, FlyingRocketCount = 2},
                    new LaunchTowerDefinition() {Xp = 1600, Level = 3, FlyingRocketCount = 3},
                    new LaunchTowerDefinition() {Xp = 2100, Level = 4, FlyingRocketCount = 4},
                    new LaunchTowerDefinition() {Xp = 3400, Level = 5, FlyingRocketCount = 5},
                    new LaunchTowerDefinition() {Xp = 7400, Level = 6, FlyingRocketCount = 8},
                    new LaunchTowerDefinition() {Xp = 25500, Level = 7, FlyingRocketCount = 13},
                    new LaunchTowerDefinition() {Xp = 189000, Level = 8, FlyingRocketCount = 21},
                    new LaunchTowerDefinition() {Xp = 4830000, Level = 9, FlyingRocketCount = 34}
                },
                ResearchLaboratory = new []
                {
                    new ResearchLaboratoryDefinition() {Xp = 7400, Level = 1}
                },
                ResourceObservatory = new []
                {
                    new ResourceObservatoryDefinition() {Xp = 1100, Level = 1, Planets = "Mars,Venus"},
                    new ResourceObservatoryDefinition() {Xp = 1300, Level = 2, Planets = "Mercury,Vesta"},
                    new ResourceObservatoryDefinition() {Xp = 1600, Level = 3, Planets = "Ceres,Asteroids"},
                    new ResourceObservatoryDefinition() {Xp = 2100, Level = 4, Planets = "Jupiter,Antuel"}
                },
                RecruitmentOfColonist = new []
                {
                    new RecruitmentOfColonistDefinition() {Xp = 1100, Level = 1, RecruitmentPerMinute = 1},
                    new RecruitmentOfColonistDefinition() {Xp = 1600, Level = 2, RecruitmentPerMinute = 2},
                    new RecruitmentOfColonistDefinition() {Xp = 7400, Level = 3, RecruitmentPerMinute = 3},
                    new RecruitmentOfColonistDefinition() {Xp = 189000, Level = 4, RecruitmentPerMinute = 5},
                    new RecruitmentOfColonistDefinition() {Xp = 4830000, Level = 5, RecruitmentPerMinute = 8}
                },*/
            },

            Planets =
            {
                Mercury = new []{new PlanetDefinition() {BaseStationLevel = 1, Level = 1, CargoMultiplier = 10, JourneyTime = 10, Ore = 10}},
                Venus = new []{new PlanetDefinition() {BaseStationLevel = 1, Level = 1, CargoMultiplier = 10, JourneyTime = 10, HyperMetal = 10}},
                Mars = new []{new PlanetDefinition() {BaseStationLevel = 1, Level = 1, CargoMultiplier = 10, JourneyTime = 10, Minerals = 10}},
                Asteroids = new []{new PlanetDefinition() {BaseStationLevel = 1, Level = 1, CargoMultiplier = 10, JourneyTime = 10, Minerals = 10}},
                Jupiter = new []{new PlanetDefinition() {BaseStationLevel = 1, Level = 1, CargoMultiplier = 10, JourneyTime = 10, Fuel = 10}},
                Antuel = new []{new PlanetDefinition() {BaseStationLevel = 1, Level = 1, CargoMultiplier = 30, JourneyTime = 20, HyperMetal = 10},}
            }
        };





        public static PlanetData MercuryPlanetData { get; } = new PlanetData(PlanetType.Mercury, AllDefinitionsFake.Planets.Mercury)
        {
            IsActivated = true,
            Colonist = 1,
            Level = 1
        };

        public static LaunchTowerData<ILevelUpByBaseStationDefinition> LaunchTowerData { get; } = new LaunchTowerData<ILevelUpByBaseStationDefinition>(LaunchTowerDefinitionsFake)
        {
            IsActivate = true,
            Level = 1
        };

        public static BaseStationData<ILevelUpByPlayerDefinition> BaseStationData { get; } = new BaseStationData<ILevelUpByPlayerDefinition>(BaseStationDefinitionsFake)
        {
            IsActivate = true,
            Level = 1
        };

        public static RocketData NeoVRocketData = new RocketData(RocketType.NeoV, AllDefinitionsFake.Rockets.NeoV)
        {
            Level = 1,
            IsActivated = true
        };

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
    }
}