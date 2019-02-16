namespace Game.Data.Permanent
{
    public class Play
    {
        public Player Player { get; set; } = new Player();
        public Building Buildings { get; } = new Building();
        public Cash Cash { get; } = new Cash();
    }
}
