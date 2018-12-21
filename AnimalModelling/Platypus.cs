using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalModelling
{
    class Platypus: Mammals,ISwim,IWalk
    {
       
        private const string family = "Ornithorhynchidae";

        public string LivingArea { get; set; }     

        public static string Family => family;

        
    }

    
}

