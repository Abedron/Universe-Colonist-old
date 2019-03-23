namespace Game.Services.Definitions
{
    public interface ILevelUpByPlayerDefinition : ILevelUpDefinition
    {
        int AccessFromPlayerLevel { get; }
    }
}