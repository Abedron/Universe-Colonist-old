using Game.Services.Definitions;

namespace Game.Goods
{
    public class PlayerGoods : Raising
    {
        public int Xp { get; internal set; }

        public PlayerGoods(int level, IRaiseDefinition[] raiseDefinition) : base(level, raiseDefinition)
        {
            IsBuilt = true;
        }
    }
}