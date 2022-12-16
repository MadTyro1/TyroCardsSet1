using ModsPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace TyroCardsSet1.Cards
{
    class Gigantic : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            statModifiers.health = 2.15f;
            statModifiers.movementSpeed = 0.7f;
            statModifiers.sizeMultiplier = 1.05f;
            //statModifiers.numberOfJumps = 0;
            block.cdAdd = .5f;
            //UnityEngine.Debug.Log($"[{TyroCardsSet1.ModInitials}][Card] {GetTitle()} has been setup.");
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            data.jumps = data.jumps -1;
            //UnityEngine.Debug.Log($"[{SimplyCards.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
            //Edits values on player when card is selected
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //UnityEngine.Debug.Log($"[{SimplyCards.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "Gigantic";
        }
        protected override string GetDescription()
        {
            return "";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Uncommon;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Health",
                    amount = "215%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Size",
                    amount = "Extra .05%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Movement speed",
                    amount = "-30%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Block Cooldown",
                    amount = "+0.30s",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Jumps",
                    amount = "-1",
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
            return "TCS1";
        }
    }
}

