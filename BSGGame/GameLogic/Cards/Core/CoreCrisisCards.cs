using BSGGame.GameLogic.Cards;

namespace BSGGame.GameLogic.Cards.Core

{
    public class CrashLandingCard : SkillCheckCrisisCard
    {
        public CrashLandingCard()
            {
            Title = "Crash Landing";
            BaseDifficulty = 6;
            UsedSkills.Add(CardType.Tactics);
            UsedSkills.Add(CardType.Piloting);
            PassEffect = "No effect.";
            FailEffect = "The Admiral may spend 1 Fuel. If they do not, -1 Morale, and the current player is sent to Sickbay.";
            FTL = false;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }

    public class CylonAccusationCard : SkillCheckCrisisCard
    {
        public CylonAccusationCard()
        {
            Title = "Cylon Accusation";
            BaseDifficulty = 10;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            FailEffect = "The current player is placed in the Brig location";
            FTL = false;
            CylonActivationType = CylonActivation.Raiders;
        }
    }

    public class CylonTrackingDeviceCard : SkillCheckCrisisCard
    {
        public CylonTrackingDeviceCard()
        {
            Title = "Cylon Tracking Device";
            BaseDifficulty = 10;
            UsedSkills.Add(CardType.Tactics);
            UsedSkills.Add(CardType.Piloting);
            UsedSkills.Add(CardType.Engineering);
            PassEffect = "No effect.";
            FailEffect = "Destroy 1 Raptor and place a Basestar in front of Galactica and 2 Civilian Ships behind it.";
            FTL = false;
            CylonActivationType = CylonActivation.Raiders;
        }
    }

    public class CylonVirusCard : SkillCheckCrisisCard
    {
        public CylonVirusCard()
        {
            Title = "Cylon Virus";
            BaseDifficulty = 13;
            UsedSkills.Add(CardType.Tactics);
            UsedSkills.Add(CardType.Engineering);
            PassEffect = "No effect.";
            FailEffect = "All characters in FTL Control are sent to Sickbay. Then place 1 Centurion marker at the start of the Boarding Party track.";
            FTL = false;
            CylonActivationType = CylonActivation.RaidersLaunch;
        }
    }

    public class DetectorSabotageCard : SkillCheckCrisisCard
    {
        public DetectorSabotageCard()
        {
            Title = "Cylon Virus";
            BaseDifficulty = 8;
            UsedSkills.Add(CardType.Leadership);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            FailEffect = "All characters in Research Lab are sent to Sickbay. Keep this card in play. Players may not look at other players' Loyalty Cards.";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }

    public class ElectionsLoomCard : SkillCheckCrisisCard
    {
        public ElectionsLoomCard()
        {
            Title = "Elections Loom";
            BaseDifficulty = 8;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            PassEffect = "No effect.";
            PartialPassValue = 5;
            PartialPassEffect = "-1 Morale";
            FailEffect = "-1 Morale, and the President discards 4 Skill Cards.";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }

    public class GuiltByCollusionCard : SkillCheckCrisisCard
    {
        public GuiltByCollusionCard()
        {
            Title = "Elections Loom";
            BaseDifficulty = 9;
            UsedSkills.Add(CardType.Leadership);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "The current player may choose a character to move to the Brig.";
            FailEffect = "-1 Morale";
            FTL = true;
            CylonActivationType = CylonActivation.Raiders;
        }
    }

    public class HangarAccidentCard : SkillCheckCrisisCard
    {
        public HangarAccidentCard()
        {
            Title = "Hangar Accident";
            BaseDifficulty = 10;
            UsedSkills.Add(CardType.Tactics);
            UsedSkills.Add(CardType.Piloting);
            UsedSkills.Add(CardType.Engineering);
            PassEffect = "No effect.";
            FailEffect = "-1 Population and damage 2 Vipers in the Reserves.";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }

    public class JumpComputerFailureCard : SkillCheckCrisisCard
    {
        public JumpComputerFailureCard()
        {
            Title = "Jump Computer Failure";
            BaseDifficulty = 7;
            UsedSkills.Add(CardType.Tactics);
            UsedSkills.Add(CardType.Engineering);
            PassEffect = "No effect.";
            FailEffect = "-1 Population and move the Fleet token 1 space towards the start of the Jump Prep track.";
            FTL = true;
            CylonActivationType = CylonActivation.RaidersLaunch;
        }
    }

    public class LegendaryDiscoveryCard : SkillCheckCrisisCard
    {
        public LegendaryDiscoveryCard()
        {
            Title = "Legendary Discovery";
            BaseDifficulty = 14;
            UsedSkills.Add(CardType.Tactics);
            UsedSkills.Add(CardType.Piloting);
            PassEffect = "Place this card next to the Kobol Objective card. It counts as 1 distance.";
            FailEffect = "-1 Food and destroy 1 Raptor.";
            FTL = false;
            CylonActivationType = CylonActivation.RaidersLaunch;
        }
    }

    public class LossOfAFriendCard : SkillCheckCrisisCard
    {
        public LossOfAFriendCard()
        {
            Title = "Loss of a Friend";
            BaseDifficulty = 9;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            PassEffect = "No effect.";
            PartialPassValue = 7;
            PartialPassEffect = "The current player discards 2 Skill Cards.";
            FailEffect = "-1 Morale, and the current player discards 2 Skill Cards.";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }

    public class LowSuppliesCard : SkillCheckCrisisCard
    {
        public LowSuppliesCard()
        {
            Title = "Low Supplies";
            BaseDifficulty = 7;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            PassEffect = "No effect.";
            FailEffect = "-1 Morale. If Food is less than 6, -1 addutional Morale.";
            FTL = false;
            CylonActivationType = CylonActivation.Raiders;
        }
    }

    public class MandatoryTestingCard : SkillCheckCrisisCard
    {
        public MandatoryTestingCard()
        {
            Title = "Mandatory Testing";
            BaseDifficulty = 13;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            PassEffect = "The President looks at 1 random Loyalty card of the Current Player.";
            PartialPassValue = 9;
            PartialPassEffect = "No effect.";
            FailEffect = "-1 Morale";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }

    public class MissingG4ExplosivesCard : SkillCheckCrisisCard
    {
        public MissingG4ExplosivesCard()
        {
            Title = "Missing G4 Explosives";
            BaseDifficulty = 7;
            UsedSkills.Add(CardType.Leadership);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            FailEffect = "-1 Food, and all characters in the Armory location are sent to the Brig.";
            FTL = false;
            CylonActivationType = CylonActivation.Raiders;
        }
    }

    public class PrisonLaborCard : SkillCheckCrisisCard
    {
        public PrisonLaborCard()
        {
            Title = "PrisonLabor";
            BaseDifficulty = 10;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            FailEffect = "-1 Morale, -1 Food.";
            FTL = false;
            CylonActivationType = CylonActivation.Raiders;
        }
    }

    public class PrisonerRevoltCard : SkillCheckCrisisCard
    {
        public PrisonerRevoltCard()
        {
            Title = "Prisoner Revolt";
            BaseDifficulty = 11;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            PartialPassValue = 6;
            PartialPassEffect = "-1 Population";
            FailEffect = "-1 Population, and the President chooses another player to receive the President title.";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }

    public class ResistanceCard : SkillCheckCrisisCard
    {
        public ResistanceCard()
        {
            Title = "Resistance";
            BaseDifficulty = 12;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            PartialPassValue = 9;
            PartialPassEffect = "-1 Food";
            FailEffect = "-1 Food, -1 Fuel.";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }

    public class SecurityBreachCard : SkillCheckCrisisCard
    {
        public SecurityBreachCard()
        {
            Title = "Security Breach";
            BaseDifficulty = 6;
            UsedSkills.Add(CardType.Leadership);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            FailEffect = "-1 Morale, and all characters in the Command are sent to Sickbay.";
            FTL = false;
            CylonActivationType = CylonActivation.RaidersLaunch;
        }
    }

    public class TerroristBomberCard : SkillCheckCrisisCard
    {
        public TerroristBomberCard()
        {
            Title = "Terrorist Bomber";
            BaseDifficulty = 9;
            UsedSkills.Add(CardType.Leadership);
            UsedSkills.Add(CardType.Tactics);
            PassEffect = "No effect.";
            FailEffect = "-1 Morale, and the current player is sent to Sickbay.";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }

    public class TerroristInvestigationsCard : SkillCheckCrisisCard
    {
        public TerroristInvestigationsCard()
        {
            Title = "Terrorist Investigations";
            BaseDifficulty = 12;
            UsedSkills.Add(CardType.Politics);
            UsedSkills.Add(CardType.Leadership);
            PassEffect = "Current player looks at 1 random Loyalty Card belonging to any player.";
            PartialPassValue = 6;
            PartialPassEffect = "No effect.";
            FailEffect = "-1 Morale";
            FTL = true;
            CylonActivationType = CylonActivation.HeavyRaiders;
        }
    }
}
