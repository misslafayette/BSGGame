namespace BSGGame.GameLogic.Cards.Pegasus
{
    #region Politics
    public class InvestigativeCommitteeCard : SkillCard
     {
        public InvestigativeCommitteeCard(int value)
    {
        Type = CardType.Leadership;
        Value = value;
    }
    public override string Name => "Investigative Committee";
    public override string Description => "Play before cards are added to a Skill Check. All Skill Cards are played face up during this Skill Check (excluding from the Destiny deck).";
    }

    public class SupportThePeopleCard : SkillCard
    {
        public SupportThePeopleCard(int value)
    {
        Type = CardType.Leadership;
        Value = value;
    }
    public override string Name => "Support the People";
    public override string Description => "Reckless: Play before cards are added to a Skill Check. Each human player with 4 or less Skill Cards in hand may draw 2 Skill Cards.";
    }

    public class PreventativePolicyCard : SkillCard
    {
        public PreventativePolicyCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Preventative Policy";
        public override string Description => "Movement: Choose 1 resource type (Fuel, Food, Morale, or Population). The next loss of this resource type during this turn is reduced by 1.";
    }
    #endregion

    #region Leadership
    public class MajorVictoryCard : SkillCard
    {
        public MajorVictoryCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Major Victory";
        public override string Description => "Play after you destroy a Basestar or a Centurion on the Boarding Party Track. Roll a die. On a 5 or higher, gain 1 Morale. Limit of 1 Major Victory card used per turn.";
    }

    public class AtAnyCostCard : SkillCard
    {
        public AtAnyCostCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "At Any Cost";
        public override string Description => "Reckless: Play before cards are added to a Skill Check. All Treachery Cards in the Skill Check count as positive strength.";
    }
    #endregion

    #region Tactics
    public class GutsAndInitiativeCard : SkillCard
    {
        public GutsAndInitiativeCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Guts And Initiative";
        public override string Description => "Reckless: Play before cards are added to a Skill Check. Do not add cards from the Destiny deck into this Skill Check.";
    }

    public class CriticalSituationCard : SkillCard
    {
        public CriticalSituationCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Critical Situation";
        public override string Description => "Movement: Take 1 Action. Only 1 Critical Situation or Executive Order card may be used per turn.";
    }
    #endregion

    #region Piloting
    public class FullThrottleCard : SkillCard
    {
        public FullThrottleCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Full Throttle";
        public override string Description => "Movement or Action: If piloting a Viper, you may move to any space area. You may then attack 1 Cylon Ship in your area (even if you didn't move).";
    }

    public class RunInterferenceCard : SkillCard
    {
        public RunInterferenceCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Run Interference";
        public override string Description => "Play before Raiders are activated. The first 4 Raiders activating in your space area automatically miss (do not roll for them).";
    }
    #endregion

    #region Engineering
    public class JuryRiggedCard : SkillCard
    {
        public JuryRiggedCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Jury Rigged";
        public override string Description => "Play before Raiders are activated. The first 4 Raiders activating in your space area automatically miss (do not roll for them).";
    }

    public class CalculationsCard : SkillCard
    {
        public CalculationsCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Calculations";
        public override string Description => "Play before Raiders are activated. The first 4 Raiders activating in your space area automatically miss (do not roll for them).";
    }
    #endregion

    #region Treachery
    public class BroadcastLocationCard : SkillCard
    {
        public BroadcastLocationCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Broadcast Location";
        public override string Description => "Reckless Skill Check: Place 1 Basestar in front of Galactica and 1 Civilian Ship behind Galactica. Only one of this ability may be resolved in each Skill Check.";
    }

    public class ByYourCommandCard : SkillCard
    {
        public ByYourCommandCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "By Your Command";
        public override string Description => "Reckless Skill Check: Activate all Raiders, Heavy Raiders and occupation forces (but not Centurions). Only 1 of this ability may be resolved in each Skill Check.";
    }

    public class SpecialDestinyCard : SkillCard
    {
        public SpecialDestinyCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Special Destiny";
        public override string Description => "Reckless Skill Check: Each player draws 1 Treachery Skill Card. Only 1 of this ability may be resolved in each Skill Check.";
    }

    public class GodsPlanCard : SkillCard
    {
        public GodsPlanCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "God's Plan";
        public override string Description => "Movement: Exchange this card with the top card of the Destiny deck.";
    }

    public class HumanWeaknessCard : SkillCard
    {
        public HumanWeaknessCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Human Weakness";
        public override string Description => "Action: If at least 1 human player is in the Brig or Detention location, reduce the highest resource by 1.";
    }

    public class SabotageCard : SkillCard
    {
        public SabotageCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Sabotage";
        public override string Description => "Play when a human player discards a Treachery Skill Card. Damage Galactica. Only 1 Sabotage card may be used per turn.";
    }
    #endregion
}
