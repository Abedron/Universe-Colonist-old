using Game.Articles;
using Game.DataModel.Runtime;
using System;

namespace Game.GameModel
{
    public class RocketModel : ILevelUp
    {
        public RocketData Data { get; }

        private LevelUpModel LevelUp { get; }

        public RocketModel(RocketData data)
        {
            Data = data;
            LevelUp = new LevelUpModel(data);
        }

        public bool TryLevelUp(int baseStationLevel)
        {
            bool isLevelUp = LevelUp.TryLevelUp(Data.Definitions, baseStationLevel);
            return isLevelUp;
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
