using System;
using System.Collections.Generic;
using System.Text;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Framework;
using StardewValley;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RockinMods
{
    public class ModEntry : Mod
    {
        CustomNPC NPC = new CustomNPC();
        
        public override void Entry(IModHelper helper)
        {
            NPC = helper.ReadConfig<CustomNPC>();
            SaveEvents.AfterLoad += SaveEvents_AfterLoad;
        }

        private void SaveEvents_AfterLoad(object sender, EventArgs e)
        {
            Dictionary<string,string> Schedule = Helper.Content.Load<Dictionary<string, string>>(@"\Charcters\Schedule" + NPC.Name, ContentSource.ModFolder);
            NPC.LoadNPC(new AnimatedSprite(Helper.Content.Load<Texture2D>(@"\Characters" + NPC.Name + ".png", ContentSource.ModFolder)),NPC.position,NPC.defaultMap,NPC.facingDirection,NPC.Name,NPC.Datable, new Dictionary<int, int[]>(), Helper.Content.Load<Texture2D>(@"\Portraits" + NPC.Name + ".png", ContentSource.ModFolder));
            NPC.Dialogue = Helper.Content.Load <Dictionary<string, string>>(@"\Charcters\Dialogue" + NPC.Name, ContentSource.ModFolder);
        }
    }
}
