using Game.DataModel.Runtime;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class ResearchLaboratoryBuilding : StandardBuildingBase
    {
        public ResearchLaboratoryBuilding(BuildingDataBase<ILevelUpByBaseStationDefinition> data) : base(data)
        {
        }
    }
}
