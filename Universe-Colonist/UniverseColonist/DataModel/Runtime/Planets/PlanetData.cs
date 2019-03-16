using Game.Articles;
using Game.Services.Definitions;
using System.Linq;

namespace Game.DataModel.Runtime
{
    public class PlanetData
    {
        private PlanetDefinition[] Definitions { get; }
        public PlanetDefinition Definition => Definitions.FirstOrDefault(d => d.Level == Level) ?? Definitions[0];

        public PlanetType PlanetType { get; }
        public bool IsActivated { get; set; }
        public int Level { get; set; }
        public int Colonist { get; set; }

        public PlanetData(PlanetType planetType, PlanetDefinition[] definitions)
        {
            PlanetType = planetType;
            Definitions = definitions;
        }

    }
}