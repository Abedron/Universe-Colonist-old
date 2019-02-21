namespace Game.GameModels.Buildings
{
    public class BuildingBase<TData>
    {
        protected TData Data { get; }

        public BuildingBase(TData data)
        {
            Data = data;
        }
    }
}
