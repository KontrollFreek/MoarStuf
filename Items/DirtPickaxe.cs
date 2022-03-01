using Terraria.ID;
using Terraria.ModLoader;

namespace MoarStuf.Items
{
	public class DirtPickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("DirtPickaxe"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Just the right amount of squishy");
		}

		public override void SetDefaults() 
		{
			item.damage = 3;
			item.pick = 10;
			item.width = 32;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 3;
			item.value = 10;
			item.UseSound = SoundID.Item7;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 20);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}