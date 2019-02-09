namespace Game.Services.Definitions.Buildings
{
    public class BaseStationDefinition : IRaiseDefinition
    {
        public int Xp { get; internal set; }
        public int Level { get; internal set; }
        public string Value { get; internal set; }
    }
}