using Game.Articles;
using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;
using System.Linq;

namespace Game.GameModel.Planets
{
    public class Planet
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

        public bool TryRaiseLevel(int playerLevel)
        {
            var definition = Definitions.LastOrDefault(d => d.BaseStationLevel <= playerLevel) ?? Definitions[0];
            bool isRaisedLevel = definition.Level != Data.Level;

            Data.Level = definition.Level;

            return isRaisedLevel;
        }
    }
}