namespace Game.Services.Definitions
{
    public class PlayerDefinition : IRaisingDefinition
    {
        public int Xp { get; internal set; }
        public int Level { get; internal set; }
    }
}