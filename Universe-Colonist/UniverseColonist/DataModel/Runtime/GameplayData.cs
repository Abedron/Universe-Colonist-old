using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.DataModel.Runtime
{
    public class GameplayData
    {
        public PlayerData PlayerData { get; }
        public BuildingsData BuildingsData { get; }
        public CashData Cash { get; } = new CashData();

        // Items
        public PlanetsData Planets { get; } = new PlanetsData();
        public RocketData[] Rockets { get; } = new RocketData[0];

        public GameplayData(AllDefinitions allDefinitions, GameplayStorage play)
        {
            PlayerData = new PlayerData(allDefinitions.Player, play.Player);
            BuildingsData = new BuildingsData(allDefinitions.Buildings, play.Buildings);
        }
    }
}
