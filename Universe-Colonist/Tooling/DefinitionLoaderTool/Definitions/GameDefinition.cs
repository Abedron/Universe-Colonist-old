using Game.Services.Definitions;

namespace Game.Services.Definitions
{
    public class GameDefinition: IRaiseDefinition
    {
        public int Xp { get; set; }
        public int Level { get; set; }
    }
}