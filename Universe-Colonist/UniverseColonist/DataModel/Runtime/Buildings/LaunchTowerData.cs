using Game.GameModel.Rockets;
using System.Collections.Generic;

namespace Game.DataModel.Runtime
{
    public class LaunchTowerData : BuildingDataBase
    {
        public IList<RocketData> FlyingRockets = new List<RocketData>();
    }
}