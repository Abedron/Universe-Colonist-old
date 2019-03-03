using System.Collections.Generic;

namespace Game.DataModel.Storage
{
    public class Rockets
    {
        public IList<RocketBase> AllRockets { get; } = new List<RocketBase>();
    }
}