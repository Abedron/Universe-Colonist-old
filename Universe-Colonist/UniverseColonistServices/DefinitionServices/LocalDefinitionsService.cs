using System;
using System.IO;
using System.Linq;
using Game.Services.Definitions;
using Game.Services.Definitions.Buildings;
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

            json = Load(ConfigDefinitions.DefinitionPaths.Game);
            AllDefinitions.Game = JsonConvert.DeserializeObject<GameDefinition[]>(json).ToArray<IRaiseDefinition>();
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.BaseStation);
            AllDefinitions.Buildings.BaseStation = JsonConvert.DeserializeObject<BaseStationDefinition[]>(json).ToArray<IRaiseDefinition>();
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.AntimatterCatcher);
            AllDefinitions.Buildings.AntimatterCatcher = JsonConvert.DeserializeObject<AntimatterCatcherDefinition[]>(json).ToArray<IRaiseDefinition>();
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.FuelRefinery);
            AllDefinitions.Buildings.FuelRefinery = JsonConvert.DeserializeObject<FuelRefineryDefinition[]>(json).ToArray<IRaiseDefinition>();
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.LaunchTowerRockets);
            AllDefinitions.Buildings.LaunchTowerRockets = JsonConvert.DeserializeObject<LaunchTowerRocketsDefinition[]>(json).ToArray<IRaiseDefinition>();
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.RecruitmentOfColonist);
            AllDefinitions.Buildings.RecruitmentOfColonist = JsonConvert.DeserializeObject<RecruitmentOfColonistDefinition[]>(json).ToArray<IRaiseDefinition>();
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.ResearchLaboratory);
            AllDefinitions.Buildings.ResearchLaboratory = JsonConvert.DeserializeObject<ResearchLaboratoryDefinition[]>(json).ToArray<IRaiseDefinition>();
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingsPaths.ResourceObservatory);
            AllDefinitions.Buildings.ResourceObservatory = JsonConvert.DeserializeObject<ResourceObservatoryDefinition[]>(json).ToArray<IRaiseDefinition>();
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
