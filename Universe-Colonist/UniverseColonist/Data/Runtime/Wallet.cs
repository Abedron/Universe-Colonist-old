﻿namespace Game.Data.Runtime
{
    public class Wallet : IWallet
    {
        public int Stars { get; set; }
        public int HyperMetal { get; set; }
        public int Fuel { get; set; }
        public int Ore { get; set; }
        public int Minerals { get; set; }
        public int Food { get; set; }
        public int Colonist { get; set; }
    }
}