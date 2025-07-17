namespace BSGGame.GameLogic
{

    public enum Loyalty
    {
        Human,
        Cylon
    }

    public class Player
    {
        public string Name { get; set; }
        public Loyalty Loyalty { get; set; }

        public List<SkillCard> Cards { get; set; } = new();

        public bool HasDrawn { get; set; } = false;
    }
}
