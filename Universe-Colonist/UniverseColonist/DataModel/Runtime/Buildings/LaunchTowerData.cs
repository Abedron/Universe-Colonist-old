using Game.Services.Definitions;
using System.Linq;

namespace Game.DataModel.Runtime
{
    public class LaunchTowerData : BuildingDataBase
    {
        public LaunchTowerDefinition[] Definitions { get; }
        public LaunchTowerDefinition Definition => Definitions.FirstOrDefault(d => d.Level == Level) ?? Definitions[0];
        public LaunchTowerData(LaunchTowerDefinition[] definitions)
        {
            Definitions = definitions;
        }
    }
}