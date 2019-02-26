using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.GameModels.Buildings;
using Game.Items;
using Game.Services.Definitions;
using System;
using System.Collections.Generic;

namespace Game.GameModel
{
    public class RaisingArticles : IRaising, IDisposable
    {
        public event EventHandler<LevelUpArgs> OnLevelUp;

        public PlayerModel PlayerModel { get; }

        public AntimatterCatcherBuilding AntimatterCatcherBuilding { get; }
        public BaseStationBuilding BaseStationBuilding { get; }
        public FuelRefineryBuilding FuelRefineryBuilding { get; }
        public LaunchTowerBuilding LaunchTowerBuilding { get; }
        public RecruitmentOfColonistBuilding RecruitmentOfColonistBuilding { get; }
        public ResearchLaboratoryBuilding ResearchLaboratoryBuilding { get; }
        public ResourceObservatoryBuilding ResourceObservatoryBuilding { get; }


        public IDictionary<RaisingType, IRaising> AllRaisingArticles = new Dictionary<RaisingType, IRaising>();

        public RaisingArticles(GameplayData gameplayData, AllDefinitions allDefinitions, GameplayStorage gameplayStorage)
        {
            PlayerModel = new PlayerModel(gameplayData.PlayerData, allDefinitions.Player, gameplayStorage.Player);
            AllRaisingArticles.Add(RaisingType.Player, PlayerModel);

            AntimatterCatcherBuilding = new AntimatterCatcherBuilding(gameplayData.BuildingsData.AntimatterCatcher, allDefinitions.Buildings.AntimatterCatcher, gameplayStorage.Buildings.AntimatterCatcher);
            AllRaisingArticles.Add(RaisingType.Player, AntimatterCatcherBuilding);
            BaseStationBuilding = new BaseStationBuilding(gameplayData.BuildingsData.BaseStation, allDefinitions.Buildings.BaseStation, gameplayStorage.Buildings.BaseStation);
            AllRaisingArticles.Add(RaisingType.BaseStation, BaseStationBuilding);
            FuelRefineryBuilding = new FuelRefineryBuilding(gameplayData.BuildingsData.FuelRefinery, allDefinitions.Buildings.FuelRefinery, gameplayStorage.Buildings.FuelRefinery);
            AllRaisingArticles.Add(RaisingType.FuelRefinery, FuelRefineryBuilding);
            LaunchTowerBuilding = new LaunchTowerBuilding(gameplayData.BuildingsData.LaunchTower, allDefinitions.Buildings.LaunchTower, gameplayStorage.Buildings.LaunchTower);
            AllRaisingArticles.Add(RaisingType.LaunchTower, LaunchTowerBuilding);
            RecruitmentOfColonistBuilding = new RecruitmentOfColonistBuilding(gameplayData.BuildingsData.RecruitmentOfColonist, allDefinitions.Buildings.RecruitmentOfColonist, gameplayStorage.Buildings.RecruitmentOfColonist);
            AllRaisingArticles.Add(RaisingType.RecruitmentOfColonist, RecruitmentOfColonistBuilding);
            ResearchLaboratoryBuilding = new ResearchLaboratoryBuilding(gameplayData.BuildingsData.ResearchLaboratory, allDefinitions.Buildings.ResearchLaboratory, gameplayStorage.Buildings.ResearchLaboratory);
            AllRaisingArticles.Add(RaisingType.ResearchLaboratory, ResearchLaboratoryBuilding);
            ResourceObservatoryBuilding = new ResourceObservatoryBuilding(gameplayData.BuildingsData.ResourceObservatory, allDefinitions.Buildings.ResourceObservatory, gameplayStorage.Buildings.ResourceObservatory);
            AllRaisingArticles.Add(RaisingType.ResourceObservatory, ResourceObservatoryBuilding);

            foreach (IRaising raisingArticle in AllRaisingArticles.Values)
            {
                raisingArticle.OnLevelUp += (a, b) => OnLevelUp.Invoke(a, b);
            }
        }

        public bool TryRaiseLevel(int xp)
        {
            bool raising = false;
            foreach (IRaising raisingArticle in AllRaisingArticles.Values)
            {
                raising |= raisingArticle.TryRaiseLevel(xp);
            }

            return raising;
        }

        public void Dispose()
        {
            foreach (IRaising raisingArticle in AllRaisingArticles.Values)
            {
                raisingArticle.OnLevelUp -= (a, b) => OnLevelUp.Invoke(a, b);
            }
        }
    }
}
