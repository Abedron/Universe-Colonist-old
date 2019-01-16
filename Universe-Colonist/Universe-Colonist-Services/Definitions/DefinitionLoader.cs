using System;
using Game.Services.Configs;
using Game.Services.Definitions.VO;

namespace Game.Services.Definitions
{
    public class UniverseColonistService
    {
        private Config config;

        public UniverseColonistService()
        {
            config = LoadConfig("");
        }

        private Config LoadConfig(string path)
        {
            throw new NotImplementedException();
        }

        public BuildingDefinition LoadBuildingDefinition()
        {
            throw new NotImplementedException();
        }

        public ProgressDefinition LoadProgressDefinition()
        {
            throw new NotImplementedException();
        }
    }
}
