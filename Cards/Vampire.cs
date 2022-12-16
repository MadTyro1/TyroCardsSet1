using ModdingUtils.MonoBehaviours;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnboundLib.Utils;
using UnityEngine;

namespace TyroCardsSet1.Cards
{
    class Vampire : CustomCard
    {
        public UnityEngine.Color SetSpriteColor { get; private set; }

        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            statModifiers.lifeSteal = 1.50f;
            statModifiers.movementSpeed = 1.25f;
            statModifiers.health = 0.50f;
            //UnityEngine.Debug.Log($"[{TyroCardsSet1.ModInitials}][Card] {GetTitle()} has been setup.");
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            data.jumps += 2;
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
            return "Vampire";
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
                    stat = "Life Steal",
                    amount = "+50%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Jumps",
                    amount = "+2",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
                ,
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Movement Speed",
                    amount = "+25%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Health",
                    amount = "-50%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.ColdBlue;
        }
        public override string GetModName()
        {
            return "TCS1";
        }
    }
}

