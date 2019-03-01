using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Players
{
    public class PlayerModel : RaisingBase<PlayerDefinition, Player>
    {
        public PlayerData Data { get; }

        public PlayerModel(PlayerData data, PlayerDefinition[] definitions, Player player) : base(definitions, player)
        {
            Data = data;
        }
    }
}
