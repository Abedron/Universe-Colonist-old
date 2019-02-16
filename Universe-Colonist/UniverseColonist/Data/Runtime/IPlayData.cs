namespace Game.Data.Runtime
{
    public interface IPlayData
    {
        int Xp { get; set; }
        IGoods[] Goods { get; set; }
        IWallet Wallet { get; set; }
    }
}