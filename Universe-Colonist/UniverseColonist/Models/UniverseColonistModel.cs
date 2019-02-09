namespace Game
{
    public class UniverseColonistModel
    {
        public int Xp { get; private set; }

        public void AddXp(int xp)
        {
            Xp += xp;
        }
    }
}
