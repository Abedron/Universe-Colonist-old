using Game.Services.Definitions;
using System.Linq;

namespace Game.DataModel.Runtime
{
    public class ResearchLaboratoryData : BuildingDataBase
    {
        public ResearchLaboratoryDefinition[] Definitions { get; }
        public ResearchLaboratoryDefinition Definition => Definitions.FirstOrDefault(d => d.Level == Level) ?? Definitions[0];
        public ResearchLaboratoryData(ResearchLaboratoryDefinition[] definitions)
        {
            Definitions = definitions;
        }
    }
}