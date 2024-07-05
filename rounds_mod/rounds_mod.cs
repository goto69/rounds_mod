using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using rounds_mod.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using GunChargePatch.Extensions;


namespace rounds_mod
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class rounds_mod : BaseUnityPlugin
    {
        public const string ModInitials = "himm";
        private const string ModId = "com.goto.rounds.rounds_mod";
        private const string ModName = "rounds";
        public const string Version = "1.0.0"; // What version are we on (major.minor.patch)?

        public static rounds_mod instance { get; private set; }

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }

        void Start()
        {
            CustomCard.BuildCard<FlyByBlocking>();
            CustomCard.BuildCard<HeliumBloon>();
            CustomCard.BuildCard<HeliumFillledBullets>();
            CustomCard.BuildCard<youCantMiss>();
            CustomCard.BuildCard<railgun>();
            CustomCard.BuildCard<BBC>();
            CustomCard.BuildCard<GetOverHere>();
            CustomCard.BuildCard<flashlight>();
            CustomCard.BuildCard<unblockable>();
            CustomCard.BuildCard<KFC_Bucket>();
            CustomCard.BuildCard<DriveBy>();
            instance = this;
        }
    }
}
