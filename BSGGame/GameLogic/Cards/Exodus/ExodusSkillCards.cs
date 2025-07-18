using BSGGame.GameLogic.Cards;

namespace BSGGame.GameLogic.Cards.Exodus
{
    #region Politics
    public class RedTapeCard : SkillCard
     {
        public RedTapeCard(int value)
    {
        Type = CardType.Leadership;
        Value = value;
    }
    public override string Name => "Red Tape";
    public override string Description => "Skill Check: Discard all 5 and 6 Strength cards from this Skill Check.";
    }
    public class PoliticalProwessCard : SkillCard
    {
        public PoliticalProwessCard(int value)
    {
        Type = CardType.Leadership;
        Value = value;
    }
    public override string Name => "Political Prowess";
    public override string Description => "Play before making a Skill Check triggered by a location. Do not make the Skill Check; instead, it automatically passes or fails (your choice).";
    }
    #endregion

    #region Leadership
    public class IronWillCard : SkillCard
    {
        public IronWillCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Iron Will";
        public override string Description => "Skill Check: If total Strength in the Skill Check is within 4 of the Difficulty, do not trigger the Fail effect. If total Strength in the Skill Check is 0 or less, lose 1 Morale.";
    }
    public class StateOfEmergencyCard : SkillCard
    {
        public StateOfEmergencyCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "State of Emergency";
        public override string Description => "Action: Lose 1 Food. Each player may then move or take 1 Action (starting with the player who played this card and proceeding clockwise).";
    }
    #endregion

    #region Tactics
    public class TrustInstinctsCard : SkillCard
    {
        public TrustInstinctsCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Trust Instincts";
        public override string Description => "Skill Check: Add the top 2 cards from the Destiny deck face up into this skill check (before totaling strength).";
    }

    public class ScoutingForFuelCard : SkillCard
    {
        public ScoutingForFuelCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Scouting for Fuel";
        public override string Description => "Action: Risk 1 Raptor to roll 1 die. If you roll 4+, gain 1 Fuel. Otherwise destroy the Raptor.";
    }
    #endregion

    #region Piloting
    public class ProtectTheFleetCard : SkillCard
    {
        public ProtectTheFleetCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Protect the Fleet";
        public override string Description => "Skill Check: If at least 3 strength in Piloting Skill Cards are in the Skill Check, the current player may activate one unmanned Viper.";
    }

    public class BestOfTheBestCard : SkillCard
    {
        public BestOfTheBestCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Best of the Best";
        public override string Description => "Play before a piloted Viper makes an attack. Instead of rolling the attack, roll a die and destroy that many Raiders in the Viper's space area.";
    }
    #endregion

    #region Engineering
    public class EstablishNetworkCard : SkillCard
    {
        public EstablishNetworkCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Establish Network";
        public override string Description => "Skill Check: Each Engineering Skill Card in this Skill Check counts as double Strength.";
    }

    public class BuildNukeCard : SkillCard
    {
        public BuildNukeCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Build Nuke";
        public override string Description => "Play before a piloted Viper makes an attack. Instead of rolling the attack, roll a die and destroy that many Raiders in the Viper's space area.";
    }
    #endregion
}
