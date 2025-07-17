namespace BSGGame.GameLogic
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


    }
}
