using Game.Articles;
using System;

namespace Game.DataModel.Runtime
{
    public class RocketData
    {
        public static RocketData NullRocket { get; } = new RocketData(RocketType.None);

        public int Id { get; set; }
        public RocketType RocketType { get; }
        public PlanetType PlanetTarget { get; set; }
        public bool IsActivated { get; set; }
        public int Level { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public RocketData(RocketType rocketType)
        {
            RocketType = rocketType;
        }

        public bool IsFlying(DateTime currentTime)
        {
            return EndTime > currentTime;
        }
    }

}