using Game.Services.Definitions;

namespace Game.Services
{
    public class GameDefinition: IRaiseDefinition
    {
        public int Xp { get; internal set; }
        public int Level { get; internal set; }
        public string Value { get; internal set; }
    }
}