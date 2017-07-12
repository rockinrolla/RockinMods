﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockinMods
{
    class CustomBarnDwellerData
    {
        public int id { get; set; }
        public string texture { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string breed { get; set; }
        public int price { get; set; }
        public int index { get; set; }
        public int barnHome { get; set; }
        public int coopHome { get; set; }
        public string folderName { get; set; }

        /*
        public int width { get; set; }
        public int height { get; set; }
        public int boxWidth { get; set; }
        public int boxHeight { get; set; }
        public int rotations { get; set; }
        public int setWidth { get; set; }
        public int animationFrames { get; set; }
        public int fps { get; set; }
        */
        public CustomBarnDwellerData()
        {
            id = 999;
            texture = "cow.png";
            name = "cow";
            description = "Cow";
            type = "barnDweller";
            breed = "brown";
            price = 1000;
            index = 0;
            barnHome = 1;
            coopHome = 0;
            //width = 1;
            //height = 2;
            //boxWidth = 1;
            //boxHeight = 1;
            //rotations = 1;
            //setWidth = -1;
            //animationFrames = 0;
            //fps = 6;
            folderName = "Cow";
        }
    }
}

