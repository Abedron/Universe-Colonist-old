using System;
using Game.Services.Definitions;

namespace Game.Goods
{
    public class Raising : IRaising
    {
        public int Level { get; internal set; }

        protected IRaiseDefinition[] BuildingDefinitions { get; }

        public Raising(int level, IRaiseDefinition[] buildingDefinition)
        {
            Level = level;
            BuildingDefinitions = buildingDefinition;
        }

        public virtual bool TryRaiseLevel(int xp)
        {
            int level = GetCalculateLevel(BuildingDefinitions, xp);
            if (level > Level)
            {
                Level = level;
                return true;
            }

            return false;
        }

        internal static int GetCalculateLevel(IRaiseDefinition[] definitions, int xp)
        {
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