using Game.Articles;
using Game.Services.Definitions;
using System;
using System.Linq;

namespace Game.DataModel.Runtime
{
    public class RocketData : ILevelUpData
    {
        public static RocketData NullRocket => new RocketData(RocketType.None, new RocketDefinitionBase[0], 0);

        public int Id { get; }
        public RocketType RocketType { get; }
        public PlanetType PlanetTarget { get; set; }
        public RocketState State { get; set; }
        public bool IsActivated { get; set; }
        public int Level { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public RocketDefinitionBase[] Definitions { get; }
        public RocketDefinitionBase Definition => Definitions.FirstOrDefault(d => d.Level == Level) ?? Definitions[0];

        public RocketData(RocketType rocketType, RocketDefinitionBase[] definitions, int id)
        {
            RocketType = rocketType;
            Definitions = definitions;
            Id = id;
        }

        public bool IsFlying(DateTime currentTime)
        {
            return EndTime > currentTime;
        }
    }

}