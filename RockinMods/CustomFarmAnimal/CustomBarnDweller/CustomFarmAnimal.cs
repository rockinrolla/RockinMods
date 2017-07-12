using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewValley;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using StardewValley.Buildings;

namespace RockinMods
{
    public class CustomFarmAnimal : Character
    {
        public long parentId;
        public long ownerId;
        public long myId;
        public int age;
        public int ageWhenMature;
        public Building home;
        public Rectangle frontBackSourceRect;
        public int hitGlowTimer;
        public string type;
        public string sound;
        public int harvestType;
        public bool allowReproduction;
        public int happiness;
        public Vector2 homeLocation;
        public string displayType;
        public string buildingTypeILiveIn;


        public CustomFarmAnimal(string Type, long id, long OwnerId)
        {
            type = Type;
            myId = id;
            ownerId = OwnerId;

            if(type.Contains("Chicken") && !type.Equals("Void Chicken"))
            {
                if(Game1.IsMultiplayer)
                {
                    type = ((type.Contains("Brown") || new Random((int)id).NextDouble() < 0.5) ? "Brown Chicken" : "White Chicken");
                }
                else
                {
                    type = ((Game1.random.NextDouble() < 0.5 || type.Contains("Brown")) ? "Brown Chicken" : "White Chicken");
                    if(Game1.player.eventsSeen.Contains(3900074) && Game1.random.NextDouble() < 0.25)
                    {
                        type = "Blue Chicken";
                    }
                }
            }
            if(type.Contains("Cow"))
            {
                if(Game1.IsMultiplayer)
                {
                    type = ((!type.Contains("White") && (type.Contains("Brown") || new Random((int)id).NextDouble() < 0.5)) ? "Brown Cow" : "White Cow");
                }
                else
                {
                    type = ((!type.Contains("White") && (Game1.random.NextDouble() < 0.5 || type.Contains("Brown"))) ? "Brown Cow" : "White Cow");
                }
            }
            Dictionary<string, string> arg_1C4_0 = Game1.content.Load<Dictionary<string, string>>("Data\\FarmAnimals");
        }

        public bool isCoopDweller()
        {
            return home != null && home is Coop;
        }

        public bool isBaby()
        {
            return age < ageWhenMature;
        }

        public void setRandomPosition(GameLocation location)
        {
            string[] expr_1B = location.getMapProperty("ProduceArea").Split(new char[]
            {
                ' '
            });
            int num = Convert.ToInt32(expr_1B[0]);
            int num2 = Convert.ToInt32(expr_1B[1]);
            int num3 = Convert.ToInt32(expr_1B[2]);
            int num4 = Convert.ToInt32(expr_1B[3]);
            this.position = new Vector2((float)(Game1.random.Next(num, num + num3) * Game1.tileSize), (float)(Game1.random.Next(num2, num2 + num4) * Game1.tileSize));
            int num5 = 0;
            while(this.position.Equals(Vector2.Zero) || location.Objects.ContainsKey(this.position) || location.isCollidingPosition(this.GetBoundingBox(), Game1.viewport, false, 0, false, this))
            {
                this.position = new Vector2((float)Game1.random.Next(num, num + num3), (float)Game1.random.Next(num2, num2 + num4)) * (float)Game1.tileSize;
                num5++;
                if(num5 > 64)
                {
                    break;
                }
            }
        }

        public bool isMale()
        {
            string a = this.type;
            if(!(a == "Rabbit"))
            {
                return (a == "Truffle Pig" || a == "Hog" || a == "Pig") && this.myId % 2L == 0L;
            }
            return this.myId % 2L == 0L;
        }

        public override void draw(SpriteBatch b)
        {
            if(isCoopDweller())
            {
                sprite.drawShadow(b, Game1.GlobalToLocal(Game1.viewport, position - new Vector2(0f, (float)(Game1.tileSize * 3 / 8))), isBaby() ? 3f : 4f);
            }
            this.sprite.draw(b, Game1.GlobalToLocal(Game1.viewport, this.position - new Vector2(0f, (float)(Game1.tileSize * 3 / 8))), ((float)(this.GetBoundingBox().Center.Y + Game1.pixelZoom) + this.position.X / 1000f) / 10000f, 0, 0, (this.hitGlowTimer > 0) ? Color.Red : Color.White, base.FacingDirection == 3, 4f, 0f, false);
            if(this.isEmoting)
            {
                Vector2 position = Game1.GlobalToLocal(Game1.viewport, this.position + new Vector2((float)(this.frontBackSourceRect.Width / 2 * 4 - Game1.tileSize / 2), (float)(this.isCoopDweller() ? (-(float)Game1.tileSize * 3 / 2) : (-(float)Game1.tileSize))));
                b.Draw(Game1.emoteSpriteSheet, position, new Rectangle?(new Rectangle(CurrentEmoteIndex * 16 % Game1.emoteSpriteSheet.Width, CurrentEmoteIndex * 16 / Game1.emoteSpriteSheet.Width * 16, 16, 16)), Color.White, 0f, Vector2.Zero, (float)Game1.pixelZoom, SpriteEffects.None, (float)GetBoundingBox().Bottom / 10000f);
            }
        }
    }
}
