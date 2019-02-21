using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class ResearchLaboratoryData : BuildingDataBase<ResearchLaboratoryDefinition, ResearchLaboratory>
    {
        public ResearchLaboratoryData(ResearchLaboratoryDefinition[] definition, ResearchLaboratory researchLaboratory) : base(definition, researchLaboratory)
        {
        }
    }
}