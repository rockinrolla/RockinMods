using System;
using System.Collections.Generic;
using System.Reflection;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Menus;


namespace RockinMods
{
    public class ModEntry : Mod
    {
        #region Variables
        public const int lastEntry = 796;
        internal static DataLoader loader = new DataLoader();

        public static List<StardewValley.Object> springCropObjects = new List<StardewValley.Object>();
        public static List<StardewValley.Object> summerCropObjects = new List<StardewValley.Object>();
        public static List<StardewValley.Object> fallCropObjects = new List<StardewValley.Object>();

        public List<int> SpringCropInts = new List<int>();
        public List<int> SummerCropInts = new List<int>();
        public List<int> FallCropInts = new List<int>();

        private static Dictionary<Item, int[]> itemPriceAndStock;

        private static List<Item> forSale;

        private static FieldInfo Stock = typeof(ShopMenu).GetField("itemPriceAndStock", BindingFlags.Instance | BindingFlags.NonPublic);
        private static FieldInfo Sale = typeof(ShopMenu).GetField("forSale", BindingFlags.Instance | BindingFlags.NonPublic);
        #endregion
        
        public override void Entry(IModHelper helper)
        {
            SaveEvents.AfterLoad += SaveEvents_AfterLoad;
            MenuEvents.MenuChanged += MenuEvents_MenuChanged;
        }

        private void SaveEvents_AfterLoad(object sender, EventArgs e)
        {
           
        }

        private static void MenuEvents_MenuChanged(object sender, EventArgsClickableMenuChanged e)
        {

        }

    
    }
    }
