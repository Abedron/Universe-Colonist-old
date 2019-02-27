using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class FuelRefineryBuilding : BuildingBase<FuelRefineryData, FuelRefineryDefinition, FuelRefinery>
    {
        public FuelRefineryBuilding(FuelRefineryData data, FuelRefineryDefinition[] definitions, FuelRefinery fuelRefinery) : base(data, definitions, fuelRefinery)
        {
        }
    }
}
