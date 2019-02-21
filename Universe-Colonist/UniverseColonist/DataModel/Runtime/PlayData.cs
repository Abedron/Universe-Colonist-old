using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class PlayData
    {
        public PlayerData PlayerData { get; } = new PlayerData();
        public BuildingsData BuildingsData { get; }
        public CashData Cash { get; } = new CashData();

        // Items
        public PlanetsData Planets { get; } = new PlanetsData();
        public RocketData[] Rockets { get; } = new RocketData[0];

        public PlayData(AllDefinitions allDefinitions, GameplayStorage play)
        {
            BuildingsData = new BuildingsData(allDefinitions.Buildings, play.Buildings);
        }
    }
}
