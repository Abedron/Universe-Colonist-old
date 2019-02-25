using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class AntimatterCatcherBuilding : Raising<AntimatterCatcherDefinition, AntimatterCatcher>
    {
        public AntimatterCatcherBuilding(AntimatterCatcherDefinition[] definition, AntimatterCatcher antimatterCatcher) : base(definition, antimatterCatcher)
        {
        }
    }
}