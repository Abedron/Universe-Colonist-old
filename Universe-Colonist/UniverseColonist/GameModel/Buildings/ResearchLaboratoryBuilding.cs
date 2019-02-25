using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModels.Buildings
{
    public class ResearchLaboratoryBuilding : BuildingBase<ResearchLaboratoryData, ResearchLaboratoryDefinition, ResearchLaboratory>
    {
        public ResearchLaboratoryBuilding(ResearchLaboratoryData data, ResearchLaboratoryDefinition[] definitions, ResearchLaboratory researchLaboratory) : base(data, definitions, researchLaboratory)
        {
        }
    }
}
