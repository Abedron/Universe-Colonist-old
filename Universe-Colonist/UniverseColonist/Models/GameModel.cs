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
        public Dictionary<GoodsType, IRaising> AllGoods { get; set; } = new Dictionary<GoodsType, IRaising>();

        private IPlayData PlayData { get; }
        private AllDefinitions Definitions { get; }

        public GameModel(IPlayData playData, AllDefinitions definitions)
        {
            PlayData = playData;
            Definitions = definitions;

            InitGoods();
        }

        public bool AddLevel(GoodsType goodsType)
        {


            return false;
        }

        public bool Build(GoodsType goodsType)
        {


            return false;
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

        private void InitGoods()
        {
            int level = GetLevel(GoodsType.Player);
            PlayerGoods = new PlayerGoods(level, Definitions.Player);
            PlayerGoods.Xp = PlayData?.Xp ?? 0;
            AllGoods.Add(GoodsType.Player, PlayerGoods);

            level = GetLevel(GoodsType.BaseStation);
            AllGoods.Add(GoodsType.BaseStation, new BaseStationBuilding(level, Definitions.Buildings.BaseStation));

            level = GetLevel(GoodsType.AntimatterCatcher);
            AllGoods.Add(GoodsType.AntimatterCatcher, new AntimatterCatcherBuilding(level, Definitions.Buildings.AntimatterCatcher));

            level = GetLevel(GoodsType.FuelRefinery);
            AllGoods.Add(GoodsType.FuelRefinery, new FuelRefineryBuilding(level, Definitions.Buildings.FuelRefinery));

            level = GetLevel(GoodsType.LaunchTower);
            AllGoods.Add(GoodsType.LaunchTower, new LaunchTowerRocketsBuilding(level, Definitions.Buildings.LaunchTowerRockets));

            level = GetLevel(GoodsType.RecruitmentOfColonist);
            AllGoods.Add(GoodsType.RecruitmentOfColonist, new RecruitmentOfColonistBuilding(level, Definitions.Buildings.RecruitmentOfColonist));

            level = GetLevel(GoodsType.ResearchLaboratory);
            AllGoods.Add(GoodsType.ResearchLaboratory, new ResearchLaboratoryBuilding(level, Definitions.Buildings.ResearchLaboratory));

            level = GetLevel(GoodsType.ResourceObservatory);
            AllGoods.Add(GoodsType.ResourceObservatory, new ResourceObservatoryBuilding(level, Definitions.Buildings.ResourceObservatory));
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