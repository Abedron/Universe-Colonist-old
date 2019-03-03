using Game.Articles;

namespace Game.DataModel.Storage
{
    public class RocketBase : IRaiseStorage
    {
        public static RocketBase NullRocket { get; } = new RocketBase(RocketType.None, RocketTarget.None);

        public RocketType RocketType { get; set; }
        public RocketTarget RocketTarget { get; }
        public int Level { get; set; }

        public RocketBase(RocketType rocketType, RocketTarget rocketTarget)
        {
            RocketType = rocketType;
            RocketTarget = rocketTarget;
        }
    }
}