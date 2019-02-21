using Game.Data.Storage;
using Game.Services.Definitions;

namespace Game.Data.Runtime
{
    public class ResearchLaboratoryData : BuildingDataBase<ResearchLaboratoryDefinition, ResearchLaboratory>
    {
        public ResearchLaboratoryData(ResearchLaboratoryDefinition[] definition, ResearchLaboratory researchLaboratory) : base(definition, researchLaboratory)
        {
        }
    }
}