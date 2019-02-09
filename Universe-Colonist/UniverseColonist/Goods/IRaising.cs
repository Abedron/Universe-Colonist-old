namespace Game.Goods
{
    public interface IRaising
    {
        int Level { get; }
        bool TryRaiseLevel(int xp);
    }
}