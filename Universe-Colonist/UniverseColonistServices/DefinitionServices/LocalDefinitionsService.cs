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
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingPaths.BaseStation);
            AllDefinitions.Buildings.BaseStation = JsonConvert.DeserializeObject<BaseStationDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingPaths.AntimatterCatcher);
            AllDefinitions.Buildings.AntimatterCatcher = JsonConvert.DeserializeObject<AntimatterCatcherDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingPaths.FuelRefinery);
            AllDefinitions.Buildings.FuelRefinery = JsonConvert.DeserializeObject<FuelRefineryDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingPaths.LaunchTower);
            AllDefinitions.Buildings.LaunchTower = JsonConvert.DeserializeObject<LaunchTowerDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingPaths.RecruitmentOfColonist);
            AllDefinitions.Buildings.RecruitmentOfColonist = JsonConvert.DeserializeObject<RecruitmentOfColonistDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingPaths.ResearchLaboratory);
            AllDefinitions.Buildings.ResearchLaboratory = JsonConvert.DeserializeObject<ResearchLaboratoryDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.BuildingPaths.ResourceObservatory);
            AllDefinitions.Buildings.ResourceObservatory = JsonConvert.DeserializeObject<ResourceObservatoryDefinition[]>(json);

            json = Load(ConfigDefinitions.DefinitionPaths.PlanetPaths.Antuel);
            AllDefinitions.Planets.Antuel = JsonConvert.DeserializeObject<AntuelDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.PlanetPaths.Asteroids);
            AllDefinitions.Planets.Asteroids = JsonConvert.DeserializeObject<AsteroidsDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.PlanetPaths.Jupiter);
            AllDefinitions.Planets.Jupiter = JsonConvert.DeserializeObject<JupiterDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.PlanetPaths.Mars);
            AllDefinitions.Planets.Mars = JsonConvert.DeserializeObject<MarsDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.PlanetPaths.Mercury);
            AllDefinitions.Planets.Mercury = JsonConvert.DeserializeObject<MercuryDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.PlanetPaths.Venus);
            AllDefinitions.Planets.Venus = JsonConvert.DeserializeObject<VenusDefinition[]>(json);

            json = Load(ConfigDefinitions.DefinitionPaths.RocketPaths.NeoV);
            AllDefinitions.Rockets.NeoV = JsonConvert.DeserializeObject<NeoVDefinition[]>(json);
            json = Load(ConfigDefinitions.DefinitionPaths.RocketPaths.BlueLight);
            AllDefinitions.Rockets.BlueLight = JsonConvert.DeserializeObject<BlueLightDefinition[]>(json);
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
