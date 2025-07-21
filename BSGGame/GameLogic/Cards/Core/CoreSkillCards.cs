using BSGGame.GameLogic.Cards;

namespace BSGGame.GameLogic.Cards.Core
{
    #region Politics
    public class ConsolidatePowerCard : SkillCard
     {
        public ConsolidatePowerCard(int value)
    {
        Type = CardType.Politics;
        Value = value;
    }
    public override string Name => "Consolidate Power";
    public override string Description => "Action: Draw 2 Skill Cards of any type(s). They may come from outside you skill set.";
    }

    public class InvestigativeCommitteeCard : SkillCard
     {
        public InvestigativeCommitteeCard(int value)
    {
        Type = CardType.Politics;
        Value = value;
    }
    public override string Name => "Investigative Committee";
    public override string Description => "Play before cards are added to a Skill Check. All Skill Cards are played face up during the Skill Check (including from the Destiny deck).";
}
#endregion

#region Leadership

public class ExecutiveOrderCard : SkillCard
    {
        public ExecutiveOrderCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Executive Order";
        public override string Description => "Action: Choose any other player. They may move theri character and then take 1 Action OR not move and take 2 Actions.";
    }

    public class DeclareEmergencyCard : SkillCard
    {
        public DeclareEmergencyCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Declare Emergency";
        public override string Description => "Play after strength i stotaled in a Skill Check to reduce its Difficulty by 2. Limit of 1 Declare Emergency card used per Skill Check.";
    }
    #endregion

    #region Tactics
    public class LaunchScoutCard : SkillCard
    {
        public LaunchScoutCard(int value)
        {
            Type = CardType.Tactics;
            Value = value;
        }
        public override string Name => "Launch Scout";
        public override string Description => "Action: Risk 1 Raptor to roll a die. On a 3 or higher, look at the top card of the Crisis or Destination deck and place it on the top or the bottom. Otherwise, destroy 1 raptor.";
    }

    public class StrategicPlanningCard : SkillCard
    {
        public StrategicPlanningCard(int value)
        {
            Type = CardType.Tactics;
            Value = value;
        }
        public override string Name => "StrategicPlanning";
        public override string Description => "Play before any die roll to add 2 to the result. Limit of 1 Strategic Planning card used per die roll.";
    }
    #endregion

    #region Engineering
    public class RepairCard : SkillCard
    {
        public RepairCard(int value)
        {
            Type = CardType.Engineering;
            Value = value;
        }
        public override string Name => "Repair";
        public override string Description => "Repair a damaged location.";
    }

    public class ScientificResearchCard : SkillCard
    {
        public ScientificResearchCard(int value)
        {
            Type = CardType.Engineering;
            Value = value;
        }
        public override string Name => "Scientific Research";
        public override string Description => "Play before cards are added to a Skill Check. All Engineering Skill Cards in the Skill Check count as positive strength.";
    }
    #endregion

    #region Piloting
    public class EvasiveManeuversCard : SkillCard
    {
        public EvasiveManeuversCard(int value)
        {
            Type = CardType.Piloting;
            Value = value;
        }
        public override string Name => "Evasive Maneuvers";
        public override string Description => "Play after any Viper is attacked to reroll the die. If the Viper is piloted, subtract 2 from the new roll.";
    }

    public class MaximumFirepowerCard : SkillCard
    {
        public MaximumFirepowerCard(int value)
        {
            Type = CardType.Piloting;
            Value = value;
        }
        public override string Name => "Scientific Research";
        public override string Description => "Action: Play while piloting a Viper to attack up to 4 times.";
    }
    #endregion
}

