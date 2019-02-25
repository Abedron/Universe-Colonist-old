﻿using System;
using System.Linq;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel
{
    public class Raising<TDefinition, TStorage> : IRaising where TDefinition : IRaisingDefinition where TStorage : IRaisingStorage
    {
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
                SetToLevel(level);
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
                IRaisingDefinition definition = null;
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
            int levelDifference = level - Storage.Level;
            Storage.Level = level;
        }
    }
}