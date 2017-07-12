using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewValley;
using StardewModdingAPI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RockinMods
{
    class CustomNPC : NPC
    {
        #region Variables
        public IModHelper Helper;
        public StardewValley.Farmer Farmer;

        public string Name { get; set; }
        public int Age { get; set; }
        public int Manners { get; set; }
        public int SocialAnxiety { get; set; }
        public int Optimism { get; set; }
        public int Gender { get; set; }
        public bool Datable { get; set; }
        public int HomeRegion { get; set; }
        public string BirthdaySeason { get; set; }
        public int BirthdayDay { get; set; }
        public Vector2 defaultPosition { get; set; }
        #endregion

        #region Constructors
        public CustomNPC()
        {
            Name = "Ashley";
            Age = 2; //child
            Manners = 2; //rude
            SocialAnxiety = 1; //shy
            Optimism = 1; //negative
            Gender = 1; //female
            Datable = false; //not-datable
            HomeRegion = 0; //Other
            BirthdaySeason = "fall"; //fall 8
            BirthdayDay = 8;
            defaultPosition = new Vector2();
        }

        public void LoadNPC(AnimatedSprite sprite, Vector2 position, string defaultMap, int facingDir, string name, bool dateable, Dictionary<int, int[]> schedule, Texture2D portrait)
        {

        }
        #endregion

        #region Methods
        public override Rectangle GetBoundingBox()
        {
            if (this.sprite == null)
                return Rectangle.Empty;
            return new Rectangle((int)this.position.X + Game1.tileSize / 8, (int)this.position.Y + Game1.tileSize / 4, 16 * Game1.pixelZoom * 3 / 4, Game1.tileSize / 2);
        }

        public override Rectangle getMugShotSourceRect()
        {
            return new Rectangle(1, 4, 22, 24);
        }
      #endregion
    }
}
