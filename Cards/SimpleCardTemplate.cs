using System;
using ModdingUtils.Extensions;
using ModsPlus;
using UnboundLib;

public class LevitationCharg : CustomEffectCard<BlockingEffect>
{
    public override CardDetails Details => new CardDetails
    {
        
        Title = "Levitation Charge",
           
        Description = "Stores a Jump every time you block",            
        ModName = "TyroCardsSet1",           
        Rarity = CardInfo.Rarity.Common,   
        Theme = CardThemeColor.CardThemeColorType.TechWhite
    };


        
    public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)   
    {

        
    }

        
    protected override void Added(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)    
    {
     
        //Debug.Log("Card added to the player!");
    }

    protected override void Removed(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
    {
        //Debug.Log("Card removed from the player!");
    }    
}

public class BlockingEffect : CardEffect
{
    public static int extraJumps;

    private void OnBlock(BlockTrigger.BlockTriggerType blockTrigger)
    {
        extraJumps++;
    }
}


