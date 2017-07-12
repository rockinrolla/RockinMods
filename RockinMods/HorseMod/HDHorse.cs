using StardewModdingAPI;
using StardewValley;
using StardewValley.Characters;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RockinMods
{
    class HDHorse : Horse
    {
        public Texture2D texture; 



        public HDHorse() : base( 0, 0)
        {
     
        }

        public void LoadContent(IModHelper helper)
        {
            texture = helper.Content.Load<Texture2D>("horse.png", ContentSource.ModFolder);
        }

        public override Rectangle GetBoundingBox()
        {
            Rectangle boundingBox = base.GetBoundingBox();
            bool mounting = this.mounting;
            Rectangle result;
            if (mounting)
            {
                result = boundingBox;
            }
            else
            {
                boundingBox.Inflate(-18 - Game1.pixelZoom, 0);
                result = boundingBox;
            }
            return result;
        }

        public override void draw(SpriteBatch b)
        {
            b.Draw(texture, base.getLocalPosition(Game1.viewport) + new Vector2((float)(Game1.tileSize * 3 / 4), (float)(-(float)Game1.tileSize / 2 + Game1.pixelZoom * 2)), new Rectangle?(new Rectangle(160, 96, 9, 15)), Color.White, 0f, Vector2.Zero, (float)Game1.pixelZoom, SpriteEffects.None, (this.position.Y + (float)Game1.tileSize) / 10000f) ;

            if (this.facingDirection == 2 && this.rider != null)
            {
                b.Draw(this.sprite.Texture, base.getLocalPosition(Game1.viewport) + new Vector2((float)(Game1.tileSize * 3 / 4), (float)(-(float)Game1.tileSize / 2 + Game1.pixelZoom * 2) - this.rider.yOffset), new Rectangle?(new Rectangle(160, 96, 9, 15)), Color.White, 0f, Vector2.Zero, (float)Game1.pixelZoom, SpriteEffects.None, (this.position.Y + (float)Game1.tileSize) / 10000f);
            }
        }
    }
}
