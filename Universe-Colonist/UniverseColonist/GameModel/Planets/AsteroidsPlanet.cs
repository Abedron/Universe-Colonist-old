using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Planets
{
    public class AsteroidsPlanet : PlanetBase<AsteroidsData, AsteroidsDefinition, Asteroids>
    {
        public AsteroidsPlanet(AsteroidsData data, AsteroidsDefinition[] definitions, Asteroids storage): base(data, definitions, storage)
        {

        }
    }
}