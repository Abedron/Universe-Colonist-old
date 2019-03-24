namespace Game.Services.Definitions
{
    public interface ILevelUpByBaseStationDefinition : ILevelUpDefinition
    {
        int BaseStationLevel { get; }
    }
}