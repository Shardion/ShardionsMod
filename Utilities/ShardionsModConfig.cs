using Newtonsoft.Json;
using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ShardionsMod.Utilities
{
    public class ShardionsModConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [JsonIgnore]
        [Label("Looking for the configs for individual modules?")]
        public bool IExistPurelyToDisplayInfo;
        [JsonIgnore]
        [Label("Click the arrow buttons at the bottom.")]
        public bool ITooExistPurelyToDisplayInfo;
    }
    public class VariousVanitiesConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [DefaultValue(true)]
        [Label("Enable Various Vanities?")]
        [Tooltip("Various Vanities is the vanity item module of Shardion's Mod.\nIt contains quality-of-life features related to dyes, and new vanity items.")]
        public bool VariousVanitiesEnabled;
        
        [JsonIgnore]
        public bool _dyedThreads;
        [JsonIgnore]
        public bool _dyes;
        [JsonIgnore]
        public bool _none;

        [Header("Dye Handling In Vanity Recipes")]

        [DefaultValue(true)]
        [Label("Use dyed threads in vanity recipes")]
        [Tooltip("Does not require a world rejoin or mod reload!")]
        public bool DoDyedThreads { get { return _dyedThreads; } set { if (value) { _dyes = false; _none = false; _dyedThreads = true; } } }

        [DefaultValue(false)]
        [Label("Use dyes in vanity recipes")]
        [Tooltip("Does not require a world rejoin or mod reload!")]
        public bool DoDyes { get { return _dyes; } set { if (value) { _dyedThreads = false; _none = false; _dyes = true; } } }

        [DefaultValue(false)]
        [Label("Use no color in vanity recipes")]
        [Tooltip("Does not require a world rejoin or mod reload!")]
        public bool DoNone { get { return _none; } set { if (value) { _dyedThreads = false; _dyes = false; _none = true; } } }
        
        [DefaultValue(true)]
        [Label("Pre-Boss Familiar set recipes")]
        [Tooltip("Adds recipes for the Familiar vanity set that can be created pre-boss.")]
        public bool PreBossFamiliarSet;
    }
    public class BalancingConfig : ModConfig {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        
        [DefaultValue(true)]
        [Label("Enable Balancing Module?")]
        [Tooltip("Enables the as-of-yet-unnamed balancing module, which provides, you guessed it, balancing changes.")]
        public bool BalancingModuleEnabled;

        [DefaultValue(true)]
        [Label("Molotov Cocktail recipe buff")]
        [Tooltip("Changes the Molotov Cocktail recipe to require 5 Gel instead of 1 Pink Gel.")]
        public bool MolotovRecipeBuff;
        
        /* Disabled until I figure out how to change an NPC's drops
        [DefaultValue(true)]
        [Label("Swap Soaring Insignia and Gravity Globe")]
        [Tooltip("Makes the Soaring Insignia drop from the Moon Lord, and the Gravity Globe drop from the Empress of Light.")]
        public bool SwapSoaringInsignia;
        */

        [DefaultValue(true)]
        [Label("Magiluminescence recipe nerf")]
        [Tooltip("Changes the Magiluminescence recipe to require 4 Shadow Scales/Tissue Samples.")]
        public bool MagiluminescenceRecipeNerf;

        [DefaultValue(true)]
        [Label("Terraspark Boots recipe nerf")]
        [Tooltip("Changes the Terraspark Boots recipe to require 1 of each Mechanical Boss soul.")]
        public bool TerrasparkBootsRecipeNerf;

        /* You do it, plant
        [DefaultValue(true)]
        [Label("Magiluminescence nerf")]
        [Tooltip("Nerfs the Magiluminescence to a 5% movement speed buff (from 20%).")]
        public bool MagiluminescenceNerf;
        */

        [DefaultValue(true)]
        [Label("Dryad always sells every Planter Box")]
        [Tooltip("Makes the Dryad always sell every Planter Box (as they are all functionally equivalent).")]
        public bool AlwaysSellPlanterBoxes;

        [DefaultValue(true)]
        [Label("Destroyer probe laser glow")]
        [Tooltip("Makes the Pink Lasers shot by Destroyer Probes glow, like all other lasers. This makes them way easier to see at night.")]
        public bool ProbeLaserGlow;
    }

    public class QoLConfig : ModConfig {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        [DefaultValue(true)]
        [Label("Enable Quality-of-Life Module?")]
        [Tooltip("Enables the as-of-yet-unnamed quality-of-life module, which provides, you guessed it, quality-of-life changes.")]
        public bool QoLModuleEnabled;

        [DefaultValue(true)]
        [Label("Crate conversion, upgrading and downgrading")]
        [Tooltip("Allows you to convert biome crates to gold crates and back, upgrade crates and downgrade crates.")]
        public bool CrateCrafting;
        
        [ReloadRequired]
        [DefaultValue(true)]
        [Label("Gem conversion")]
        [Tooltip("Allows you to convert gems to Diamonds and back. Locks sell price of all gems to that of Amethyst. Requires a reload.")]
        public bool GemCrafting;

        [DefaultValue(true)]
        [Label("Chlorophyte Bar recipe buff")]
        [Tooltip("Changes the Chlorophyte Bar recipe to require 4 Chlorophyte Ore, instead of 5. Reduces tedious Chlorophyte grind.")]
        public bool ChlorophyteBarRecipeBuff;

        [DefaultValue(true)]
        [Label("Glowing Mushroom biome enemies drop Mushroom Grass Seeds")]
        [Tooltip("Adds 1 Glowing Mushroom Grass Seeds to the drops of all Glowing Mushroom enemies, at a 10% chance,\nand 2 Glowing Mushroom Grass Seeds at a 100% chance for Truffle Worms.")]
        public bool MushroomEnemiesDropSeeds;

        [DefaultValue(true)]
        [Label("Discount Cookie")]
        [Tooltip("Allows players to craft the Discount Cookie, a consumable item that permanently\ngrants the Discount Card effect (does not stack with Discount Card).")]
        public bool DiscountCookie;
    }
}
