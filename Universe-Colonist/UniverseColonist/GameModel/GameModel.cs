using System.Collections.Generic;
using Game.Items;
using Game.DataModel.Runtime;
using Game.GameModel;
using Game.Services.Definitions;
using Game.DataModel.Storage;

namespace Game.GameModel
{
    public class GameModel
    {
        public RaisingArticles RaisingArticles { get; }
        public Dictionary<RaisingType, IRaising> AllGoods { get; }
        public GameplayStorage GameplayStorage { get; }

        private GameplayData GameplayData { get; } = new GameplayData();
        private AllDefinitions AllDefinitions { get; }

        public GameModel(AllDefinitions definitions, GameplayStorage gameplayStorage)
        {
            GameplayStorage = gameplayStorage;
            AllDefinitions = definitions;
            RaisingArticles = new RaisingArticles(GameplayData, definitions, gameplayStorage);
        }
    }
}