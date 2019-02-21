﻿using Game.GameModels;
using Game.Services;

namespace Game
{
    public class UniverseColonist
    {
        internal AllDefinitions AllDefinitions { get; set; }

        internal GameModel GameModel { get; }

        private IDefinitionService DefinitionsService { get; } = new LocalDefinitionsService();

        public UniverseColonist()
        {
            DefinitionsService.LoadAllDefinitions();

            AllDefinitions = DefinitionsService.AllDefinitions;

            GameModel = new GameModels.GameModel(null, AllDefinitions);
        }
    }
}