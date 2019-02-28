namespace Game.DataModel.Runtime
{
    public class PlanetsData
    {
        public AntuelData Antuel { get; } = new AntuelData();
        public AsteroidsData Asteroids { get; } = new AsteroidsData();
        public JupiterData Jupiter { get; } = new JupiterData();
        public MarsData Mars { get; } = new MarsData();
        public MercuryData Mercury { get; } = new MercuryData();
        public VenusData Venus { get; } = new VenusData();
    }
}