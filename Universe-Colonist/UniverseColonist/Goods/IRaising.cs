using Game.Configurations;

namespace Game.Goods
{
    public interface IRaising
    {
        bool Enabled { get; }
        bool IsBuilt { get; }
        int Level { get; }
        bool TryRaiseLevel(int xp);
    }
}