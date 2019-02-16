namespace Game.Data.Runtime
{
    public class PlayData : IPlayData
    {
        public int Xp { get; set; }
        public IGoods[] Goods { get; set; }
        public IWallet Wallet { get; set; }
    }
}
