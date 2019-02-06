using System;
using Game.Configurations.Definitions;

namespace Game.Buildings
{
    public class BaseStation : IBuilding
    {
        public int Level { get; private set; }

        private readonly BuildingDefinition[] buildingDefinitions;

        public BaseStation(BuildingDefinition[] buildingDefinition)
        {
            this.buildingDefinitions = buildingDefinition;
        }

        public bool TryRaiseLevel(int xp)
        {
            BuildingDefinition definition = null;
            int length = buildingDefinitions.Length;
            for (int i = 0; i < length; i++)
            {
                definition = buildingDefinitions[i];
                if (definition.RewardXp > xp)
                {
                    definition = buildingDefinitions[Math.Max(0, i - 1)];
                    Level = definition.Level;
                    return true;
                }

                if (i == length - 1)
                {
                    Level = definition.Level;
                    return true;
                }
            }

            return false;
        }
    }

    public interface IBuilding
    {
        int Level { get; }
    }
}