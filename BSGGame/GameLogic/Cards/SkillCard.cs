namespace BSGGame.GameLogic.Cards
{
    public enum CardType
    {
        Politics,
        Engineering,
        Piloting,
        Leadership,
        Tactics,
        Treachery
    }

    public class SkillCard
    {
        public CardType Type { get; set; }
        public int Value { get; set; }

        public virtual string Name => $"{Type} {Value}";
        public virtual string Description => "Generic Skill Card";
    }
}
