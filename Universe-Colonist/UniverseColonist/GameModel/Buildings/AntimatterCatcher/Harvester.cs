using Game.Services.Definitions;
using Game.Utils;
using System;

namespace Game.GameModel.Buildings
{
    public class Harvester
    {
        public AntimatterCatcherDefinition Definition { get; }

        public DateTime StartTime { get; private set; }

        public Harvester(AntimatterCatcherDefinition definition, DateTime startTime)
        {
            Definition = definition;
            StartTime = startTime;
        }

        public int GetHarvestResources(DateTime currentTime)
        {
            var time = currentTime - StartTime;
            var ratio = Mathg.Clamp(time.TotalSeconds / Definition.HarvestingTime, 0, 1);
            var resources = (int)Math.Round(ratio * Definition.Resources);

            return resources;
        }
    }
}
