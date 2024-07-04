using ModdingUtils.MonoBehaviours;
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
    class KFC_Bucket : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            UnityEngine.Debug.Log($"[{rounds_mod.ModInitials}][Card] {GetTitle()} has been setup.");
            statModifiers.health = 1.2f;
            cardInfo.allowMultiple = false;
            statModifiers.movementSpeed = 1.2f;
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            UnityEngine.Debug.Log($"[{rounds_mod.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
            //Edits values on player when card is selected
            ChangePlayerColor(player);
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            UnityEngine.Debug.Log($"[{rounds_mod.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
            //Run when the card is removed from the player
        }


        protected override string GetTitle()
        {
            return "KFC Bucket";
        }
        protected override string GetDescription()
        {
            return "Bucket of Chicken Filet";
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
                    stat = "Health",
                    amount = "+20%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },

                new CardInfoStat()
                {
                    positive = true,
                    stat = "Movement",
                    amount = "+20%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },

                new CardInfoStat()
                {
                    positive = false,
                    stat = "Black",
                    amount = "become",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.EvilPurple;
        }
        public override string GetModName()
        {
            return "BBC Cards";
        }

        private void ChangePlayerColor(Player player)
        {
            // Debug-Ausgabe, um zu überprüfen, ob die Methode aufgerufen wird
            Debug.Log($"Farbe des Spielers ändern: {player.playerID}");

            // Fügen Sie die ReversibleColorEffect zum Spieler hinzu
            ReversibleColorEffect colorEffect = player.gameObject.AddComponent<ReversibleColorEffect>();
            colorEffect.SetColor(Color.black);
            colorEffect.SetLivesToEffect(1);

            // Debug-Ausgabe, um zu überprüfen, ob die Farbe geändert wurde
            Debug.Log($"Farbe des Spielers geändert: {player.playerID}");
        }

        
    }
}
