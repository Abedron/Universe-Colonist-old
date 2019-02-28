using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Rockets
{
    public class BlueLightRocket : RocketBase<BlueLightData, BlueLightDefinition, BlueLight>
    {
        public BlueLightRocket(BlueLightData data, BlueLightDefinition[] definitions, BlueLight storage) : base(data, definitions, storage)
        {
        }
    }
}
