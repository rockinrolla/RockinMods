using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using StardewValley;
using StardewModdingAPI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using CustomElementHandler;

namespace RockinMods
{
    class CustomBarnDweller : BarnDweller, ISaveElement
    {
        private Texture2D texture;
        public CustomBarnDwellerData Data;
        public string Type;
        public string ID;
        public int barnHome;
        public int coopHome;
        public int index;
        public int price;

        public CustomBarnDweller()
        {

        }

        public CustomBarnDweller(CustomBarnDwellerData data, string objectID)
        {
            build(data, objectID);
        }

        public void build(CustomBarnDwellerData data, string objectID)
        {
            ID = objectID;
            texture = Helper.Content.Load<Texture2D>(Path.Combine("Animals", data.folderName, data.texture));
            Data = data;
            Type = data.type;
            barnHome = data.barnHome;
            coopHome = data.coopHome;
            index = data.index;
            price = data.price;
        }

        /*
        public CustomBarnDweller(string type, string name) : base()
        {
            Type = type;
            Name = name;
            if (Type == "WhiteBlackCow")
            {
                this.defaultProduceIndex = 184;
                this.sound = "cow";
                this.sprite = new LivestockSprite(Game1.content.Load<Texture2D>("Animals\\BabyWhiteBlackCow"), 0);
                this.ageWhenMature = 1;
                this.daysToLay = 1;
                return;
            }
        }
        */
        public object getReplacement()
        {
            return new BarnDweller();
        }

        public Dictionary<string, string> getAdditionalSaveData()
        {
            Dictionary<string, string> savedata = new Dictionary<string, string>();
            savedata.Add("name", name);
            savedata.Add("id", ID);
            return savedata;
        }

        public void rebuild(Dictionary<string, string> additionalSaveData, object replacement)
        {

            if (replacement is BarnDweller)
            {
                string id = additionalSaveData["id"];
                build(ModEntry.barnDweller[id].Data, id);
            }
        }
    }
}
