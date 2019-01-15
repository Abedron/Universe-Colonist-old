using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Buildings;
using Game.Configurations;

namespace Game
{
    public class UniverseColonistModel
    {
        public UniverseColonistModel()
        {
            var progressDefinition = new ProgressDefinition[1];
            var buildingDefinition = new BuildingDefinition[1];
            var baseStation = new BaseStation(progressDefinition, buildingDefinition);
        }
    }
}
