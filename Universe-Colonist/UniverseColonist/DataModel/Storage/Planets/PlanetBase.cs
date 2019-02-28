namespace Game.DataModel.Storage
{
    public class PlanetBase : IRaiseStorage
    {
        public bool IsActivated { get; set; }
        public int Level { get; set; }
        public int Colonist { get; set; }
    }
}