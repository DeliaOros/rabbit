using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalModelling
{
    class Program
    {


        static void Main(string[] args)
        {
            Rabbit iepurila = new Rabbit(2016, 05, 03, EyeColors.Red, FurColors.white, Gender.Male)
            {
                Name = "Iepurila",
                Speed = 45
            };

            Console.WriteLine(iepurila);

            iepurila.Move();
            iepurila.Eat();
            iepurila.Sleep();




            //Animals Octopus = new Animals();
            //Octopus.Name = "Octopussy";
            //Octopus.Move();
            //Console.WriteLine(Octopus.Name);
            //Octopus.Sleep();           

            //Mammals deer = new Mammals();
            //deer.Name = "Bamby";            
            //deer.BreastFeed();
            //deer.UncategorisedMove();
            //deer.FurColor = "white";
            //deer.HasFur();
            //deer.Swim();
            //deer.Fly();

            //Platypus ducky = new Platypus();
            //ducky.Name = "Ducky";
            //ducky.LivingArea = "Australia";
            //ducky.Speed = 10;
            //ducky.Eyes = "Blue";
            //ducky.FurColor = "Grey";
            //ducky.GetMammalsSpeed(ducky.Name,ducky.Speed);
            //ducky.HasFur();
            //ducky.Fly();

            //Insects libelul = new Insects();
            //libelul.Eyes = "blue";
            //libelul.Name = "Libby";
            //libelul.Speed = 40;
            //libelul.Move();
            //libelul.Sleep();
            //libelul.Speak();
            //libelul.NrOfLegs = 0;
            //libelul.NrOfWings = 4;
            //libelul.Crawl();
            //libelul.Fly();


            //Reptiles snake = new Reptiles();     
            //snake.Name = "Snacky";
            //snake.NrOfLegs = 0;
            //snake.Speed = 10;
            //snake.Eyes = "Green";
            //snake.Crawl();

            //Mammals bat = new Mammals();
            //bat.Name = "Batty";
            //bat.Speed = 35;
            //bat.NrOfWings = 2;            
            //bat.Fly();

                                                                              
        }


    }
}
