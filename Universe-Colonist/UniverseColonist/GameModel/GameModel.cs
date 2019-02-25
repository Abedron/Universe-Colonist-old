﻿using System.Collections.Generic;
using System.Linq;
using Game.Items;
using Game.DataModel.Runtime;
using Game.GameModel;
using Game.GameModel.Buildings;
using Game.Services.Definitions;

namespace Game.GameModels
{
    public class GameModel
    {
        public PlayerGoods PlayerGoods { get; internal set; }
        public Dictionary<RaisingType, IRaising> AllGoods { get; }

        private GameplayData PlayData { get; }
        private AllDefinitions Definitions { get; }

        public GameModel(GameplayData playData, AllDefinitions definitions)
        {
            PlayData = playData;
            Definitions = definitions;

            AllGoods = GetAllGoods();
        }

        public bool AddLevel(RaisingType goodsType)
        {
            IRaising goodsRaising = AllGoods.FirstOrDefault(d => d.Key == goodsType).Value;

            ((Raising)goodsRaising).SetToLevel(goodsRaising.Level + 1);

            return false;
        }

        public void Build(RaisingType goodsType)
        {
            IRaising goodsRaising = AllGoods.FirstOrDefault(d => d.Key == goodsType).Value;
            goodsRaising.IsBuilt = true;
        }

        public void AddXp(int xp)
        {
            PlayerGoods.Xp += xp;

            TryGoodsRaiseLevel(PlayerGoods.Xp);
        }

        internal RaisingType[] TryGoodsRaiseLevel(int xp)
        {
            var raisedGoods = AllGoods.Where(d => d.Value.TryRaiseLevel(xp));

            return raisedGoods.Select(d => d.Key).ToArray();
        }

        private Dictionary<RaisingType, IRaising> GetAllGoods()
        {
            var allGoods = new Dictionary<RaisingType, IRaising>();
            int level = GetLevel(RaisingType.Player);
            PlayerGoods = new PlayerGoods(level, Definitions.Player);
            PlayerGoods.Xp = PlayData?.Xp ?? 0;
            allGoods.Add(RaisingType.Player, PlayerGoods);

            level = GetLevel(RaisingType.BaseStation);
            allGoods.Add(RaisingType.BaseStation, new BaseStationBuilding(level, Definitions.Buildings.BaseStation));

            level = GetLevel(RaisingType.AntimatterCatcher);
            allGoods.Add(RaisingType.AntimatterCatcher, new AntimatterCatcherBuilding(Definitions.Buildings.AntimatterCatcher, ));

            level = GetLevel(RaisingType.FuelRefinery);
            allGoods.Add(RaisingType.FuelRefinery, new FuelRefineryBuilding(level, Definitions.Buildings.FuelRefinery));

            level = GetLevel(RaisingType.LaunchTower);
            allGoods.Add(RaisingType.LaunchTower, new LaunchTowerRocketsBuilding(level, Definitions.Buildings.LaunchTowerRockets));

            level = GetLevel(RaisingType.RecruitmentOfColonist);
            allGoods.Add(RaisingType.RecruitmentOfColonist, new RecruitmentOfColonistBuilding(level, Definitions.Buildings.RecruitmentOfColonist));

            level = GetLevel(RaisingType.ResearchLaboratory);
            allGoods.Add(RaisingType.ResearchLaboratory, new ResearchLaboratoryBuilding(level, Definitions.Buildings.ResearchLaboratory));

            level = GetLevel(RaisingType.ResourceObservatory);
            allGoods.Add(RaisingType.ResourceObservatory, new ResourceObservatoryBuilding(level, Definitions.Buildings.ResourceObservatory));

            return allGoods;
        }

        internal int GetLevel(RaisingType goodsType)
        {
            IGoods goods = PlayData?.Goods.FirstOrDefault(d => d.BuildingType == (int) goodsType);
            if (goods == null)
            {
                return 0;
            }

            return goods.Level;
        }
    }
}