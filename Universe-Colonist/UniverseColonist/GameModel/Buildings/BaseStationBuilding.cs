using Game.DataModel.Runtime;
using Game.Services.Definitions;
using System.Linq;

namespace Game.GameModel.Buildings
{
    public class BaseStationBuilding //: BuildingBase<BaseStationData, BaseStationDefinition, BaseStation>
    {
        public BaseStationData Data { get; }
        public BaseStationDefinition[] Definitions { get; }

        public BaseStationBuilding(BaseStationData data, BaseStationDefinition[] definitions)
        {
            Data = data;
            Definitions = definitions;
        }

        public bool TryRaiseLevel(int playerLevel)
        {
            var definition = Definitions.LastOrDefault(d => d.AccessFromLevel <= playerLevel) ?? Definitions[0];
            bool isRaisedLevel = definition.Level != Data.Level;

            Data.Level = definition.Level;

            return isRaisedLevel;
        }
    }
}
