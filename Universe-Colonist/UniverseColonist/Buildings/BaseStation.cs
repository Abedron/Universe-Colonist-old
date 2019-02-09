namespace Game.Buildings
{
    public class BaseStation
    {
        public int Level { get; internal set; }

        private readonly ILeveling[] buildingDefinitions;

        public BaseStation(ILeveling[] buildingDefinition)
        {
            buildingDefinitions = buildingDefinition;
        }

        public bool TryRaiseLevel(int xp)
        {
            int level = buildingDefinitions.GetRaiseLevel(xp);
            if (level > Level)
            {
                Level = level;
                return true;
            }

            return false;
        }
    }
}