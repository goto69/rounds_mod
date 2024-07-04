using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using rounds_mod.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using ModdingUtils.Extensions;
using System.Collections.Generic;
using UnboundLib.GameModes;
using System;
using System.Linq;
using UnboundLib.Utils;


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
        public const string ModInitials = "him";
        private const string ModId = "com.gotot.rounds.rounds_mod";
        private const string ModName = "rounds_mod";
        public const string Version = "1.0.0"; // What version are we on (major.minor.patch)?

        public static rounds_mod instance { get; private set; }

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }

        //-----------------------------------------------------------------------

        void Start()
        {
            CustomCard.BuildCard<Maneuver>();
            CustomCard.BuildCard<KFC_Bucket>();
            CustomCard.BuildCard<DriveBy>();
            instance = this;
            
        }

        
    }
    
}
