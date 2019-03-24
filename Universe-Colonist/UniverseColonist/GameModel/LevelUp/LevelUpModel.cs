using Game.DataModel.Runtime;
using Game.Services.Definitions;
using System.Linq;

namespace Game.GameModel
{
    public class LevelUpModel
    {
        public ILevelUpData Data { get; }

        public LevelUpModel(ILevelUpData data)
        {
            Data = data;
        }

        public bool TryLevelUp(PlayerDefinition[] definitions, int xp)
        {
            var definition = definitions.LastOrDefault(d => d.Xp <= xp) ?? definitions[0];
            return TryLevelUp(Data, definition);
        }

        public bool TryLevelUp(ILevelUpByPlayerDefinition[] definitions, int playerLevel)
        {
            var definition = definitions.LastOrDefault(d => d.AccessFromPlayerLevel <= playerLevel) ?? definitions[0];
            return TryLevelUp(Data, definition);
        }

        public bool TryLevelUp(ILevelUpByBaseStationDefinition[] definitions, int baseStationLevel)
        {
            var definition = definitions.LastOrDefault(d => d.BaseStationLevel <= baseStationLevel) ?? definitions[0];
            return TryLevelUp(Data, definition);
        }

        private bool TryLevelUp(ILevelUpData data, ILevelUpDefinition definition)
        {
            bool isLevelUp = definition.Level != data.Level;
            data.Level = isLevelUp ? ++data.Level : data.Level;

            return isLevelUp;
        }
    }
}