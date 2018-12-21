using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalModelling
{
    public class Mammals : Animals, IAnimalMovements
    {

           
        private int nrOfWings;       
       

        public int NrOfWings
        {
            get
            {
                return this.nrOfWings;
            }
            set
            {
                this.nrOfWings = value;
            }
        }

       
        
        public Mammals() : base()
        {

        }


        public void BreastFeed()
        {
            Console.WriteLine("{0} is breastfeeding the puppies", this.Name);
        }

        public void Crawl()
        {
            Console.WriteLine("{0} exceptionally crawls.", this.Name);
        }

        public void Fly()
        {
            if (NrOfWings != 0)
            {
                Console.WriteLine("{0} might fly.", this.Name); 
            }
            else
            {
                Console.WriteLine("{0} doesn't fly.", this.Name);
            }
            
        }

        public void Swim()
        {
            Console.WriteLine("{0} swims.",this.Name); 
        }

        public void UncategorisedMove()
        {
            Console.WriteLine("{0} jumps all over the fields", this.Name);
        }

        public void Walk()
        {
            Console.WriteLine("{0} walks.", this.Name);
        }
        

        
    }
}
