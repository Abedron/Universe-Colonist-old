﻿using Game.Services.Definitions;

namespace Game.Goods.Buildings
{
    public class ResearchLaboratoryBuilding : Raising
    {
        public ResearchLaboratoryBuilding(int level, IRaiseDefinition[] buildingDefinition) : base(level, buildingDefinition)
        {
        }
    }
}