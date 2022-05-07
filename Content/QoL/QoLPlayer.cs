using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.ModLoader.IO;
using Terraria;

namespace ShardionsMod.Content.QoL {
    public class QoLPlayer : ModPlayer {
        public bool DiscountCookie;
        
        public override void SaveData(TagCompound tag)
        {
            var playerData = new List<string>();
            if (DiscountCookie) playerData.Add("DiscountCookie");
            tag.Add($"{Mod.Name}.{Player.name}.Data", playerData);
        }
        
        public override void LoadData(TagCompound tag)
        {
            var playerData = tag.GetList<string>($"{Mod.Name}.{Player.name}.Data");
            DiscountCookie = playerData.Contains("DiscountCookie");
        }

        public override void PostUpdateEquips()
        {
            base.PostUpdateEquips();
            if (DiscountCookie)
                Player.discount = true;
        }
    }
}