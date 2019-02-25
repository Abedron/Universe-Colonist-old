namespace Game.Services.Definitions
{
    public class PlayerDefinition : IRaiseDefinition
    {
        public int Xp { get; internal set; }
        public int Level { get; internal set; }
    }
}