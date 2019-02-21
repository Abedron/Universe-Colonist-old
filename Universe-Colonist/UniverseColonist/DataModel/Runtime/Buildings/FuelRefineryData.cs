using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class FuelRefineryData : BuildingDataBase<FuelRefineryDefinition, FuelRefinery>
    {
        public FuelRefineryData(FuelRefineryDefinition[] definition, FuelRefinery fuelRefinery) : base(definition, fuelRefinery)
        {
        }
    }
}
