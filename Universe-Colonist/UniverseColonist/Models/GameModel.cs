using System.Collections.Generic;
using System.Linq;
using Game.Configurations;
using Game.Goods;
using Game.Goods.Buildings;
using Game.Services;
using Game.StockService;

namespace Game.Models
{
    public class GameModel
    {
        public IConfigurationStock ConfigurationStock { get; }
        public GameGoods GameGoods { get; internal set; }

        public Dictionary<GoodsType, IRaising> Buildings { get; set; } = new Dictionary<GoodsType, IRaising>();

        private readonly AllDefinitions definitions;

        public GameModel(IConfigurationStock configurationStock, AllDefinitions definitions)
        {
            ConfigurationStock = configurationStock;
            this.definitions = definitions;

            InitBuildings();
        }

        private void InitBuildings()
        {
            int level = GetLevel(GoodsType.Game);
            GameGoods = new GameGoods(level, definitions.Game);
            level = GetLevel(GoodsType.BaseStation);
            Buildings.Add(GoodsType.BaseStation, new BaseStationBuilding(level, definitions.Buildings.BaseStation));
            level = GetLevel(GoodsType.AntimatterCatcher);
            Buildings.Add(GoodsType.AntimatterCatcher, new AntimatterCatcherBuilding(level, definitions.Buildings.BaseStation));
            level = GetLevel(GoodsType.FuelRefinery);
            Buildings.Add(GoodsType.FuelRefinery, new FuelRefineryBuilding(level, definitions.Buildings.BaseStation));
            level = GetLevel(GoodsType.LaunchTower);
            Buildings.Add(GoodsType.LaunchTower, new LaunchTowerRocketsBuilding(level, definitions.Buildings.BaseStation));
            level = GetLevel(GoodsType.RecruitmentOfColonist);
            Buildings.Add(GoodsType.RecruitmentOfColonist, new RecruitmentOfColonistBuilding(level, definitions.Buildings.BaseStation));
            level = GetLevel(GoodsType.ResearchLaboratory);
            Buildings.Add(GoodsType.ResearchLaboratory, new ResearchLaboratoryBuilding(level, definitions.Buildings.BaseStation));
            level = GetLevel(GoodsType.ResourceObservatory);
            Buildings.Add(GoodsType.ResourceObservatory, new ResourceObservatoryBuilding(level, definitions.Buildings.BaseStation));
        }

        private int GetLevel(GoodsType goodsType)
        {
            IGoods goods = ConfigurationStock?.Goods.FirstOrDefault(d => d.BuildingType == (int) goodsType);
            if (goods == null)
            {
                return 0;
            }

            return goods.Level;
        }

        public int GetGoodsLevel(GoodsType goodsType)
        {
            return Buildings.FirstOrDefault(d => d.Key == goodsType).Value.Level;
        }
    }
}