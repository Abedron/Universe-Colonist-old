using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.GameModel.Buildings;
using Game.GameModel.Planets;
using Game.Articles;
using Game.Services.Definitions;
using System;
using System.Collections.Generic;
using Game.GameModel.Rockets;

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

        public AntuelPlanet AntuelPlanet { get; }
        public AsteroidsPlanet AsteroidsPlanet { get; }
        public JupiterPlanet JupiterPlanet { get; }
        public MarsPlanet MarsPlanet { get; }
        public MercuryPlanet MercuryPlanet { get; }
        public VenusPlanet VenusPlanet { get; }

        public NeoVRocket NeoVRocket { get; }
        public BlueLightRocket BlueLightRocket { get; }

        public IDictionary<RaisingType, IRaising> AllRaisingArticles = new Dictionary<RaisingType, IRaising>();

        public RaisingArticles(GameplayData gameplayData, AllDefinitions allDefinitions, GameplayStorage gameplayStorage)
        {
            PlayerModel = new PlayerModel(gameplayData.PlayerData, allDefinitions.Player, gameplayStorage.Player);
            PlayerModel.OnLevelUp += (a, b) => OnLevelUp.Invoke(a, b);
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

            AntuelPlanet = new AntuelPlanet(gameplayData.Planets.Antuel, allDefinitions.Planets.Antuel, gameplayStorage.Planets.Antuel);
            AllRaisingArticles.Add(RaisingType.Antuel, AntuelPlanet);
            AsteroidsPlanet = new AsteroidsPlanet(gameplayData.Planets.Asteroids, allDefinitions.Planets.Asteroids, gameplayStorage.Planets.Asteroids);
            AllRaisingArticles.Add(RaisingType.Asteroids, AsteroidsPlanet);
            JupiterPlanet = new JupiterPlanet(gameplayData.Planets.Jupiter, allDefinitions.Planets.Jupiter, gameplayStorage.Planets.Jupiter);
            AllRaisingArticles.Add(RaisingType.Jupiter, JupiterPlanet);
            MarsPlanet = new MarsPlanet(gameplayData.Planets.Mars, allDefinitions.Planets.Mars, gameplayStorage.Planets.Mars);
            AllRaisingArticles.Add(RaisingType.Mars, MarsPlanet);
            MercuryPlanet = new MercuryPlanet(gameplayData.Planets.Mercury, allDefinitions.Planets.Mercury, gameplayStorage.Planets.Mercury);
            AllRaisingArticles.Add(RaisingType.Mercury, MercuryPlanet);
            VenusPlanet = new VenusPlanet(gameplayData.Planets.Venus, allDefinitions.Planets.Venus, gameplayStorage.Planets.Venus);
            AllRaisingArticles.Add(RaisingType.Venus, VenusPlanet);

            NeoVRocket = new NeoVRocket(gameplayData.Rockets.NeoV, allDefinitions.Rockets.NeoV, gameplayStorage.Rockets.NeoV);
            AllRaisingArticles.Add(RaisingType.NeoV, NeoVRocket);
            BlueLightRocket = new BlueLightRocket(gameplayData.Rockets.BlueLight, allDefinitions.Rockets.BlueLight, gameplayStorage.Rockets.BlueLight);
            AllRaisingArticles.Add(RaisingType.BlueLight, BlueLightRocket);

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
