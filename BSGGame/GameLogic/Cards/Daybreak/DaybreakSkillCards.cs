using BSGGame.GameLogic.Cards;

namespace BSGGame.GameLogic.Cards.Daybreak
{
    #region Politics
    public class ForceTheirHandCard : SkillCard
     {
        public ForceTheirHandCard(int value)
    {
        Type = CardType.Politics;
        Value = value;
    }
    public override string Name => "Force Their Hand";
    public override string Description => "Skill Check: If the current player is a human player, they may play 1 Skill Card face up into this check. If he does not, they must draw 1 Mutiny Card.";
    }
    public class PopularInfluenceCard : SkillCard
    {
        public PopularInfluenceCard(int value)
    {
    Type = CardType.Politics;
    Value = value;
    }
    public override string Name => "Popular Influence";
    public override string Description => "Action: Draw 2 Quorum Cards and choose 1 to give to the President. Then, either play or discard the other card.";
    }

    public class NegotiationsCard : SkillCard
    {
        public NegotiationsCard(int value)
        {
            Type = CardType.Politics;
            Value = value;
        }
        public override string Name => "Negotiations";
        public override string Description => "Action: Place a Basestar in front of Galactica and draw a Politics Skill Card. Do not launch or activate any Cylon ships for the rest of this turn.";
    }
    #endregion

    #region Leadership
    public class AllHandsOnDeckCard : SkillCard
    {
        public AllHandsOnDeckCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "All Hands on Deck";
        public override string Description => "Skill Check: For each Skill Card in this Skill Check with a strength of 0, add 1 to the ckeck's total strength.";
    }
    public class RestoreOrderCard : SkillCard
    {
        public RestoreOrderCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Restore Order";
        public override string Description => "Play before cards are added to a Skill Check. Do not resolve Skill Check abilities while resolving this skill check.";
    }
    public class ChangeOfPlansCard : SkillCard
    {
        public ChangeOfPlansCard(int value)
        {
            Type = CardType.Leadership;
            Value = value;
        }
        public override string Name => "Change of Plans";
        public override string Description => "Play this card after a Skill Check is passed. Instead of resolving the Pass result, each human player draws 2 Skill Cards.";
    }
    #endregion

    #region Tactics
    public class QuickThinkingCard : SkillCard
    {
        public QuickThinkingCard(int value)
        {
            Type = CardType.Tactics;
            Value = value;
        }
        public override string Name => "Quick Thinking";
        public override string Description => "Play this card after a Skill Check is passed. Instead of resolving the Pass result, each human player draws 2 Skill Cards.";
    }

    public class UnorthodoxPlansCard : SkillCard
    {
        public UnorthodoxPlansCard(int value)
        {
            Type = CardType.Tactics;
            Value = value;
        }
        public override string Name => "Unorthodox Plans";
        public override string Description => "Action: Activate one of the following locations, even if it is damaged: Command, Armory, Weapons Control, or Communications.";
    }

    public class ASecondChanceCard : SkillCard
    {
        public ASecondChanceCard(int value)
        {
            Type = CardType.Tactics;
            Value = value;
        }
        public override string Name => "A Second Chance";
        public override string Description => "Play before cards are added to a Skill Check. If the Check passes the printed Difficulty by 4 or more, the current player gains 1 Miracle token.";
    }
    #endregion

    #region Piloting
    public class DogfightCard : SkillCard
    {
        public DogfightCard(int value)
        {
            Type = CardType.Piloting;
            Value = value;
        }
        public override string Name => "Dogfight";
        public override string Description => "Skill Check: The current player may damage 1 Viper in a space area or in the Reservers to remove 1 other card from this Skill Check.";
    }

    public class CombatVeteranCard : SkillCard
    {
        public CombatVeteranCard(int value)
        {
            Type = CardType.Piloting;
            Value = value;
        }
        public override string Name => "Combat Veteran";
        public override string Description => "Action: Choose 1 unmanned Viper in the Reservers or a space area and activate it up to 3 times.";
    }

    public class LaunchReservesCard : SkillCard
    {
        public LaunchReservesCard(int value)
        {
            Type = CardType.Piloting;
            Value = value;
        }
        public override string Name => "Launch Reserves";
        public override string Description => "Action: Place up to 2 unmanned Vipers from the Reserves into a space area containing a piloted Viper. Then, activate those unmanned Vipers.";
    }
    #endregion

    #region Engineering
    public class InstallUpgradesCard : SkillCard
    {
        public InstallUpgradesCard(int value)
        {
            Type = CardType.Engineering;
            Value = value;
        }
        public override string Name => "Install Upgrades";
        public override string Description => "Skill Check: If this Skill Check passes, the current player draws 2 Engineering Skill Cards. If it fails, they draws 1 Engineering Skill Card.";
    }

    public class RaptorSpecialistCard : SkillCard
    {
        public RaptorSpecialistCard(int value)
        {
            Type = CardType.Engineering;
            Value = value;
        }
        public override string Name => "RaptorSpecialist";
        public override string Description => "Action: Either destroy a Raptor to gain an Assault Raptor or return a destroyed Raptor to the Reserves.";
    }

    public class TestTheLimitsCard : SkillCard
    {
        public TestTheLimitsCard(int value)
        {
            Type = CardType.Engineering;
            Value = value;
        }
        public override string Name => "Test the Limits";
        public override string Description => "Action: If the Fleet Marker is not on a blue space of the Jump Preparation track, increase the track by 1 and roll a die. On a 5 or lower, damage Galactica.";
    }
    #endregion

    #region Treachery
    public class BaitCard : SkillCard
    {
        public BaitCard(int value)
        {
            Type = CardType.Treachery;
            Value = value;
        }
        public override string Name => "Bait";
        public override string Description => "Skill Check: Place 1 Civilian Ship behind Galactica. When a player chooses to discard this card, he draws 1 Mutiny Card.";
    }

    public class DradisContactCard : SkillCard
    {
        public DradisContactCard(int value)
        {
            Type = CardType.Treachery;
            Value = value;
        }
        public override string Name => "Dradis Contact";
        public override string Description => "Skill Check: Place 2 Raiders in front of Galactica. When a player chooses to discard this card, they draw 1 Mutiny Card.";
    }

    public class PersonalVicesCard : SkillCard
    {
        public PersonalVicesCard(int value)
        {
            Type = CardType.Treachery;
            Value = value;
        }
        public override string Name => "Personal Vices";
        public override string Description => "Skill Check: Each human player draws 1 Treachery Card. If the current player is a human player, the current player also draws 1 Mutiny Card.";
    }

    public class ABetterMachineCard : SkillCard
    {
        public ABetterMachineCard(int value)
        {
            Type = CardType.Treachery;
            Value = value;
        }
        public override string Name => "A Better Machine";
        public override string Description => "Skill Check: The current player shuffles 2 Treachery Cards into the Destiny deck.";
    }

    public class ViolentOutburstsCard : SkillCard
    {
        public ViolentOutburstsCard(int value)
        {
            Type = CardType.Treachery;
            Value = value;
        }
        public override string Name => "Violent Outbursts";
        public override string Description => "Skill Check: The current player is sent to the Sickbay location.";
    }

    public class ExploitWeaknessCard : SkillCard
    {
        public ExploitWeaknessCard(int value)
        {
            Type = CardType.Treachery;
            Value = value;
        }
        public override string Name => "Exploit Weakness";
        public override string Description => "Skill Check: The current player must choose a human player to draw 1 Mutiny Cardô.";
    }
    #endregion
}
