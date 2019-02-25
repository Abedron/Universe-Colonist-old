using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModels.Buildings
{
    public class AntimatterCatcherBuilding: BuildingBase<AntimatterCatcherData, AntimatterCatcherDefinition, AntimatterCatcher>
    {
        public AntimatterCatcherBuilding(AntimatterCatcherData data, AntimatterCatcherDefinition[] definition, AntimatterCatcher antimatterCatcher) : base(data, definition, antimatterCatcher)
        {
        }
    }
}
