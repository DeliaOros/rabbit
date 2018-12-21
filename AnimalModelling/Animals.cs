using System;
using System.Collections.Generic;

namespace AnimalModelling
{
    
   
    public class Animals
    {
        private string name;       
        private double speed;
        

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }        
        public double Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }          

       


        public Animals()
        {
            this.name = "No name";            
            this.speed = 0;
            
        }
        public Animals(string _name, double _speed)
        {
            this.name = _name;
            if (_speed >= 0)
            {
                this.speed = _speed;
            }                   
           
        }
        public void Move()
        {
            Console.WriteLine("{0} moves!", this.name);
        }
        public void Eat()
        {
            Console.WriteLine("{0} eats.",this.name);
        }
        
        
        public void GetMammalsSpeed(string _name,double _speed)
        {
            Console.WriteLine("The speed of {0} is {1}.",this.name,this.speed);
        }
        public void Speak()
        {
            Console.WriteLine("{0} speaks",this.name);
        }
        public void Sleep()
        {
            Console.WriteLine("{0} sleeps. ",this.name);
        }
  
    }
}
