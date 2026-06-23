using necromancerclass.Content.DamageClasses;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace necromancerclass.Content.Items.Weapons
{
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class BoneDagger : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.diablo2mod.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 5;
			Item.DamageType = ModContent.GetInstance<Necromancer>();
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 30;
			Item.useAnimation = 10;
			Item.holdStyle = ItemHoldStyleID.HoldFront;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(silver: 1);
			Item.rare = ItemRarityID.White;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.scale = 2.0f;
		}
		// This hook runs the exact moment the player clicks to use the item.
        // It forces the player's sprite to flip and face the mouse immediately.
        public override bool? UseItem(Player player)
        {
            player.direction = (Main.MouseWorld.X - player.Center.X > 0) ? 1 : -1;
            return true;
        }
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.Cobweb, 5);
			recipe.AddTile(TileID.Tombstones);
			recipe.Register();
		}
	}
}
