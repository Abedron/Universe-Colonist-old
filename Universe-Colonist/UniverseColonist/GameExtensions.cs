using System;
using Game.Buildings;

public static class GameExtensions
{
    public static int GetRaiseLevel(this ILeveling[] leveling, int xp)
    {
        int length = leveling.Length;
        for (int i = 0; i < length; i++)
        {
            ILeveling definition = null;
            definition = leveling[i];
            if (definition.Xp > xp)
            {
                definition = leveling[Math.Max(0, i - 1)];
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