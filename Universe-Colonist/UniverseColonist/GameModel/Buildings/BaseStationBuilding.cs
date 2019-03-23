using Game.DataModel.Runtime;
using Game.Services.Definitions;
using System.Linq;

namespace Game.GameModel.Buildings
{
    public class BaseStationBuilding : BuildingBase
    {
        public BaseStationData<ILevelUpByPlayerDefinition> Data { get; }

        public BaseStationBuilding(BaseStationData<ILevelUpByPlayerDefinition> data)
        {
            Data = data;
        }

        public override bool TryLevelUp(int playerLevel)
        {
            ILevelUpByPlayerDefinition definition = Data.Definitions
                    .LastOrDefault(d => d.AccessFromPlayerLevel <= playerLevel) ?? Data.Definitions[0];
            bool isRaisedLevel = definition.Level != Data.Level;
            Data.Level = definition.Level;

            return isRaisedLevel;
        }
    }
}
