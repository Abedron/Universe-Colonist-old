using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Planets
{
    public class VenusPlanet : PlanetBase<VenusData, VenusDefinition, Venus>
    {
        public VenusPlanet(VenusData data, VenusDefinition[] definitions, Venus storage) : base(data, definitions, storage)
        {

        }
    }
}