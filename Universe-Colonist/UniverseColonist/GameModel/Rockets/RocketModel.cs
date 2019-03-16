using Game.Articles;
using Game.DataModel.Runtime;
using Game.Services.Definitions;
using System;
using System.Linq;

namespace Game.GameModel.Rockets
{
    public class RocketModel
    {
        public RocketData Data { get; }
        public RocketDefinitionBase[] Definitions { get; }

        private RocketDefinitionBase Definition => Definitions.FirstOrDefault(d => d.Level == Data.Level) ?? Definitions[0];

        public RocketModel(RocketData data, RocketDefinitionBase[] definitions)
        {
            Data = data;
            Definitions = definitions;
        }

        public bool TryRaiseLevel(CashData cashData)
        {

            return false;
        }

        public bool TrySendTo(PlanetData planetData, DateTime startTime)
        {
            if (!Data.IsActivated)
                return false;

            if (Data.IsFlying(startTime))
                return false;

            Data.PlanetTarget = planetData.PlanetType;
            Data.StartTime = startTime;
            Data.EndTime = startTime.AddSeconds(planetData.Definition.JourneyTime);

            return true;
        }

        public void BoostFinish(DateTime currentTime)
        {
            if (!Data.IsFlying(currentTime))
                return;

            Data.PlanetTarget = PlanetType.None;
            Data.StartTime = new DateTime();
            Data.EndTime = Data.StartTime;
        }
    }
}
