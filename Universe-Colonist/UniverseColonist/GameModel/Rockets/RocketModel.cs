using Game.Articles;
using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Rockets
{
    public class RocketModel
    {
        public RocketData Data { get; }

        public RocketModel(RocketData data, RocketDefinitions rocketDefinitions, DataModel.Storage.Rockets storage)
        {
            Data = data;
        }

        public void SendRocketTo(RocketTarget rocketTarget)
        {
            if (Data.Rockets)
            {

            }
        }
    }
}
