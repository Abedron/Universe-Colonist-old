using System.Collections.Generic;
using Game.Buildings;
using Game.Configurations;

namespace Game
{
    public class GameModel
    {
        public int Xp { get; set; }
        public Dictionary<BuildingType, IBuilding> Buildings { get; set; } = new Dictionary<BuildingType, IBuilding>();

        //private void BaseStationLevel
    }
}