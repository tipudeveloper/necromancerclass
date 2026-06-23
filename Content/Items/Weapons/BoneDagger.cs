using necromancerclass.Content.DamageClasses;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace necromancerclass.Content.Items.Weapons
{
	public class BoneDagger : ModItem
	{
		public override void SetDefaults() {
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools

			// Common Properties
			Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(silver: 5);
			Item.maxStack = 1;
			Item.scale = 2.0f;

			// Use Properties
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useAnimation = 5;
			Item.useTime = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.consumable = false;
			

			// Weapon Properties			
			Item.damage = 2;
			Item.knockBack = 5f;
			Item.noUseGraphic = false; // The item should not be visible when used
			Item.noMelee = true; // The projectile will do the damage and not the item
			Item.DamageType = ModContent.GetInstance<Necromancer>();

			// Projectile Properties
			Item.shootSpeed = 20f;
			Item.shoot = ModContent.ProjectileType<Projectiles.BoneDaggerProjectile>(); // The projectile that will be thrown
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			CreateRecipe(1)
				.AddIngredient(ItemID.Wood, 10)
                .AddIngredient(ItemID.Cobweb, 5)
				.AddTile(TileID.Tombstones)
				.Register();
		}
	}
}