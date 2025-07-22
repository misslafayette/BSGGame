namespace BSGGame.GameLogic.Cards
{
    public enum CylonActivation
    {
        Raiders,
        RaidersLaunch,
        HeavyRaiders,
        BasestarAttacks,
    }
    public enum ChoosingPlayer
    {
        CurrentPlayer,
        Admiral,
        President,
        CAG
    }

    public class CrisisCard
    {
        public virtual required string Title { get; set; }
        public string? Text { get; set; }
        public bool FTL { get; set; }
        public CylonActivation CylonActivationType {get; set;}
    }

    public class SkillCheckCrisisCard : CrisisCard
    {
        public int BaseDifficulty { get; set; }
        public List<CardType> UsedSkills { get; set; } = new();
        public required string PassEffect { get; set; }
        public string? PartialPassEffect { get; set; }
        public int? PartialPassValue { get; set; }
        public required string FailEffect { get; set; }

    }
    public class OptionalSkillCheckCard : SkillCheckCrisisCard
    {
        public ChoosingPlayer DecidingPlayer { get; set; }
        public required string OptionB {  get; set; }

    }

    public class ChoiceCard : CrisisCard
    {
        public ChoosingPlayer Type { get; set; }
        public required string OptionA { get; set; }
        public required string OptionB { get; set; }
    }
    public class CylonAttack : CrisisCard
    {
        public required string Setup { get; set; }
        public required string SpecialRule { get; set; }
    }
}