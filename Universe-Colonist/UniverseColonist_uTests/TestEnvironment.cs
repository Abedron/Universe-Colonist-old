using Game.Buildings;
using Game.Services.Definitions;

namespace UniverseColonistTests
{
    public static class TestEnvironment
    {
        public static ILeveling[] BuildingDefinitions => new ILeveling[]
        {
            new BuildingDefinition() {Xp = 0, Level = 0},
            new BuildingDefinition() {Xp = 1100, Level = 1},
            new BuildingDefinition() {Xp = 1200, Level = 2},
            new BuildingDefinition() {Xp = 1300, Level = 3},
            new BuildingDefinition() {Xp = 1400, Level = 4},
            new BuildingDefinition() {Xp = 1600, Level = 5},
            new BuildingDefinition() {Xp = 1700, Level = 6}
        };
    }
}