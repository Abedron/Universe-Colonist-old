using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class MercuryPlanet : PlanetBase<MercuryData, MercuryDefinition, Mercury>
    {
        public MercuryPlanet(MercuryData data, MercuryDefinition[] definitions, Mercury storage) : base(data, definitions, storage)
        {

        }
    }
}
