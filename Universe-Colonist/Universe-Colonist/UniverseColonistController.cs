using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Buildings;
using Game.Configurations.Definitions;

namespace Game
{
    public class UniverseColonistController
    {
        public int Xp => universeColonistModel.Xp;

        private UniverseColonistModel universeColonistModel;

        public UniverseColonistController()
        {
            universeColonistModel = new UniverseColonistModel();
        }

        public void AddXp(int xp)
        {
            universeColonistModel.AddXp(xp);    
        }
    }
}
