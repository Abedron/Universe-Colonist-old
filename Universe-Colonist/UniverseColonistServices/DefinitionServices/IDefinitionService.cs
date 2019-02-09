namespace Game.Services
{
    public interface IDefinitionService
    {
        AllDefinitions AllDefinitions { get; }
        void LoadAllDefinitions();
    }
}