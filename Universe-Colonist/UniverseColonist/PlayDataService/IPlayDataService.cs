namespace Game.PlayDataService
{
    public interface IPlayDataService
    {
        IPlayData Load();
        void Save(IPlayData playData);
    }
}