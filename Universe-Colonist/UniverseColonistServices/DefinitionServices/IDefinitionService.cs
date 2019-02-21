using Game.Services.Definitions;

namespace Game.Services
{
    public interface IDefinitionService
    {
        AllDefinitions AllDefinitions { get; }
        void LoadAllDefinitions();
    }
}