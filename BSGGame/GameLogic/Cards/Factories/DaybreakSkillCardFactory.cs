using BSGGame.GameLogic.Cards.Daybreak;
using BSGGame.GameLogic.Cards.Pegasus;

namespace BSGGame.GameLogic.Cards.Factories
{
    public class DaybreakSkillCardFactory
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

            for (int i = 0; i < 2; i++)
                deck.Add(new ForceTheirHandCard(0));

            deck.Add(new PopularInfluenceCard(3));
            deck.Add(new PopularInfluenceCard(4));
            deck.Add(new NegotiationsCard(5));

            return deck;
        }

        public static List<SkillCard> BuildLeadershipDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 2; i++)
                deck.Add(new AllHandsOnDeckCard(0));

            deck.Add(new RestoreOrderCard(3));
            deck.Add(new RestoreOrderCard(4));
            deck.Add(new ChangeOfPlansCard(5));

            return deck;
        }

        public static List<SkillCard> BuildTacticsDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 2; i++)
                deck.Add(new QuickThinkingCard(1));

            deck.Add(new UnorthodoxPlansCard(3));
            deck.Add(new UnorthodoxPlansCard(4));
            deck.Add(new ASecondChanceCard(5));

            return deck;
        }

        public static List<SkillCard> BuildPilotingDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 2; i++)
                deck.Add(new DogfightCard(1));

            deck.Add(new CombatVeteranCard(3));
            deck.Add(new CombatVeteranCard(4));
            deck.Add(new LaunchReservesCard(5));

            return deck;
        }

        public static List<SkillCard> BuildEngineeringDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 2; i++)
                deck.Add(new InstallUpgradesCard(1));

            deck.Add(new RaptorSpecialistCard(3));
            deck.Add(new RaptorSpecialistCard(4));
            deck.Add(new TestTheLimitsCard(5));

            return deck;
        }

        public static List<SkillCard> BuildTreacheryDeck()
        {
            var deck = new List<SkillCard>();

            for (int i = 0; i < 6; i++)
                deck.Add(new BaitCard(0));

            for (int i = 0; i < 6; i++)
                deck.Add(new DradisContactCard(0));

            for (int i = 0; i < 4; i++)
                deck.Add(new PersonalVicesCard(3));

            for (int i = 0; i < 4; i++)
                deck.Add(new ABetterMachineCard(3));

            for (int i = 0; i < 3; i++)
                deck.Add(new ViolentOutburstsCard(4));

            for (int i = 0; i < 3; i++)
                deck.Add(new ExploitWeaknessCard(5));

            return deck;
        }
    }
}
