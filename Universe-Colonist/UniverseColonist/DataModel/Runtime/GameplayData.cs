using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class GameplayData
    {
        public PlayerData PlayerData { get; }
        public BuildingsData BuildingsData { get; }
        public ResourceData Resource { get; } = new ResourceData();

        // Items
        public PlanetsData Planets { get; } = new PlanetsData();
        public RocketData[] Rockets { get; } = new RocketData[0];

        public GameplayData()
        {
            PlayerData = new PlayerData();
            BuildingsData = new BuildingsData();
        }
    }
}
