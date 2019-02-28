using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Planets
{
    public class AntuelPlanet : PlanetBase<AntuelData, AntuelDefinition, Antuel>
    {
        public AntuelPlanet(AntuelData data, AntuelDefinition[] definition, Antuel storage) : base(data, definition, storage)
        {

        }
    }
}