namespace Game.DataModel.Runtime
{
    public class BuildingDataBase<TDefinition, TStorage>
    {
        protected TDefinition[] Definition { get; }
        protected TStorage Storage { get; }

        public bool IsActivated { get; set; }
        public int Level { get; set; }

        public BuildingDataBase(TDefinition[] definition, TStorage storage)
        {
            Definition = definition;
            Storage = storage;
        }
    }
}