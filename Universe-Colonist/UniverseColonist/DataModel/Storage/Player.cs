namespace Game.DataModel.Storage
{
    public class Player : IRaiseStorage
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
    }
}
