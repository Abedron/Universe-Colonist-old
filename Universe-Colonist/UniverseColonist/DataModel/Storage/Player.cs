namespace Game.DataModel.Storage
{
    public class Player : IRaisingStorage
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
    }
}
