using Game.Articles;
using Game.DataModel.Runtime;
using Game.Services.Definitions;
using System.Linq;

namespace Game.GameModel.Planets
{
    public class Planet : ILevelUp
    {
        public PlanetData Data { get; }
        public PlanetDefinition[] Definitions { get; }
        public PlanetType PlanetType { get; }

        public Planet(PlanetData data, PlanetDefinition[] definitions, PlanetType planetType)
        {
            Data = data;
            Definitions = definitions;
            PlanetType = planetType;
        }

        public bool TryLevelUp(int baseStationLevel)
        {
            var definition = Definitions.LastOrDefault(d => d.BaseStationLevel <= baseStationLevel) ?? Definitions[0];
            bool isLevelUp = definition.Level != Data.Level;

            Data.Level = definition.Level;

            return isLevelUp;
        }
    }
}