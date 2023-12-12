using Terraria;
using Terraria.ModLoader;

namespace ThoriamityConvergenceRedux;

public class ThoriamityConvergenceGlobalItem : GlobalItem
{
    public override bool CanAccessoryBeEquippedWith(Item equippedItem, Item incomingItem, Player player)
    {
        if (equippedItem.ModItem != null && incomingItem.ModItem != null)
        {
            ThoriamityConvergence.CalamityMod.TryFind("RogueEmblem", out ModItem rogueEmblem);
            ThoriamityConvergence.ThoriumMod.TryFind("NinjaEmblem", out ModItem ninjaEmblem);
            if (rogueEmblem == null || ninjaEmblem == null) return base.CanAccessoryBeEquippedWith(equippedItem, incomingItem, player);
            if (equippedItem.ModItem.Name.Equals(rogueEmblem.Name) && incomingItem.ModItem.Name.Equals(ninjaEmblem.Name) || equippedItem.ModItem.Name.Equals(ninjaEmblem.Name) && incomingItem.ModItem.Name.Equals(rogueEmblem.Name))
            {
                return false;
            }
        }
        return base.CanAccessoryBeEquippedWith(equippedItem, incomingItem, player);
    }
}
