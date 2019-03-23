namespace Game.Services.Definitions
{
    public class PlayerDefinition : ILevelUpDefinition
    {
        public int Xp { get; set; }
        public int Level { get; set; }
    }
}