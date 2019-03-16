using Game.DataModel.Runtime;
using Game.Services.Definitions;
using System.Linq;

namespace Game.GameModel.Buildings
{
    public class LaunchTowerBuilding //: BuildingBase<LaunchTowerData, LaunchTowerDefinition, LaunchTower>
    {
        public LaunchTowerData Data { get; }
        public LaunchTowerDefinition[] Definitions { get; }

        private LaunchTowerDefinition Definition => Definitions.FirstOrDefault(d => d.Level == Data.Level) ?? Definitions[0];

        public LaunchTowerBuilding(LaunchTowerData data, LaunchTowerDefinition[] definitions)
        {
            Data = data;
            Definitions = definitions;
        }

        public bool TryRaiseLevel(int baseStationLevel)
        {
            var definition = Definitions.LastOrDefault(d => d.BaseStationLevel <= baseStationLevel) ?? Definitions[0];
            bool isRaisedLevel = definition.Level != Data.Level;

            Data.Level = definition.Level;

            return isRaisedLevel;
        }

        public bool TryIncreaseSlots()
        {

            return false;
        }
    }
}
