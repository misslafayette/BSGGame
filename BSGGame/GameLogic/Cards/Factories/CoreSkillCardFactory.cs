using BSGGame.GameLogic.Cards.Core;

namespace BSGGame.GameLogic.Cards.Factories
{
    public static class CoreSkillCardFactory
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

            for (int i = 0; i < 8; i++)
                deck.Add(new ConsolidatePowerCard(1));

            for (int i = 0; i < 6; i++)
                deck.Add(new ConsolidatePowerCard(2));

            for (int i = 0; i < 4; i++)
                deck.Add(new InvestigativeCommitteeCard(3));

            for (int i = 0; i < 2; i++)
                deck.Add(new InvestigativeCommitteeCard(4));

            deck.Add(new InvestigativeCommitteeCard(5));

            return deck;
        }

        public static List<SkillCard> BuildLeadershipDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 8; i++)
                deck.Add(new ExecutiveOrderCard(1));

            for (int i = 0; i < 6; i++)
                deck.Add(new ExecutiveOrderCard(2));

            for (int i = 0; i < 4; i++)
                deck.Add(new DeclareEmergencyCard(3));

            for (int i = 0; i < 2; i++)
                deck.Add(new DeclareEmergencyCard(4));

            deck.Add(new DeclareEmergencyCard(5));

            return deck;
        }

        public static List<SkillCard> BuildTacticsDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 8; i++)
                deck.Add(new LaunchScoutCard(1));

            for (int i = 0; i < 6; i++)
                deck.Add(new LaunchScoutCard(2));

            for (int i = 0; i < 4; i++)
                deck.Add(new StrategicPlanningCard(3));

            for (int i = 0; i < 2; i++)
                deck.Add(new StrategicPlanningCard(4));

            deck.Add(new StrategicPlanningCard(5));

            return deck;
        }

        public static List<SkillCard> BuildPilotingDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 8; i++)
                deck.Add(new EvasiveManeuversCard(1));

            for (int i = 0; i < 6; i++)
                deck.Add(new EvasiveManeuversCard(2));

            for (int i = 0; i < 4; i++)
                deck.Add(new MaximumFirepowerCard(3));

            for (int i = 0; i < 2; i++)
                deck.Add(new MaximumFirepowerCard(4));

            deck.Add(new MaximumFirepowerCard(5));

            return deck;
        }

        public static List<SkillCard> BuildEngineeringDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 8; i++)
                deck.Add(new RepairCard(1));

            for (int i = 0; i < 6; i++)
                deck.Add(new RepairCard(2));

            for (int i = 0; i < 4; i++)
                deck.Add(new ScientificResearchCard(3));

            for (int i = 0; i < 2; i++)
                deck.Add(new ScientificResearchCard(4));

            deck.Add(new ScientificResearchCard(5));

            return deck;
        }
    }
}
