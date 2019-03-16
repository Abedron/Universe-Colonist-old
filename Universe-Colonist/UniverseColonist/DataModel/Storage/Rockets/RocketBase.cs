using Game.Articles;

namespace Game.DataModel.Storage
{
    public class RocketBase : IRaiseStorage
    {
        public static RocketBase NullRocket { get; } = new RocketBase(RocketType.None, PlanetType.None);

        public int Id { get; set; }
        public RocketType RocketType { get; set; }
        public PlanetType RocketTarget { get; }
        public int Level { get; set; }

        public RocketBase(RocketType rocketType, PlanetType rocketTarget)
        {
            RocketType = rocketType;
            RocketTarget = rocketTarget;
        }
    }
}