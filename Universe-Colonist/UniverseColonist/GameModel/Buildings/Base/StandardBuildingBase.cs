using Game.DataModel.Runtime;
using Game.Services.Definitions;
using System.Linq;

namespace Game.GameModel.Buildings
{
    public class StandardBuildingBase : BuildingBase
    {
        public BuildingDataBase<ILevelUpByBaseStationDefinition> Data { get; }

        public StandardBuildingBase(BuildingDataBase<ILevelUpByBaseStationDefinition> data)
        {
            Data = data;
        }

        public override bool TryLevelUp(int baseStationLevel)
        {
            ILevelUpByBaseStationDefinition definition = Data.Definitions
                .LastOrDefault(d => d.BaseStationLevel <= baseStationLevel) ?? Data.Definitions[0];
            bool isRaisedLevel = definition.Level != Data.Level;
            Data.Level = definition.Level;

            return isRaisedLevel;
        }
    }
}
