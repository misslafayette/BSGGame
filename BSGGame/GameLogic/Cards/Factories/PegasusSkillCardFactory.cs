using BSGGame.GameLogic.Cards.Pegasus;

namespace BSGGame.GameLogic.Cards.Factories
{
    public class PegasusSkillCardFactory
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
                [CardType.Treachery] = BuildTreacheryDeck()
            };

            return decks;
        }

        public static List<SkillCard> BuildPoliticsDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 4; i++)
                deck.Add(new InvestigativeCommitteeCard(3));

            for (int i = 0; i < 2; i++)
                deck.Add(new InvestigativeCommitteeCard(4));

            deck.Add(new InvestigativeCommitteeCard(5));
            deck.Add(new SupportThePeopleCard(1));
            deck.Add(new SupportThePeopleCard(2));
            deck.Add(new PreventativePolicyCard(3));
            deck.Add(new PreventativePolicyCard(4));
            deck.Add(new PreventativePolicyCard(5));

            return deck;
        }

        public static List<SkillCard> BuildLeadershipDeck()
        {
            var deck = new List<SkillCard>();

            deck.Add(new MajorVictoryCard(1));
            deck.Add(new MajorVictoryCard(2));
            deck.Add(new AtAnyCostCard(3));
            deck.Add(new AtAnyCostCard(4));
            deck.Add(new AtAnyCostCard(5));

            return deck;
        }

        public static List<SkillCard> BuildTacticsDeck()
        {
            var deck = new List<SkillCard>();

            deck.Add(new GutsAndInitiativeCard(1));
            deck.Add(new GutsAndInitiativeCard(2));
            deck.Add(new CriticalSituationCard(3));
            deck.Add(new CriticalSituationCard(4));
            deck.Add(new CriticalSituationCard(5));

            return deck;
        }

        public static List<SkillCard> BuildPilotingDeck()
        {
            var deck = new List<SkillCard>();

            deck.Add(new FullThrottleCard(1));
            deck.Add(new FullThrottleCard(2));
            deck.Add(new RunInterferenceCard(3));
            deck.Add(new RunInterferenceCard(4));
            deck.Add(new RunInterferenceCard(5));

            return deck;
        }

        public static List<SkillCard> BuildEngineeringDeck()
        {
            var deck = new List<SkillCard>();

            deck.Add(new JuryRiggedCard(1));
            deck.Add(new JuryRiggedCard(2));
            deck.Add(new CalculationsCard(3));
            deck.Add(new CalculationsCard(4));
            deck.Add(new CalculationsCard(5));

            return deck;
        }

        public static List<SkillCard> BuildTreacheryDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 8; i++)
                deck.Add(new BroadcastLocationCard(1));

            for (int i = 0; i < 4; i++)
                deck.Add(new ByYourCommandCard(2));

            for (int i = 0; i < 5; i++)
                deck.Add(new SpecialDestinyCard(2));

            for (int i = 0; i < 3; i++)
                deck.Add(new GodsPlanCard(2));

            for (int i = 0; i < 2; i++)
                deck.Add(new HumanWeaknessCard(3));

            for (int i = 0; i < 4; i++)
                deck.Add(new SabotageCard(3));

            return deck;
        }
    }
}
