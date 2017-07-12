using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockinMods
{
    class CustomBarnDwellerPack
    {
         
        public string folderName { get; set; }
        public string fileName { get; set; }
        public CustomBarnDwellerData[] barnDweller { get; set; }

        public CustomBarnDwellerPack()
        {
            barnDweller = new CustomBarnDwellerData[] { new CustomBarnDwellerData(), new CustomBarnDwellerData(), new CustomBarnDwellerData(), new CustomBarnDwellerData(), new CustomBarnDwellerData() };
        }
    }
}

