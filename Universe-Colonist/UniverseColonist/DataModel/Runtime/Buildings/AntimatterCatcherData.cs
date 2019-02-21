using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class AntimatterCatcherData : BuildingDataBase<AntimatterCatcherDefinition, AntimatterCatcher>
    {
        public AntimatterCatcherData(AntimatterCatcherDefinition[] definition, AntimatterCatcher antimatterCatcher) : base(definition, antimatterCatcher)
        {
        }
    }
}
