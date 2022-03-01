using Terraria.ID;
using Terraria.ModLoader;

namespace MoarStuf.Items
{
	public class DirtSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("DirtSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A little squishy");
		}

		public override void SetDefaults() 
		{
			item.damage = 6;
			item.melee = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5;
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