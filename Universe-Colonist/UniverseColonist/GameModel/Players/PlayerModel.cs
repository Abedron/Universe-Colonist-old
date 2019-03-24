using Game.DataModel.Runtime;

namespace Game.GameModel.Players
{
    public class PlayerModel : ILevelUp
    {
        public PlayerData Data { get; }

        private LevelUpModel LevelUp { get; }

        public PlayerModel(PlayerData data)
        {
            Data = data;
            LevelUp = new LevelUpModel(data);
        }

        public bool TryLevelUp(int xp)
        {
            bool isLevelUp = LevelUp.TryLevelUp(Data.Definitions, xp);
            return isLevelUp;
        }
    }
}
