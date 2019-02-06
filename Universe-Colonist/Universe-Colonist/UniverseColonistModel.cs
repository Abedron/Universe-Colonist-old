using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Buildings;
using Game.Configurations.Definitions;

namespace Game
{
    public class UniverseColonistModel
    {
        public int Xp { get; private set; }

        public void AddXp(int xp)
        {
            Xp += xp;
        }
    }
}
