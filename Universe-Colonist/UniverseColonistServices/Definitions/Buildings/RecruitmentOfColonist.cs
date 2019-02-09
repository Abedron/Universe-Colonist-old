using Game.Buildings;

namespace Game.Services.Definitions.Buildings
{
    public class RecruitmentOfColonist : ILeveling
    {
        public int Xp { get; internal set; }
        public int Level { get; internal set; }
        public string Value { get; internal set; }
    }
}