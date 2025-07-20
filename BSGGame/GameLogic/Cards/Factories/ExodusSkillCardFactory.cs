using BSGGame.GameLogic.Cards.Exodus;

namespace BSGGame.GameLogic.Cards.Factories
{
    public class ExodusSkillCardFactory
    {
        public static Dictionary<CardType, List<SkillCard>> BuildAllDecks()
        {
            var decks = new Dictionary<CardType, List<SkillCard>>
            {
                [CardType.Politics] = BuildPoliticsDeck(),
                [CardType.Leadership] = BuildLeadershipDeck(),
                [CardType.Tactics] = BuildTacticsDeck(),
                [CardType.Piloting] = BuildPilotingDeck(),
                [CardType.Engineering] = BuildEngineeringDeck(),
            };

            return decks;
        }

        public static List<SkillCard> BuildPoliticsDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 4; i++)
                deck.Add(new RedTapeCard(0));

            deck.Add(new PoliticalProwessCard(6));

            return deck;
        }

        public static List<SkillCard> BuildLeadershipDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 4; i++)
                deck.Add(new IronWillCard(0));

            deck.Add(new StateOfEmergencyCard(6));

            return deck;
        }

        public static List<SkillCard> BuildTacticsDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 4; i++)
                deck.Add(new TrustInstinctsCard(0));

            deck.Add(new ScoutingForFuelCard(6));

            return deck;
        }

        public static List<SkillCard> BuildPilotingDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 4; i++)
                deck.Add(new ProtectTheFleetCard(0));

            deck.Add(new BestOfTheBestCard(6));

            return deck;
        }

        public static List<SkillCard> BuildEngineeringDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 4; i++)
                deck.Add(new EstablishNetworkCard(0));

            deck.Add(new BuildNukeCard(6));

            return deck;
        }
    }
}
