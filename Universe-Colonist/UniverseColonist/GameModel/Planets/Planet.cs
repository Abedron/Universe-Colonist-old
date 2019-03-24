using Game.Articles;
using Game.DataModel.Runtime;
using Game.Services.Definitions;

namespace Game.GameModel.Planets
{
    public class Planet : ILevelUp
    {
        public PlanetData Data { get; }
        public PlanetDefinition[] Definitions { get; }
        public PlanetType PlanetType { get; }

        private LevelUpModel LevelUp { get; }

        public Planet(PlanetData data, PlanetDefinition[] definitions, PlanetType planetType)
        {
            Data = data;
            Definitions = definitions;
            PlanetType = planetType;
            LevelUp = new LevelUpModel(data);
        }

        public bool TryLevelUp(int baseStationLevel)
        {
            bool isLevelUp = LevelUp.TryLevelUp(Data.Definitions, baseStationLevel);
            return isLevelUp;
        }
    }
}