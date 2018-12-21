using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalModelling
{
    class Reptiles:Animals, ICrawl
    {
        private bool hasScales;
        private int hasLegs;

        public int NrOfLegs { get; set; }


        public bool HasScales
        {
            get
            {
                if (this.hasScales == true)
                {
                    return hasScales;
                }
                else
                {
                    return false;
                }
                
            }
            set
            {
                if (this.hasScales == true)
                {
                    hasScales=true;
                }
                else
                {
                    hasScales=false;
                }

            }
            
        }

        public void Crawl()
        {

            if (NrOfLegs == 0)
            {
                Console.WriteLine("{0} crawls. ", this.Name);
            }
            else
            {
                Console.WriteLine("{0} does not crawl. ", this.Name);
            }
        }
    }
}
