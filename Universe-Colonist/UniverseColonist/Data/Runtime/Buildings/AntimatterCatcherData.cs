using Game.Data.Storage;
using Game.Services.Definitions;

namespace Game.Data.Runtime
{
    public class AntimatterCatcherData : BuildingDataBase<AntimatterCatcherDefinition, AntimatterCatcher>
    {
        public AntimatterCatcherData(AntimatterCatcherDefinition[] definition, AntimatterCatcher antimatterCatcher) : base(definition, antimatterCatcher)
        {
        }
    }
}
