namespace BSGGame.GameLogic.Cards.Exodus
{
    public class AirlockLeakCard : SkillCheckCrisisCard
    {
        public AirlockLeakCard()
        {
            Title = "Airlock Leak";
            BaseDifficulty = 6;
            UsedSkills.Add(CardType.Tactics);
            UsedSkills.Add(CardType.Engineering);
            PassEffect = "No effect.";
            FailEffect = "Damage Galactica and the current player is sent to Sickbay.";
            FTL = false;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }

    public class CenturionAssaultCard : SkillCheckCrisisCard
    {
        public CenturionAssaultCard()
        {
            Title = "Centurion Assaults";
            BaseDifficulty = 9;
            UsedSkills.Add(CardType.Tactics);
            UsedSkills.Add(CardType.Piloting);
            PassEffect = "No effect.";
            FailEffect = "Destroy 1 Raptor and the current player is sent to Sickbay.";
            FTL = false;
            CylonActivationType = CylonActivation.RaidersLaunch;
        }
    }

    public class DivisiveBehaviorCard : SkillCheckCrisisCard
    {
        public DivisiveBehaviorCard()
        {
            Title = "Divisive Behavior";
            BaseDifficulty = 10;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            FailEffect = "-1 Morale.";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }
}
