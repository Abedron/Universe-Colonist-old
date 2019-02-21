using Game.Services.Definitions;

namespace Game.Services.Definitions
{
    public class GameDefinition: IRaiseDefinition
    {
        public int Xp { get; internal set; }
        public int Level { get; internal set; }
        public string Value { get; internal set; }
    }
}