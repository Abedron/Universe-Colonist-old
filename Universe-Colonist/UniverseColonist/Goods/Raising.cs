using System;
using System.Linq;
using Game.Services.Definitions;

namespace Game.Goods
{
    public class Raising : IRaising
    {
        public event EventHandler<LevelUpArgs> OnLevelUp;
        public bool Enabled => Level > 0;
        public bool IsBuilt { get; set; }

        public int Level { get; private set; }

        internal void SetToLevel(int level)
        {
            int levelDifference = level - Level;
            Level = level;

            OnLevelUp?.Invoke(this, new LevelUpArgs(levelDifference));
        }

        protected IRaiseDefinition[] RaiseDefinitions { get; }

        public Raising(int level, IRaiseDefinition[] raiseDefinition)
        {
            Level = level;
            RaiseDefinitions = raiseDefinition;
        }

        public virtual bool TryRaiseLevel(int xp)
        {
            int level = GetCalculateLevel(RaiseDefinitions, xp);
            if (Level < level)
            {
                SetToLevel(level);
                int levelDifference = level - Level;
                Level = level;
                OnLevelUp?.Invoke(this, new LevelUpArgs(levelDifference));
                return true;
            }

            return false;
        }

        internal static int GetCalculateLevel(IRaiseDefinition[] definitions, int xp)
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
    }
}