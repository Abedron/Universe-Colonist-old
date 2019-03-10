using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Players
{
    public class PlayerModel
    {
        public PlayerData Data { get; }

        public PlayerModel(PlayerData data)
        { 
            Data = data;
        }
    }
}
