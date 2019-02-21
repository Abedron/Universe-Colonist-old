namespace Game.Data.Runtime
{
    public class PlayData
    {
        public PlayerData PlayerData { get; } = new PlayerData();
        public BuildingsData BuildingsData { get; } = new BuildingsData();
        public CashData Cash { get; } = new CashData();

        // Items
        public PlanetsData Planets { get; } = new PlanetsData();
        public RocketData[] Rockets { get; } = new RocketData[0];
    }
}
