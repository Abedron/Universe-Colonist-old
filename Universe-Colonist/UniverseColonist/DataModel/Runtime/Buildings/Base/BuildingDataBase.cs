using Game.Services.Definitions;
using System.Linq;

namespace Game.DataModel.Runtime
{
    public class BuildingDataBase<T> : ILevelUpData where T: ILevelUpDefinition
    {
        public int Level { get; set; }
        public bool IsActivate { get; set; }
        public T[] Definitions { get; }
        public T Definition => Definitions.FirstOrDefault(d => d.Level == Level) ?? Definitions[0];

        public BuildingDataBase(T[] definitions)
        {
            Definitions = definitions;
        }
    }
}