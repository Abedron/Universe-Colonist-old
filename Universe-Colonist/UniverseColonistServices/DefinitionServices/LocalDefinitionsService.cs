using System;
using System.IO;
using Game.Services.Definitions;
using Newtonsoft.Json;

namespace Game.Services
{
    public class LocalDefinitionsService : IDefinitionService
    {
        internal ConfigDefinitions ConfigDefinitions { get; set; }

        public AllDefinitions AllDefinitions { get; } = new AllDefinitions();

        public void LoadAllDefinitions()
        {
            string json = Load("_Data/ConfigDefinitions.json");
            ConfigDefinitions = JsonConvert.DeserializeObject<ConfigDefinitions>(json);
            AllDefinitions.Version = ConfigDefinitions.Version;

            json = Load(ConfigDefinitions.DefinitionPaths.Player);
            AllDefinitions.Player = JsonConvert.DeserializeObject<PlayerDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.BaseStation);
            AllDefinitions.Buildings.BaseStation = JsonConvert.DeserializeObject<BaseStationDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.AntimatterCatcher);
            AllDefinitions.Buildings.AntimatterCatcher = JsonConvert.DeserializeObject<AntimatterCatcherDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.FuelRefinery);
            AllDefinitions.Buildings.FuelRefinery = JsonConvert.DeserializeObject<FuelRefineryDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.LaunchTowerRockets);
            AllDefinitions.Buildings.LaunchTower = JsonConvert.DeserializeObject<LaunchTowerDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.RecruitmentOfColonist);
            AllDefinitions.Buildings.RecruitmentOfColonist = JsonConvert.DeserializeObject<RecruitmentOfColonistDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.ResearchLaboratory);
            AllDefinitions.Buildings.ResearchLaboratory = JsonConvert.DeserializeObject<ResearchLaboratoryDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.ResourceObservatory);
            AllDefinitions.Buildings.ResourceObservatory = JsonConvert.DeserializeObject<ResourceObservatoryDefinition[]>(json);
        }

        public string Load(string path)
        {
            var fullPath = Path.Combine(Environment.CurrentDirectory, path);
            string json = "";

            try
            {
                json = File.ReadAllText(fullPath);
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
                throw;
            }

            return json;
        }
    }
}
