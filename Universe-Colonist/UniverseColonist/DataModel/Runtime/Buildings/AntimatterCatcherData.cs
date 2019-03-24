using Game.Services.Definitions;
using System.Linq;

namespace Game.DataModel.Runtime
{
    public class AntimatterCatcherData : BuildingDataBase
    {
        public int CurrentHarvesters { get; set; }
        public AntimatterCatcherDefinition[] Definitions { get; }
        public AntimatterCatcherDefinition Definition => Definitions.FirstOrDefault(d => d.Level == Level) ?? Definitions[0];
        public AntimatterCatcherData(AntimatterCatcherDefinition[] definitions)
        {
            Definitions = definitions;
        }
    }
}
