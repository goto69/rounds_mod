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
    class BBC : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            UnityEngine.Debug.Log($"[{rounds_mod.ModInitials}][Card] {GetTitle()} has been setup.");
            gun.reloadTime = 0f;
            gun.attackSpeed = 0f;
            gun.projectileColor = Color.blue;
            gun.destroyBulletAfter = 0.5f;
            gun.projectileSpeed = 0.2f;
            gun.gravity = 0f;
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
            return "BBC";
        }
        protected override string GetDescription()
        {
            return "BBC gives you a wobli short ranged weapon";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Common;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = false,
                    stat = "range",
                    amount = "0.5 units",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "firerate",
                    amount = "infinit",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };

        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.NatureBrown;
        }
        public override string GetModName()
        {
            return "rounds.ModInitials";
        }
    }
}
