namespace Game.PlayDataService
{
    public interface IPlayData
    {
        int Xp { get; set; }
        IGoods[] Goods { get; set; }
        IWallet Wallet { get; set; }
    }

    public interface IGoods
    {
        int BuildingType { get; set; }
        int Level { get; set; }
    }

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