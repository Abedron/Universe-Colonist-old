namespace Game.StockService
{
    public interface IStockService
    {
        IConfigurationStock Load();
        void Save(IConfigurationStock configurationStock);
    }
}