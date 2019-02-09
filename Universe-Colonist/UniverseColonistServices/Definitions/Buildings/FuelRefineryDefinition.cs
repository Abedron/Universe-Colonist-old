namespace Game.Services.Definitions.Buildings
{
    public class FuelRefineryDefinition : IRaiseDefinition
    {
        public int Xp { get; internal set; }
        public int Level { get; internal set; }
        public string Value { get; internal set; }
    }
}