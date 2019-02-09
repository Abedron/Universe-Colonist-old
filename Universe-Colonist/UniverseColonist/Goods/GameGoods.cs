using Game.Services.Definitions;

namespace Game.Goods
{
    public class GameGoods : Raising
    {
        public int Xp { get; private set; }

        public GameGoods(int level, IRaiseDefinition[] buildingDefinition) : base(level, buildingDefinition)
        {
        }

        public override bool TryRaiseLevel(int xp)
        {
            Xp = xp;
            return base.TryRaiseLevel(xp);
        }
    }
}