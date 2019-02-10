namespace Game.PlayDataService
{
    public interface IPlayData
    {
        int Xp { get; set; }
        IGoods[] Goods { get; set; }
    }

    public interface IGoods
    {
        int BuildingType { get; set; }
        int Level { get; set; }
    }
}