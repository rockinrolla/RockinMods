using System;
using System.Collections.Generic;
using System.Text;
using StardewValley;
using StardewModdingAPI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Stardew64
{
    class ModEntry : Mod
    {
        internal static StardewValley.Farmer who;
        public SpriteBatch B;
        public override void Entry(IModHelper helper)
        {
            who.sprite = new AnimatedSprite(helper.Content.Load<Texture2D>("Farmer.png", ContentSource.ModFolder), 0, 32, 48);
            who.sprite.draw(B, who.Position, 3, 0, 0, Color.White, false, 2, 0, false);
        }
    }
}
