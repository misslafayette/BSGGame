namespace BSGGame.GameLogic.Cards.Daybreak
{
    public class ConsultTheHybridCard : SkillCheckCrisisCard
    {
        public ConsultTheHybridCard()
        {
            Title = "Consult the Hybrid";
            BaseDifficulty = 10;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            PassEffect = "The current player draws a Mutiny Card and 2 SkilL Cards (they may be from outside their skill set).";
            FailEffect = "-1 Food, and shuffle 2 Treachery Cards into the Destiny deck.";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }
    public class DomesticDisputeCard : SkillCheckCrisisCard
    {
        public DomesticDisputeCard()
        {
            Title = "Domestic Dispute";
            BaseDifficulty = 9;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            FailEffect = "-1 Morale and the current player is sent to Sickbay.";
            FTL = false;
            CylonActivationType = CylonActivation.Raiders;
        }
    }

    public class GiveInToDespairCard : SkillCheckCrisisCard
    {
        public GiveInToDespairCard()
        {
            Title = "Give in to Despair";
            BaseDifficulty = 14;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            PassEffect = "No effect.";
            PartialPassValue = 9;
            PartialPassEffect = "-1 Food and the current player draws 3 Treachery Cards.";
            FailEffect = "-2 Morale.";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }

    public class HybridInPanicCard : SkillCheckCrisisCard
    {
        public HybridInPanicCard()
        {
            Title = "Hybrid in Panic";
            BaseDifficulty = 12;
            UsedSkills.Add(CardType.Tactics);
            UsedSkills.Add(CardType.Engineering);
            PassEffect = "Increase the Jump Preparation track by 1.";
            PartialPassValue = 8;
            PartialPassEffect = "The current player discards 2 Skill Cards.";
            FailEffect = "-1 Fuel.";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }

    public class IncitementToMutinyCard : SkillCheckCrisisCard
    {
        public IncitementToMutinyCard()
        {
            Title = "Incitement to Mutiny";
            BaseDifficulty = 13;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            PartialPassValue = 7;
            PartialPassEffect = "Shuffle 2 Treachery cards into the Destiny deck.";
            FailEffect = "Shuffle 4 Treachery cards into the Destiny deck.";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }

    public class InsubordinateCrewCard : SkillCheckCrisisCard
    {
        public InsubordinateCrewCard()
        {
            Title = "Insubordinate Crew";
            BaseDifficulty = 12;
            UsedSkills.Add(CardType.Leadership);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            FailEffect = "-1 Morale and each player that does not have a Mutiny Card draws 1 Mutiny Card.";
            FTL = false;
            CylonActivationType = CylonActivation.Raiders;
        }
    }

    public class QuorumInUproarCard : SkillCheckCrisisCard
    {
        public QuorumInUproarCard()
        {
            Title = "Quorum in Uproar";
            BaseDifficulty = 8;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            FailEffect = "The President discards 2 random Quorum Cards and 2 random Skill Cards.";
            FTL = false;
            CylonActivationType = CylonActivation.RaidersLaunch;
        }
    }

    public class RallyingSupportCard : SkillCheckCrisisCard
    {
        public RallyingSupportCard()
        {
            Title = "Rallying Support";
            BaseDifficulty = 8;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            FailEffect = "-1 Population and the current player draws 1 Mutiny Card and 1 Treachery Card.";
            FTL = true;
            CylonActivationType = CylonActivation.Raiders;
        }
    }

    public class ReactorCriticalCard : SkillCheckCrisisCard
    {
        public ReactorCriticalCard()
        {
            Title = "Reactor Critical";
            BaseDifficulty = 7;
            UsedSkills.Add(CardType.Tactics);
            UsedSkills.Add(CardType.Piloting);
            UsedSkills.Add(CardType.Engineering);
            PassEffect = "The current player draws 2 Treachery Cards.";
            FailEffect = "-1 Fuel.";
            FTL = false;
            CylonActivationType = CylonActivation.RaidersLaunch;
        }
    }

    public class RebuildTrustCard : SkillCheckCrisisCard
    {
        public RebuildTrustCard()
        {
            Title = "Rebuild Trust";
            BaseDifficulty = 9;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            PassEffect = "Each character in the Brig may move to any location on Galactica.";
            FailEffect = "-2 Morale.";
            FTL = false;
            CylonActivationType = CylonActivation.Raiders;
        }
    }
}
