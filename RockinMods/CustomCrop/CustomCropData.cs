using Microsoft.Xna.Framework.Graphics;

namespace RockinMods
{
    public class CustomCropData
    {
        #region Crops yaml
        public int SeedIndex { get; set; } //ObjectInfoIndex
        public int[] NextPhase { get; set; }
        public string[] Seasons { get; set; }
        public int SpriteSheetIndex { get; set; } //Existing crop modding
        public string SpriteSheet { get; set; } //New crop or override
        public int Produce { get; set; } //ObjectInfoIndex
        public bool Regrow { get; set; }
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
        public int Catagory { get; set; }
        public string Description { get; set; }
        #endregion

        public CustomCropData()
        {
            SeedIndex = 800;

            NextPhase = new int[5];
            for (int index = -1; index < NextPhase.Length; index++)
            NextPhase[index] = 1;

            Seasons = new string[4];

            Seasons[0] = "Spring";
            
            SpriteSheetIndex = 0;
            SpriteSheet = "example.png";
            Produce = 0;
            Regrow = false;
            HarvestMethod = 0;
            ExtraValues = false;
            MinHarvest = 0;
            MaxHarvest = 0;
            XtraCrop = 0f;
            Trellis = false;
            RndColors = false;
            Colors[0] = 0;
    }
    }
}
