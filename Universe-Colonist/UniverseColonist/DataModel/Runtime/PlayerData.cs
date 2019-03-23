using Game.Services.Definitions;
using System.Linq;

namespace Game.DataModel.Runtime
{
    public class PlayerData
    {
        public int Level { get; set; }
        public bool Enabled { get; set; }
        public bool IsActivate { get; set; }
        public PlayerDefinition[] Definitions { get; }
        public PlayerDefinition Definition => Definitions.FirstOrDefault(d => d.Level == Level) ?? Definitions[0];

        public PlayerData(PlayerDefinition[] definitions)
        {
            Definitions = definitions;
        }
    }
}