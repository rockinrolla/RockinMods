using System.Collections.Generic;
using System.Linq;
using StardewModdingAPI;
using Microsoft.Xna.Framework.Graphics;

namespace RockinMods

{
    public class DataLoader
    {
        #region Crops yaml
        public int SeedIndex { get; set; } //ObjectInfoIndex
        public int[] NextPhase { get; set; }
        public string[] Seasons { get; set; }
        public int SpriteSheetIndex { get; set; } //Existing crop modding
        public Texture2D SpriteSheet { get; set; } //New crop or override
        public int Produce { get; set; } //ObjectInfoIndex
        public int Regrow { get; set; }
        public int HarvestMethod { get; set; }
        public bool ExtraValues { get; set; } //wether too use the next 3 variables
        public int MinHarvest { get; set; }
        public int MaxHarvest { get; set; }
        public float XtraCrop { get; set; }
        public bool Trellis { get; set; }
        public bool RndColors { get; set; }
        public int[] Colors { get; set; }
        #endregion

        #region ObjectInfo yaml
        public string Name { get; set; }
        public int Price { get; set; }
        public int Catagory = -71;
        public string Description { get; set; }
        #endregion

        //public string Condition;

        public void LoadData(IModHelper helper)
        {
            Dictionary<int, string> modData = helper.Content.Load<Dictionary<int, string>>(@"Data\Crops.json", ContentSource.ModFolder);
        }

        public void ReplaceData(IModHelper helper)
        {
            Dictionary<int, string> cropData =  helper.Content.Load<Dictionary<int, string>>(@"Data\Crops.xnb", ContentSource.GameContent);
           
            string Replace = string.Concat(NextPhase, "/",Seasons,"/");
        }
        
    }
}
