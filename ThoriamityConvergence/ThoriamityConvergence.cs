using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace ThoriamityConvergenceRedux;

public class ThoriamityConvergence : ModSystem
{
	internal static Mod CalamityMod { get; private set; }
	internal static Mod ThoriumMod { get; private set; }

	private static void LoadedMods()
	{
		ModLoader.TryGetMod("CalamityMod", out var calamity);
		CalamityMod = calamity;
		ModLoader.TryGetMod("ThoriumMod", out var thorium);
		ThoriumMod = thorium;
	}

	private static void UnloadLoadedMod()
	{
		CalamityMod = null;
		ThoriumMod = null;
	}

	public override void PostSetupContent()
	{
		LoadedMods();
	}

	public override void Unload()
	{
		UnloadLoadedMod();
	}
    internal static void SingleRecipe(int resulttype, int craftingtype, int amount, int craftingtype2, int amount2, int tiletype)
    {
        Recipe.Create(resulttype)
            .AddIngredient(craftingtype, amount)
            .AddIngredient(craftingtype2, amount2)
            .AddTile(tiletype)
            .Register();
    }

    public override void AddRecipes()
	{
		RecipeFinder val = new RecipeFinder();
		val.SetResult(CalamityMod.Find<ModItem>("AngelTreads").Type, 1);

		foreach (Recipe item in val.SearchRecipes())
		{
			RecipeEditor val2 = new RecipeEditor(item);
			val2.AddIngredient(ThoriumMod.Find<ModItem>("SolarPebble").Type, 12);
		}
		RecipeFinder val3 = new RecipeFinder();
		val3.SetResult(ThoriumMod.Find<ModItem>("TerrariumBoots").Type, 1);
		foreach (Recipe item2 in val3.SearchRecipes())
		{
			RecipeEditor val4 = new RecipeEditor(item2);
			val4.DeleteIngredient(ItemID.TerrasparkBoots);
			val4.AddIngredient(CalamityMod.Find<ModItem>("AngelTreads").Type, 1);
		}
		RecipeFinder val5 = new RecipeFinder();
		val5.SetResult(CalamityMod.Find<ModItem>("InfinityBoots").Type, 1);
		foreach (Recipe item3 in val5.SearchRecipes())
		{
			RecipeEditor val6 = new RecipeEditor(item3);
			val6.DeleteIngredient(CalamityMod.Find<ModItem>("AngelTreads").Type);
			val6.AddIngredient(ThoriumMod.Find<ModItem>("TerrariumBoots").Type, 1);
		}
		RecipeFinder val7 = new RecipeFinder();

        val7.SetResult(CalamityMod.Find<ModItem>("Nanotech").Type, 1);
        foreach (Recipe item4 in val7.SearchRecipes())
        {
            Recipe cloneNano = item4.Clone();
            RecipeEditor val8 = new RecipeEditor(cloneNano);
            val8.DeleteIngredient(CalamityMod.Find<ModItem>("RogueEmblem").Type);
            val8.AddIngredient(ThoriumMod.Find<ModItem>("NinjaEmblem").Type, 1);
            cloneNano.Register();
        }
        RecipeFinder val9 = new RecipeFinder();
        val9.SetResult(ItemID.Leather, 1); 
        foreach (Recipe item5 in val9.SearchRecipes())
		{
			new RecipeEditor(item5).DeleteRecipe();
		}
        Recipe.Create(ItemID.Leather, 1)
        .AddIngredient(ItemID.Vertebrae, 5)
        .AddTile(TileID.WorkBenches)
        .Register();
        Recipe.Create(ItemID.Leather, 1)
        .AddIngredient(ItemID.RottenChunk, 5)
        .AddTile(TileID.WorkBenches)
        .Register();
        SingleRecipe(ThoriumMod.Find<ModItem>("AquaPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.WorkBenches);
        SingleRecipe(ThoriumMod.Find<ModItem>("ArcanePotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.WorkBenches);
        SingleRecipe(ThoriumMod.Find<ModItem>("ArtilleryPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.WorkBenches);
        SingleRecipe(ThoriumMod.Find<ModItem>("WarmongerPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.WorkBenches);
        SingleRecipe(ThoriumMod.Find<ModItem>("AssassinPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.AlchemyTable);
        SingleRecipe(ThoriumMod.Find<ModItem>("BloodPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.AlchemyTable);
        SingleRecipe(ThoriumMod.Find<ModItem>("BouncingFlamePotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.AlchemyTable);
        SingleRecipe(ThoriumMod.Find<ModItem>("ConflagrationPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.AlchemyTable);
        SingleRecipe(ThoriumMod.Find<ModItem>("CreativityPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.AlchemyTable);
        SingleRecipe(ThoriumMod.Find<ModItem>("EarwormPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.AlchemyTable);
        SingleRecipe(ThoriumMod.Find<ModItem>("FrenzyPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.AlchemyTable);
        SingleRecipe(ThoriumMod.Find<ModItem>("GlowingPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.AlchemyTable);
        SingleRecipe(ThoriumMod.Find<ModItem>("HolyPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.AlchemyTable);
        SingleRecipe(ThoriumMod.Find<ModItem>("HydrationPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.AlchemyTable);
        SingleRecipe(ThoriumMod.Find<ModItem>("InspirationReachPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.AlchemyTable);
        SingleRecipe(ThoriumMod.Find<ModItem>("KineticPotion").Type, ItemID.BottledWater, 1, CalamityMod.Find<ModItem>("BloodOrb").Type, 10, TileID.AlchemyTable);
	}

    internal class RecipeFinder
    {
        internal Recipe[] RecipeArray;

        internal int RecipeResult;

        internal int Amount;

        public RecipeFinder()
        {
            RecipeArray = Main.recipe;
        }

        public void SetResult(int result, int amount)
        {
            RecipeResult = result;
            Amount = amount;
        }

        public List<Recipe> SearchRecipes()
        {
            List<Recipe> list = new List<Recipe>();

            foreach (Recipe recipe in RecipeArray)
            {
                if (recipe.createItem.type == RecipeResult)
                {
                    recipe.ReplaceResult(recipe.createItem.type, Amount);
                    list.Add(recipe);
                }
            }
            return list;
        }
    }

    internal class RecipeEditor
    {
        internal Recipe ResultingRecipe;

        public RecipeEditor(Recipe result)
        {
            ResultingRecipe = result;
        }

        public void DeleteIngredient(int IngredientType)
        {
            ResultingRecipe.RemoveIngredient(IngredientType);
        }

        public void AddIngredient(int IngredientType, int amount)
        {
            ResultingRecipe.AddIngredient(IngredientType, amount);
        }
        public void DeleteRecipe()
        {
            ResultingRecipe.DisableRecipe();
        }
    }
}

