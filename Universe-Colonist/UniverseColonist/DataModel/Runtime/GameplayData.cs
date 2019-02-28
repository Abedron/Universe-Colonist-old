using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class GameplayData
    {
        public PlayerData PlayerData { get; } = new PlayerData();
        public BuildingsData BuildingsData { get; } = new BuildingsData();
        public ResourceData Resource { get; } = new ResourceData();

        // Items
        public PlanetsData Planets { get; } = new PlanetsData();
        public RocketData Rockets { get; } = new RocketData();
    }
}
