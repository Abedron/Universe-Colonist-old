using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class ResearchLaboratoryBuilding : Raising
    {
        public ResearchLaboratoryBuilding(int level, IRaiseDefinition[] raiseDefinition) : base(level, raiseDefinition)
        {
        }
    }
}