using Game.DataModel.Runtime;
using System.Linq;

namespace Game.GameModel.Players
{
    public class PlayerModel : ILevelUp
    {
        public PlayerData Data { get; }

        public PlayerModel(PlayerData data)
        { 
            Data = data;
        }

        public bool TryLevelUp(int xp)
        {
            var definition = Data.Definitions.LastOrDefault(d => d.Xp <= xp) ?? Data.Definitions[0];
            bool isLevelUp = definition.Level != Data.Level;

            Data.Level = definition.Level;

            return isLevelUp;
        }
    }
}
