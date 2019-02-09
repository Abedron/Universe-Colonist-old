using System;
using System.IO;
using Game.Services.Definitions;
using Game.Services.Definitions.Buildings;
using Newtonsoft.Json;

namespace Game.Services
{
    public class DefinitionsService
    {
        public Config Config { get; internal set; }
        public GameDefinitions GameDefinitions = new GameDefinitions();

        public DefinitionsService()
        {
            string json = Load("_Data/Config.json");
            Config = JsonConvert.DeserializeObject<Config>(json);

            LoadAllDefinitions();
        }

        public void LoadAllDefinitions()
        {
            string json = Load("_Data/Definitions/Game.json");
            GameDefinitions.Game = JsonConvert.DeserializeObject<Game[]>(json);
            json = Load("_Data/Definitions/Buildings/BaseStation.json");
            GameDefinitions.Buildings.BaseStation = JsonConvert.DeserializeObject<BaseStation[]>(json);
            json = Load("_Data/Definitions/Buildings/AntimatterCatcher.json");
            GameDefinitions.Buildings.AntimatterCatcher = JsonConvert.DeserializeObject<AntimatterCatcher[]>(json);
            json = Load("_Data/Definitions/Buildings/FuelRefinery.json");
            GameDefinitions.Buildings.FuelRefinery = JsonConvert.DeserializeObject<FuelRefinery[]>(json);
            json = Load("_Data/Definitions/Buildings/LaunchTowerRockets.json");
            GameDefinitions.Buildings.LaunchTowerRockets = JsonConvert.DeserializeObject<LaunchTowerRockets[]>(json);
            json = Load("_Data/Definitions/Buildings/RecruitmentOfColonist.json");
            GameDefinitions.Buildings.RecruitmentOfColonist = JsonConvert.DeserializeObject<RecruitmentOfColonist[]>(json);
            json = Load("_Data/Definitions/Buildings/ResearchLaboratory.json");
            GameDefinitions.Buildings.ResearchLaboratory = JsonConvert.DeserializeObject<ResearchLaboratory[]>(json);
            json = Load("_Data/Definitions/Buildings/ResourceObservatory.json");
            GameDefinitions.Buildings.ResourceObservatory = JsonConvert.DeserializeObject<ResourceObservatory[]>(json);
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
