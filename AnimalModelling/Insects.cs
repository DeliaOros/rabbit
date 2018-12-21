using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalModelling
{
    class Insects:Animals,IFly,ICrawl
    {
        private int nrOfWings;
        private int nrOfLegs;
        public int NrOfWings{ get; set; }
        public int NrOfLegs { get; set; }

        public void Crawl()
        {

            if (NrOfLegs == 0)
            {
                Console.WriteLine("{0} does not crawl. ", this.Name);               
            }
            else
            {
               Console.WriteLine("{0} crawls.", this.Name);               
            }
        }

        public void Fly()
        {
            if (NrOfWings == 0)
            {
                Console.WriteLine("{0} doesn't fly.", this.Name);
            }
            else
            {
                Console.WriteLine("{0} maybe flies.", this.Name);
            }
        }

        
    }
}
