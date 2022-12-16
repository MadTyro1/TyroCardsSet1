using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using TyroCardsSet1.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;

namespace TyroCardsSet1
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class TyroCardsSet1 : BaseUnityPlugin
    {
        private const string ModId = "com.willuwontu.rounds.TyroCardsSet1";
        private const string ModName = "Tyro Cards Set 1";
        public const string Version = "1.0.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "TCS1";
        public static TyroCardsSet1 instance { get; private set; }

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            CustomCard.BuildCard<EvasiveManeuvers>();
            CustomCard.BuildCard<AirTime>();
            CustomCard.BuildCard<HighJump>();
            CustomCard.BuildCard<Vampire>();
            CustomCard.BuildCard<LevitationCharge>();
            CustomCard.BuildCard<Gigantic>();
            instance = this;
        }
    }
}

