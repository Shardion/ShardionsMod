# Shardion's Mod
A simple Terraria 1.4 mod focused on adding many small improvements to the game.

## What it does
It does things in three main areas (so far):
- Vanity item improvements
- Quality-of-life changes
- Game balancing

Changes in these areas can be disabled entirely, or fine-tuned to do only what the player wants.

## Total list of changes
- ### Vanity items
  - Mod developer vanity sets ([Sophisticated set](https://github.com/Shardion/ShardionsMod/tree/master/Content/VV/Items/Vanity/Sophisticated))
  - Dyes made easier to attain ([ImmaterialDye.cs](https://github.com/Shardion/ShardionsMod/blob/master/Content/VV/Items/Crafting/ImmaterialDye.cs))
- ### Quality-of-life
  - Crate upgrading, downgrading and conversion ([CrateCrafting.cs](https://github.com/Shardion/ShardionsMod/blob/master/Content/QoL/Recpies/CrateCrafting.cs))
  - Gem conversion ([GemCrafting.cs](https://github.com/Shardion/ShardionsMod/blob/master/Content/QoL/Recpies/GemCrafting.cs))
- ### Balancing
  - Magiluminescence recipe nerf ([MagiluminescenceRecipeNerf.cs](https://github.com/Shardion/ShardionsMod/blob/master/Content/Balancing/Recipes/MagiluminescenceRecipeNerf.cs))
  - Molotov Cocktail recipe buff ([MolotovCocktailRecipeBuff.cs](https://github.com/Shardion/ShardionsMod/blob/master/Content/Balancing/Recipes/MolotovCocktailRecipeBuff.cs))
  - Dryad always sells every Planter Box ([BalancingGlobalNPC.cs](https://github.com/Shardion/ShardionsMod/blob/master/Content/Balancing/NPCs/BalancingGlobalNPC.cs))

## Trickery
- Custom item classes to enable mod-wide changes to items ([ShardItem.cs](https://github.com/Shardion/ShardionsMod/blob/master/Utilities/ShardItem.cs))
- Item class reuse to cut down on code duplication ([Thread.cs](https://github.com/Shardion/ShardionsMod/blob/master/Content/VV/Items/Crafting/Thread/Thread.cs))
- Automatically generated tooltips ([ShardItem.cs](https://github.com/Shardion/ShardionsMod/blob/master/Utilities/ShardItem.cs))
- Dynamic recipe enabling/disabling via custom Conditions ([ShardRecipeHandler.cs](https://github.com/Shardion/ShardionsMod/blob/master/ShardRecipeHandler.cs))
- Separate, automatically-used Assets folder ([ShardItem.cs](https://github.com/Shardion/ShardionsMod/blob/master/Utilities/ShardItem.cs))

## What needs done
See [TODO.md](https://github.com/Shardion/ShardionsMod/blob/master/TODO.md)
