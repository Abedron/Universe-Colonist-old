﻿namespace Game.DataModel.Storage
{
    public class GameplayStorage
    {
        public Player Player { get; set; } = new Player();
        public Buildings Buildings { get; } = new Buildings();
        public Cash Cash { get; } = new Cash();

        // Items
        public Planets Planets { get; } = new Planets();
        public Rockets Rockets { get; } = new Rockets();
    }
}
