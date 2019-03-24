using Game.DataModel.Storage;
using Game.Services.Definitions;
using System.Linq;

namespace Game.DataModel.Runtime
{
    public class FuelRefineryData : BuildingDataBase
    {
        public FuelRefineryDefinition[] Definitions { get; }
        public FuelRefineryDefinition Definition => Definitions.FirstOrDefault(d => d.Level == Level) ?? Definitions[0];
        public FuelRefineryData(FuelRefineryDefinition[] definitions)
        {
            Definitions = definitions;
        }
    }
}
