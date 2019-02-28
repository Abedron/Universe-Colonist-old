using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Rockets
{
    public class NeoVRocket : RocketBase<NeoVData, NeoVDefinition, NeoV>
    {
        public NeoVRocket(NeoVData data, NeoVDefinition[] definitions, NeoV storage) : base(data, definitions, storage)
        {
        }
    }
}
