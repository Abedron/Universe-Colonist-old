using System.Collections.Generic;
using System.Linq;
using Game.Buildings;
using Game.Configurations;

namespace Game
{
    public class GameModel
    {
        public int Xp { get; set; }
        public Dictionary<BuildingType, ILeveling> Buildings { get; set; } = new Dictionary<BuildingType, ILeveling>();

        public int LevelBuilding(BuildingType buildingType)
        {
            return Buildings.FirstOrDefault(d => d.Key == buildingType).Value.Level;
        }

        public GameModel()
        {
            InitBuildings();
        }

        private void InitBuildings()
        {
            
        }
    }
}