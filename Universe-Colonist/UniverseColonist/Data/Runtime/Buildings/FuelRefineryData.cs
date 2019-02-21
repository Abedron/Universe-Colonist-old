using Game.Data.Storage;
using Game.Services.Definitions;

namespace Game.Data.Runtime
{
    public class FuelRefineryData : BuildingDataBase<FuelRefineryDefinition, FuelRefinery>
    {
        public FuelRefineryData(FuelRefineryDefinition[] definition, FuelRefinery fuelRefinery) : base(definition, fuelRefinery)
        {
        }
    }
}
