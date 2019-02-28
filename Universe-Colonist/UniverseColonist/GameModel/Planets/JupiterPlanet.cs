using Game.DataModel.Runtime;
using Game.DataModel.Storage;
using Game.Services.Definitions;

namespace Game.GameModel.Buildings
{
    public class JupiterPlanet : PlanetBase<JupiterData, JupiterDefinition, Jupiter>
    {
        public JupiterPlanet(JupiterData data, JupiterDefinition[] definitions, Jupiter storage) : base(data, definitions, storage)
        {

        }
    }
}