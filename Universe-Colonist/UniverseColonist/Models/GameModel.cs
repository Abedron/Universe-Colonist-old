using System.Collections.Generic;
using System.Linq;
using Game.Configurations;
using Game.Goods;
using Game.Goods.Buildings;
using Game.PlayDataService;
using Game.Services;

namespace Game.Models
{
    public class GameModel
    {
        public PlayerGoods PlayerGoods { get; internal set; }
        public Dictionary<GoodsType, IRaising> AllGoods { get; }

        private IPlayData PlayData { get; }
        private AllDefinitions Definitions { get; }

        public GameModel(IPlayData playData, AllDefinitions definitions)
        {
            PlayData = playData;
            Definitions = definitions;

            AllGoods = GetAllGoods();
        }

        public bool AddLevel(GoodsType goodsType)
        {
            IRaising goodsRaising = AllGoods.FirstOrDefault(d => d.Key == goodsType).Value;

            ((Raising)goodsRaising).SetToLevel(goodsRaising.Level + 1);

            return false;
        }

        public void Build(GoodsType goodsType)
        {
            IRaising goodsRaising = AllGoods.FirstOrDefault(d => d.Key == goodsType).Value;
            goodsRaising.IsBuilt = true;
        }

        public void AddXp(int xp)
        {
            PlayerGoods.Xp += xp;

            TryGoodsRaiseLevel(PlayerGoods.Xp);
        }

        internal GoodsType[] TryGoodsRaiseLevel(int xp)
        {
            var raisedGoods = AllGoods.Where(d => d.Value.TryRaiseLevel(xp));

            return raisedGoods.Select(d => d.Key).ToArray();
        }

        private Dictionary<GoodsType, IRaising> GetAllGoods()
        {
            var allGoods = new Dictionary<GoodsType, IRaising>();
            int level = GetLevel(GoodsType.Player);
            PlayerGoods = new PlayerGoods(level, Definitions.Player);
            PlayerGoods.Xp = PlayData?.Xp ?? 0;
            allGoods.Add(GoodsType.Player, PlayerGoods);

            level = GetLevel(GoodsType.BaseStation);
            allGoods.Add(GoodsType.BaseStation, new BaseStationBuilding(level, Definitions.Buildings.BaseStation));

            level = GetLevel(GoodsType.AntimatterCatcher);
            allGoods.Add(GoodsType.AntimatterCatcher, new AntimatterCatcherBuilding(level, Definitions.Buildings.AntimatterCatcher));

            level = GetLevel(GoodsType.FuelRefinery);
            allGoods.Add(GoodsType.FuelRefinery, new FuelRefineryBuilding(level, Definitions.Buildings.FuelRefinery));

            level = GetLevel(GoodsType.LaunchTower);
            allGoods.Add(GoodsType.LaunchTower, new LaunchTowerRocketsBuilding(level, Definitions.Buildings.LaunchTowerRockets));

            level = GetLevel(GoodsType.RecruitmentOfColonist);
            allGoods.Add(GoodsType.RecruitmentOfColonist, new RecruitmentOfColonistBuilding(level, Definitions.Buildings.RecruitmentOfColonist));

            level = GetLevel(GoodsType.ResearchLaboratory);
            allGoods.Add(GoodsType.ResearchLaboratory, new ResearchLaboratoryBuilding(level, Definitions.Buildings.ResearchLaboratory));

            level = GetLevel(GoodsType.ResourceObservatory);
            allGoods.Add(GoodsType.ResourceObservatory, new ResourceObservatoryBuilding(level, Definitions.Buildings.ResourceObservatory));

            return allGoods;
        }

        internal int GetLevel(GoodsType goodsType)
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