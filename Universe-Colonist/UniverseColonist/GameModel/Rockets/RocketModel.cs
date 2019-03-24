using Game.Articles;
using Game.DataModel.Runtime;
using Game.Services.Definitions;
using System;
using System.Linq;

namespace Game.GameModel.Rockets
{
    public class RocketModel : ILevelUp
    {
        public RocketData Data { get; }

        public RocketModel(RocketData data)
        {
            Data = data;
        }

        public bool TryLevelUp(int baseStationLevel)
        {
            ILevelUpByBaseStationDefinition definition = Data.Definitions.LastOrDefault(d => d.BaseStationLevel <= baseStationLevel) ?? Data.Definitions[0];
            bool isRaisedLevel = definition.Level != Data.Level;
            Data.Level = definition.Level;

            return isRaisedLevel;
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
