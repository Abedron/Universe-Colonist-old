﻿namespace Game.Data.Runtime
{
    public interface IWallet
    {
        int Stars { get; set; }
        int HyperMetal { get; set; }
        int Fuel { get; set; }
        int Ore { get; set; }
        int Minerals { get; set; }
        int Food { get; set; }
        int Colonist { get; set; }
    }
}