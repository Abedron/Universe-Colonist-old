namespace Game.Services.Definitions
{
    public class BaseStationDefinition : ILevelUpByPlayerDefinition
    {
        public int Level { get; internal set; }
        public int AccessFromPlayerLevel { get; internal set; }
    }
}