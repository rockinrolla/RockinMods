using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewValley;

namespace RockinMods
{
    class NewAnimalHouse : AnimalHouse
    {
        public new SerializableDictionary<long, CustomFarmAnimal> animals;

        public NewAnimalHouse()
        {

        }
    }
}
