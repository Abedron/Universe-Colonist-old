using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.GameModels.Buildings;
using Game.Services.Definitions;

namespace Game.GameModel
{
    public class RaisingArticles
    {
        public PlayerModel PlayerModel { get; }

        public AntimatterCatcherBuilding AntimatterCatcherBuilding { get; }
        public BaseStationBuilding BaseStationBuilding { get; }
        public FuelRefineryBuilding FuelRefineryBuilding { get; }
        public LaunchTowerBuilding LaunchTowerBuilding { get; }
        public RecruitmentOfColonistBuilding RecruitmentOfColonistBuilding { get; }
        public ResearchLaboratoryBuilding ResearchLaboratoryBuilding { get; }
        public ResourceObservatoryBuilding ResourceObservatoryBuilding { get; }

        public RaisingArticles(GameplayData gameplayData, AllDefinitions allDefinitions, GameplayStorage gameplayStorage)
        {
            PlayerModel = new PlayerModel(gameplayData.PlayerData, allDefinitions.Player, gameplayStorage.Player);

            AntimatterCatcherBuilding = new AntimatterCatcherBuilding(gameplayData.BuildingsData.AntimatterCatcher, allDefinitions.Buildings.AntimatterCatcher, gameplayStorage.Buildings.AntimatterCatcher);
            BaseStationBuilding = new BaseStationBuilding(gameplayData.BuildingsData.BaseStation, allDefinitions.Buildings.BaseStation, gameplayStorage.Buildings.BaseStation);
            FuelRefineryBuilding = new FuelRefineryBuilding(gameplayData.BuildingsData.FuelRefinery, allDefinitions.Buildings.FuelRefinery, gameplayStorage.Buildings.FuelRefinery);
            LaunchTowerBuilding = new LaunchTowerBuilding(gameplayData.BuildingsData.LaunchTower, allDefinitions.Buildings.LaunchTower, gameplayStorage.Buildings.LaunchTower);
            RecruitmentOfColonistBuilding = new RecruitmentOfColonistBuilding(gameplayData.BuildingsData.RecruitmentOfColonist, allDefinitions.Buildings.RecruitmentOfColonist, gameplayStorage.Buildings.RecruitmentOfColonist);
            ResearchLaboratoryBuilding = new ResearchLaboratoryBuilding(gameplayData.BuildingsData.ResearchLaboratory, allDefinitions.Buildings.ResearchLaboratory, gameplayStorage.Buildings.ResearchLaboratory);
            ResourceObservatoryBuilding = new ResourceObservatoryBuilding(gameplayData.BuildingsData.ResourceObservatory, allDefinitions.Buildings.ResourceObservatory, gameplayStorage.Buildings.ResourceObservatory);
        }


    }
}
