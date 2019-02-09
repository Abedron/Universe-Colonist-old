namespace Game.StockService
{
    public interface IConfigurationStock
    {
        int Xp { get; set; }
        IGoods[] Goods { get; set; }
    }
}