using UnityEngine;
using ModsPlus;
using UnityEngine.Assertions;
using System.Collections.Generic;
using ModdingUtils.MonoBehaviours;
using ModdingUtils.AIMinion.Extensions;
using ModdingUtils.Extensions;
using System.Xml.Linq;

public class LevitationCharge : CustomEffectCard<BlockChargeEffect>
{
    public override CardDetails Details => new CardDetails
    {
        Title = "Levitation Charge",
        Description = "Blocking Stores an extra jump until you jump",
        ModName = "TCS1",
        Rarity = CardInfo.Rarity.Common,
        Theme = CardThemeColor.CardThemeColorType.FirepowerYellow,     
    };
}

public class BlockChargeEffect : CardEffect
{
    private Stack<StatChangeTracker> activeJumpBuffs = new Stack<StatChangeTracker>();

    public override void OnBlock(BlockTrigger.BlockTriggerType blockTriggerType)
    {
        var buff = StatManager.Apply(player, new StatChanges { Jumps = 1});
        activeJumpBuffs.Push(buff);
    }

   /* public override void OnJump()
    { 
        if (data.isGrounded == false && data.isWallGrab == true)
        {
            var buff = StatManager.Apply(player, new StatChanges { Jumps = 1});
            activeJumpBuffs.Push(buff);
        }

        if (data.isGrounded == true)
        {
            var buff = StatManager.Apply(player, new StatChanges { Jumps = 1});
            activeJumpBuffs.Push(buff);
        }

        activeJumpBuffs.Pop();    
    }*/


    public override void OnJump()
    {
        // find an active jump buff
        StatChangeTracker buffToRemove = null;
        while (activeJumpBuffs.Count > 0 && buffToRemove == null || !buffToRemove.active)
        {
            buffToRemove = activeJumpBuffs.Pop();
        }

        // return if there were no active buffs
        if (buffToRemove == null) return;

        // otherwise, remove one active buff
        StatManager.Remove(buffToRemove);
    }
}

