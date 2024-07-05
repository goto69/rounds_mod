using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;


namespace rounds_mod.Cards
{
    class youCantMiss : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            UnityEngine.Debug.Log($"[{rounds_mod.ModInitials}][Card] {GetTitle()} has been setup.");
            gun.size = 1000000000000000000000000000f;
            gun.reloadTimeAdd = 10f;
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            UnityEngine.Debug.Log($"[{rounds_mod.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
            gunAmmo.maxAmmo = 1;
            //Edits values on player when card is selected
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            UnityEngine.Debug.Log($"[{rounds_mod.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
            //Run when the card is removed from the player
        }


        protected override string GetTitle()
        {
            return "you cant miss";
        }
        protected override string GetDescription()
        {
            return "never miss again";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Rare;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "aimbot",
                    amount = "100%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "reloadtime",
                    amount = "+10s",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "ammo",
                    amount = "1",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.DefensiveBlue;
        }
        public override string GetModName()
        {
            return "rounds.ModInitials";
        }
    }
}
