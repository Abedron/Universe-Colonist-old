namespace Game.Data.Runtime
{
    public interface IPlayDataService
    {
        IPlayData Load();
        void Save(IPlayData playData);
    }
}