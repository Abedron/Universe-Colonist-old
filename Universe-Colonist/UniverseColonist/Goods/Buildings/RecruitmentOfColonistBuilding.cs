using Game.Services.Definitions;

namespace Game.Goods.Buildings
{
    public class RecruitmentOfColonistBuilding : Raising
    {
        public RecruitmentOfColonistBuilding(int level, IRaiseDefinition[] raiseDefinition) : base(level, raiseDefinition)
        {
        }
    }
}