using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Planets
{
    public class MarsPlanet : PlanetBase<MarsData, MarsDefinition, Mars>
    {
        public MarsPlanet(MarsData data, MarsDefinition[] definitions, Mars storage) : base(data, definitions, storage)
        {

        }
    }
}