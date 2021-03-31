using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Terraria.Localization;

namespace Persona5Cosplay
{
	public class Persona5Cosplay : Mod
	{
		public Persona5Cosplay()
		{
		}

		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Gold/Platinum Bar", new int[]
			{
				ItemID.GoldBar,
				ItemID.PlatinumBar
			});
			RecipeGroup.RegisterGroup("Persona5Cosplay:GoldBars", group);

			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Cobalt/Palladium Bar", new int[]
			{
				ItemID.CobaltBar,
				ItemID.PalladiumBar
			});
			RecipeGroup.RegisterGroup("Persona5Cosplay:CobaltBars", group);

			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Bar", new int[]
			{
				ItemID.DemoniteBar,
				ItemID.CrimtaneBar
			});
			RecipeGroup.RegisterGroup("Persona5Cosplay:EvilBars", group);

			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Evil Chunk", new int[]
			{
				ItemID.ShadowScale,
				ItemID.TissueSample
			});
			RecipeGroup.RegisterGroup("Persona5Cosplay:EvilChunks", group);
		}
	}
}