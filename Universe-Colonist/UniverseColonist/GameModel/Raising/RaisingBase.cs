using System;
using System.Linq;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel
{
    public class RaisingBase<TDefinition, TStorage> : IRaising where TDefinition : ILevelUpByBaseStationDefinition where TStorage : IRaiseStorage
    {
        public event EventHandler<LevelUpArgs> OnLevelUp;

        protected TDefinition[] Definitions { get; }
        protected TStorage Storage { get; }

        public RaisingBase(TDefinition[] definitions, TStorage storage)
        {
            Definitions = definitions;
            Storage = storage;
        }

        public virtual bool TryRaiseLevel(int playerLevel)
        {
            int level = GetCalculateLevel(Definitions, playerLevel);
            if (Storage.Level < level)
            {
                int oldlevel = Storage.Level;
                SetToLevel(level);
                OnLevelUp.Invoke(this, new LevelUpArgs(oldlevel, level));
                return true;
            }

            return false;
        }

        internal static int GetCalculateLevel(TDefinition[] definitions, int playerLevel)
        {
            int minLevel = definitions.Min(d => d.BaseStationLevel);
            if (minLevel > playerLevel)
            {
                return 0;
            }

            int length = definitions.Length;
            for (int i = 0; i < length; i++)
            {
                ILevelUpByBaseStationDefinition definition = null;
                definition = definitions[i];

                if (definition.BaseStationLevel > playerLevel)
                {

                    definition = definitions[Math.Max(0, i - 1)];
                    return definition.Level;
                }

                if (i == length - 1)
                {
                    return definition.Level;
                }
            }

            return 0;
        }

        internal void SetToLevel(int level)
        {
            Storage.Level = level;
        }
    }
}