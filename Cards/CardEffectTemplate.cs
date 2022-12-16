using UnityEngine;
using ModsPlus;
using UnityEngine.Assertions;

public class ExampleCard : CustomEffectCard<ExampleEffect>
{
    public override CardDetails Details => new CardDetails
    {
        Title = "Example Card",
        Description = "Your first effect card",
        ModName = "<Your Mod ID>",
        Rarity = CardInfo.Rarity.Common,
        Theme = CardThemeColor.CardThemeColorType.TechWhite
    };
}

public class ExampleEffect : CardEffect
{
    public override void OnBlock(BlockTrigger.BlockTriggerType trigger)
    {
        UnityEngine.Debug.Log("[ExampleEffect] Player blocked!");
    }

    public override void OnShoot(GameObject projectile)
    {
        UnityEngine.Debug.Log("[ExampleEffect] Player fired a shot!");
    }
}

