using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Menus;

namespace RockinMods
{
    class ModEntry : Mod
    {
        internal static IModHelper Helper;
        internal static CustomUtility Utility;
        internal static Dictionary<string, CustomBarnDweller> barnDweller;

        public override void Entry(IModHelper helper)
        {
            Helper = helper;
            Utility = new CustomUtility();
            barnDweller = new Dictionary<string, CustomBarnDweller>();
            loadPacks();
            
            SaveEvents.AfterReturnToTitle += SaveEvents_AfterReturnToTitle;
            SaveEvents.AfterLoad += SaveEvents_AfterLoad;
        }

        private void SaveEvents_AfterLoad(object sender, EventArgs e)
        {
            MenuEvents.MenuChanged += MenuEvents_MenuChanged;
        }

        private void SaveEvents_AfterReturnToTitle(object sender, EventArgs e)
        {
            MenuEvents.MenuChanged -= MenuEvents_MenuChanged;
        }
        
        private void MenuEvents_MenuChanged(object sender, EventArgsClickableMenuChanged e)
        {
            if (Game1.activeClickableMenu is PurchaseAnimalsMenu)
            {
                //PurchaseAnimalsMenu  animalMenu = (PurchaseAnimalsMenu)Game1.activeClickableMenu;
                //animalMenu = new NewPurchaseAnimalsMenu(Utility.getAnimalStock());

                Game1.activeClickableMenu = new NewPurchaseAnimalsMenu(Utility.getAnimalStock());

                /*Unused Reflection
                FieldInfo menuHeight = typeof(PurchaseAnimalsMenu).GetField("menuHeight", BindingFlags.Static | BindingFlags.NonPublic);
                menuHeight.SetValue(null, Game1.tileSize * 9);

                IPrivateField<List<ClickableTextureComponent>> AnimalsToSell = Helper.Reflection.GetPrivateField<List<ClickableTextureComponent>>(animalMenu, "AnimalsToPurchase");
                */
            }
            
        }

        private void loadPacks()
        {
            int countPacks = 0;
            int countObjects = 0;

            string[] files = parseDir(Path.Combine(Helper.DirectoryPath, "Animals"), "*.json");
          
            countPacks = files.Length;

            foreach (string file in files)
            {
                CustomBarnDwellerPack pack = Helper.ReadJsonFile<CustomBarnDwellerPack>(file);

                foreach (CustomBarnDwellerData data in pack.barnDweller)
                {
                    countObjects++;
                    data.folderName = Path.GetDirectoryName(file);
                    string objectID = data.folderName + "." + Path.GetFileName(file) + "." + data.id;

                    Monitor.Log(objectID, LogLevel.Debug);
                    CustomBarnDweller f = new CustomBarnDweller(data, objectID);

                    barnDweller.Add(objectID, f);
                }
            }
        }

            private string[] parseDir(string path, string extension)
        {
            return Directory.GetFiles(path, extension, SearchOption.AllDirectories);
        }
    }
}
