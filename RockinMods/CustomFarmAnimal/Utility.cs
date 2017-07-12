using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewValley;

namespace RockinMods
{
    class CustomUtility
    {
        CustomBarnDweller data = new CustomBarnDweller();
        
        public List<StardewValley.Object> getAnimalStock()
        {
            List<StardewValley.Object> list = new List<StardewValley.Object>();
            StardewValley.Object item = new StardewValley.Object();

            if (data.coopHome == 1 && data.barnHome == 0)
            {
                item = new StardewValley.Object(data.index, 1, false, data.price, 0)
                {
                    name = data.name,
                    type = ((Game1.getFarm().isBuildingConstructed("Coop") || Game1.getFarm().isBuildingConstructed("Deluxe Coop") || Game1.getFarm().isBuildingConstructed("Big Coop")) ? null : Game1.content.LoadString("Strings\\StringsFromCSFiles:Utility.cs.5926", new StardewValley.Object[0])),
                    displayName = Game1.content.LoadString(data.name, new StardewValley.Object[0])
                };
            };
            list.Add(item);

            if (data.coopHome == 0 && data.barnHome == 1)
            {
                item = new StardewValley.Object(data.index, 1, false, data.price, 0)
                {
                    name = data.name,
                    type = ((Game1.getFarm().isBuildingConstructed("Barn") || Game1.getFarm().isBuildingConstructed("Deluxe Barn") || Game1.getFarm().isBuildingConstructed("Big Barn")) ? null : Game1.content.LoadString("Strings\\StringsFromCSFiles:Utility.cs.5931", new StardewValley.Object[0])),
                    displayName = Game1.content.LoadString(data.name, new StardewValley.Object[0])
                };
            };
            list.Add(item);

            if (data.coopHome == 0 && data.barnHome == 2)
            {
                item = new StardewValley.Object(data.index, 1, false, data.price, 0)
                {
                    name = data.name,
                    type = ((Game1.getFarm().isBuildingConstructed("Big Barn") || Game1.getFarm().isBuildingConstructed("Deluxe Barn")) ? null : Game1.content.LoadString("Strings\\StringsFromCSFiles:Utility.cs.5936", new StardewValley.Object[0])),
                    displayName = Game1.content.LoadString(data.name, new StardewValley.Object[0])
                };
            };
            list.Add(item);
            
            if (data.coopHome == 2 && data.barnHome == 0)
            {
                item = new StardewValley.Object(data.index, 1, false, data.price, 0)
                {
                    name = data.name,
                    type = ((Game1.getFarm().isBuildingConstructed("Big Coop") || Game1.getFarm().isBuildingConstructed("Deluxe Coop")) ? null : Game1.content.LoadString("Strings\\StringsFromCSFiles:Utility.cs.5940", new StardewValley.Object[0])),
                    displayName = Game1.content.LoadString(data.name, new StardewValley.Object[0])
                };
            };
            list.Add(item);

            if (data.coopHome == 0 && data.barnHome == 3)
            {
                item = new StardewValley.Object(data.index, 1, false, data.price, 0)
                {
                    name = data.name,
                    type = (Game1.getFarm().isBuildingConstructed("Deluxe Barn") ? null : Game1.content.LoadString("Strings\\StringsFromCSFiles:Utility.cs.5944", new StardewValley.Object[0])),
                    displayName = Game1.content.LoadString(data.name, new StardewValley.Object[0])
                };
            };
                list.Add(item);

            if (data.coopHome == 3 && data.barnHome == 0)
            {
                item = new StardewValley.Object(data.index, 1, false, data.price, 0)
                {
                    name = data.name,
                    type = (Game1.getFarm().isBuildingConstructed("Deluxe Coop") ? null : Game1.content.LoadString("Strings\\StringsFromCSFiles:Utility.cs.5947", new StardewValley.Object[0])),
                    displayName = Game1.content.LoadString(data.name, new StardewValley.Object[0])
                };
            };
                list.Add(item);

            return list;
            }
        }
    }

