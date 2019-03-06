using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using Game.Services.Definitions;
using System.Net;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using System.Linq;
using System.Globalization;

namespace Tooling.DefinitionLoaderTool
{
    public class DefinitionLoader
    {
        private IList<DefinitionVo> definitionVos = new List<DefinitionVo>();

        public int CountDefinitions => definitionVos.Count;

        public DefinitionLoader()
        {
            definitionVos.Add(new DefinitionVo("https://docs.google.com/spreadsheets/d/1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY/export?format=csv&id=1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY&gid=707072616",
                @"C:\Development\Universe-Colonist\Universe-Colonist\UniverseColonistServices\_Data\Definitions\Player.json"));

            // Buildings
            definitionVos.Add(new DefinitionVo("https://docs.google.com/spreadsheets/d/1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY/export?format=csv&id=1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY&gid=1679462485",
                @"C:\Development\Universe-Colonist\Universe-Colonist\UniverseColonistServices\_Data\Definitions\Buildings\AntimatterCatcher.json"));

            definitionVos.Add(new DefinitionVo("https://docs.google.com/spreadsheets/d/1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY/export?format=csv&id=1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY&gid=359425332",
                @"C:\Development\Universe-Colonist\Universe-Colonist\UniverseColonistServices\_Data\Definitions\Buildings\BaseStation.json"));

            definitionVos.Add(new DefinitionVo("https://docs.google.com/spreadsheets/d/1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY/export?format=csv&id=1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY&gid=651147665",
                @"C:\Development\Universe-Colonist\Universe-Colonist\UniverseColonistServices\_Data\Definitions\Buildings\FuelRefinery.json"));

            definitionVos.Add(new DefinitionVo("https://docs.google.com/spreadsheets/d/1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY/export?format=csv&id=1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY&gid=350238827",
                @"C:\Development\Universe-Colonist\Universe-Colonist\UniverseColonistServices\_Data\Definitions\Buildings\LaunchTower.json"));

            definitionVos.Add(new DefinitionVo("https://docs.google.com/spreadsheets/d/1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY/export?format=csv&id=1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY&gid=1306881034",
                @"C:\Development\Universe-Colonist\Universe-Colonist\UniverseColonistServices\_Data\Definitions\Buildings\RecruitmentOfColonist.json"));

            definitionVos.Add(new DefinitionVo("https://docs.google.com/spreadsheets/d/1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY/export?format=csv&id=1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY&gid=1123166234",
                @"C:\Development\Universe-Colonist\Universe-Colonist\UniverseColonistServices\_Data\Definitions\Buildings\ResearchLaboratory.json"));

            definitionVos.Add(new DefinitionVo("https://docs.google.com/spreadsheets/d/1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY/export?format=csv&id=1ns13nyAM4D4tDIieb975JBDQ5fQgK76dwiQMC8PMgsY&gid=2117045998",
                @"C:\Development\Universe-Colonist\Universe-Colonist\UniverseColonistServices\_Data\Definitions\Buildings\ResourceObservatory.json"));

            // Rockets
            definitionVos.Add(new DefinitionVo("https://docs.google.com/spreadsheets/d/1Wf_rIGjB6Mz1KfYJ9tdLqen3I6tsK66rLAhwJbO8_VM/export?format=csv&id=1Wf_rIGjB6Mz1KfYJ9tdLqen3I6tsK66rLAhwJbO8_VM&gid=2050381870",
                @"C:\Development\Universe-Colonist\Universe-Colonist\UniverseColonistServices\_Data\Definitions\Rockets\AccessRockets.json"));

            definitionVos.Add(new DefinitionVo("https://docs.google.com/spreadsheets/d/1Wf_rIGjB6Mz1KfYJ9tdLqen3I6tsK66rLAhwJbO8_VM/export?format=csv&id=1Wf_rIGjB6Mz1KfYJ9tdLqen3I6tsK66rLAhwJbO8_VM&gid=0",
                @"C:\Development\Universe-Colonist\Universe-Colonist\UniverseColonistServices\_Data\Definitions\Rockets\NeoV.json"));

            definitionVos.Add(new DefinitionVo("https://docs.google.com/spreadsheets/d/1Wf_rIGjB6Mz1KfYJ9tdLqen3I6tsK66rLAhwJbO8_VM/export?format=csv&id=1Wf_rIGjB6Mz1KfYJ9tdLqen3I6tsK66rLAhwJbO8_VM&gid=973085714",
                @"C:\Development\Universe-Colonist\Universe-Colonist\UniverseColonistServices\_Data\Definitions\Rockets\BlueLight.json"));
            
            // Planets
            definitionVos.Add(new DefinitionVo("https://docs.google.com/spreadsheets/d/1o8ICepGfu-mnvDYjD6vy9_cVM7ZNZeJwC3mfiQYqIRA/export?format=csv&id=1o8ICepGfu-mnvDYjD6vy9_cVM7ZNZeJwC3mfiQYqIRA&gid=228444125",
                @"C:\Development\Universe-Colonist\Universe-Colonist\UniverseColonistServices\_Data\Definitions\Planets\AccessPlanets.json"));
        }

        public void LoadAll()
        {
            foreach (var definitionVo in definitionVos)
            {
                var webClient = new WebClient();
                Stream stream = webClient.OpenRead(definitionVo.Uri);

                Configuration configuration = new Configuration();
                configuration.Delimiter = ",";
                configuration.CultureInfo = CultureInfo.InvariantCulture;

                using (var reader = new StreamReader(stream))
                using (var csv = new CsvReader(reader, configuration))
                {
                    string json = "";
                    string name = Path.GetFileName(definitionVo.Path).Split('.')[0];
                    switch (name)
                    {
                        case "Player":
                            json = WriteJson<PlayerDefinition>(definitionVo, csv);
                            break;
                        case "AntimatterCatcher":
                            json = WriteJson<AntimatterCatcherDefinition>(definitionVo, csv);
                            break;
                        case "BaseStation":
                            json = WriteJson<BaseStationDefinition>(definitionVo, csv);
                            break;
                        case "FuelRefinery":
                            json = WriteJson<FuelRefineryDefinition>(definitionVo, csv);
                            break;
                        case "LaunchTower":
                            json = WriteJson<LaunchTowerDefinition>(definitionVo, csv);
                            break;
                        case "RecruitmentOfColonist":
                            json = WriteJson<RecruitmentOfColonistDefinition>(definitionVo, csv);
                            break;
                        case "ResearchLaboratory":
                            json = WriteJson<ResearchLaboratoryDefinition>(definitionVo, csv);
                            break;
                        case "ResourceObservatory":
                            json = WriteJson<ResourceObservatoryDefinition>(definitionVo, csv);
                            break;
                        case "AccessRockets":
                            json = WriteJson<AccessRocketsDefinition>(definitionVo, csv);
                            break;
                        case "NeoV":
                            json = WriteJson<NeoVDefinition>(definitionVo, csv);
                            break;
                        case "BlueLight":
                            json = WriteJson<BlueLightDefinition>(definitionVo, csv);
                            break;
                        case "AccessPlanets":
                            json = WriteJson<AccessPlanetDefinition>(definitionVo, csv);
                            break;
                        default:
                            Console.WriteLine("Missing definition Type: " + name);
                            continue;
                    }

                    File.WriteAllText(definitionVo.Path, json);

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(name);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(json);
                }
            }
        }

        private static string WriteJson<T>(DefinitionVo definitionVo, CsvReader csv)
        {
            IEnumerable<T> records = csv.GetRecords<T>();
            T[] recordsArray = records.ToArray();
            string json = JsonConvert.SerializeObject(recordsArray);
            File.WriteAllText(definitionVo.Path, json);
            return json;
        }
    }
}
