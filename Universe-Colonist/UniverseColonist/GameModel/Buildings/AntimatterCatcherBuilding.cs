using Game.DataModel.Runtime;
using System;
using System.Collections.Generic;

namespace Game.GameModel.Buildings
{
    public class AntimatterCatcherBuilding : StandardBuildingBase
    {
        public List<Harvester> Harvesters { get; } = new List<Harvester>();
        public AntimatterCatcherData Data { get; }
        private LevelUpModel LevelUp { get; }

        public AntimatterCatcherBuilding(AntimatterCatcherData data)
        {
            Data = data;
            LevelUp = new LevelUpModel(data);
        }

        public override bool TryLevelUp(int baseStationLevel)
        {
            bool isLevelUp = LevelUp.TryLevelUp(Data.Definitions, baseStationLevel);
            return isLevelUp;
        }

        public bool TryAddHarvester(DateTime currentTime)
        {
            if (Harvesters.Count >= Data.Definition.HarvesterCount)
            {
                return false;
            }

            Harvesters.Add(new Harvester(Data.Definition, currentTime));

            return true;
        }
    }
}
