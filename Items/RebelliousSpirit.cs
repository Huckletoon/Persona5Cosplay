using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Persona5Cosplay.Items
{
	[AutoloadEquip(EquipType.Back)]
	public class RebelliousSpirit: ModItem
    {
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("RebelKnife"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The spark of rebellion in one's soul\nIncreases critical chance, defense, health, and mana\nEffect increases based on equipped Phantom Thief armor");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 32;
			item.accessory = true;
			item.value = 0;
			item.rare = ItemRarityID.Expert;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 20);
			
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			int tier = player.GetModPlayer<P5Player>().equipmentTier;
			player.statDefense += 3 + (tier * 2);
			switch(tier)
			{
				case 0:
					player.magicCrit += 5;
					player.meleeCrit += 5;
					player.rangedCrit += 5;
					player.thrownCrit += 5;
					//TODO: HP+ and Mana+
					break;
				case 1:
					player.magicCrit += 8;
					player.meleeCrit += 8;
					player.rangedCrit += 8;
					player.thrownCrit += 8;
					//TODO: HP+ and Mana+
					break;
				case 2:
					player.magicCrit += 11;
					player.meleeCrit += 11;
					player.rangedCrit += 11;
					player.thrownCrit += 11;
					//TODO: HP+ and Mana+
					break;
				case 3:
					player.magicCrit += 14;
					player.meleeCrit += 14;
					player.rangedCrit += 14;
					player.thrownCrit += 14;
					//TODO: HP+ and Mana+
					break;
				case 4:
					player.magicCrit += 20;
					player.meleeCrit += 20;
					player.rangedCrit += 20;
					player.thrownCrit += 20;
					//TODO: HP+ and Mana+
					break;
				case 5:
					player.magicCrit += 25;
					player.meleeCrit += 25;
					player.rangedCrit += 25;
					player.thrownCrit += 25;
					//TODO: HP+ and Mana+
					break;
				case 6:
					player.magicCrit += 28;
					player.meleeCrit += 28;
					player.rangedCrit += 28;
					player.thrownCrit += 28;
					//TODO: HP+ and Mana+
					break;
				case 7:
					player.magicCrit += 35;
					player.meleeCrit += 35;
					player.rangedCrit += 35;
					player.thrownCrit += 35;
					//TODO: HP+ and Mana+
					break;
			}
		}
	}
}
