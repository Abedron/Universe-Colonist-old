namespace Game.Buildings
{
    public interface ILeveling
    {
        int Xp { get; }
        int Level { get; }
        string Value { get; }
    }
}