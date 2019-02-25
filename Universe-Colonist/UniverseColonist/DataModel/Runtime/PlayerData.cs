using Game.DataModel.Storage;
using Game.GameModel;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class PlayerData : Raising<PlayerDefinition, Player>
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }

        public PlayerData(PlayerDefinition[] definition, Player player):base(definition, player)
        {

        }
    }
}