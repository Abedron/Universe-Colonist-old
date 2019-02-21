namespace Game.Data.Runtime
{
    public class BuildingDataBase<TDefinition, DStorage>
    {
        protected TDefinition[] Definition { get; }
        protected DStorage Storage { get; }

        public bool IsActivated { get; set; }
        public int Level { get; set; }

        public BuildingDataBase(TDefinition[] definition, DStorage storage)
        {
            Definition = definition;
            Storage = storage;
        }
    }
}