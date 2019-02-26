using System;
using System.Linq;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel
{
    public class Raising<TDefinition, TStorage> : IRaising where TDefinition : IRaiseDefinition where TStorage : IRaiseStorage
    {
        public event EventHandler<LevelUpArgs> OnLevelUp;

        protected TDefinition[] Definitions { get; }
        protected TStorage Storage { get; }

        public Raising(TDefinition[] definitions, TStorage storage)
        {
            Definitions = definitions;
            Storage = storage;
        }

        public virtual bool TryRaiseLevel(int xp)
        {
            int level = GetCalculateLevel(Definitions, xp);
            if (Storage.Level < level)
            {
                int oldlevel = Storage.Level;
                SetToLevel(level);
                OnLevelUp.Invoke(this, new LevelUpArgs(oldlevel, level));
                return true;
            }

            return false;
        }

        internal static int GetCalculateLevel(TDefinition[] definitions, int xp)
        {
            int minXp = definitions.Min(d => d.Xp);
            if (minXp > xp)
            {
                return 0;
            }

            int length = definitions.Length;
            for (int i = 0; i < length; i++)
            {
                IRaiseDefinition definition = null;
                definition = definitions[i];

                if (definition.Xp > xp)
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