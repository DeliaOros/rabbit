using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalModelling
{
    public enum FurColors { white, brown, black, grey }
    public enum EyeColors { Blue, Red, Black }
    public enum Gender { Male, Female }
    

    public class Rabbit : Mammals
    {
        private EyeColors rabbitEyeColor;
        private FurColors rabbitFurColor;
        private Gender rabbitGender;
        private DateTime birthDayDate;


        public List<string> RabbitFood
        {
            get
            {                
                return Eat();
            }            
        }

        public EyeColors RabbitEyeColor
        {
            get
            {
                return this.rabbitEyeColor;
            }
        }

        public FurColors RabbitFurColor
        {
            get
            {

                return this.rabbitFurColor;
            }
        }
        public Gender RabbitGender
        {
            get
            {

                return this.rabbitGender;
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - birthDayDate.Year;

                if (DateTime.Now.Month < birthDayDate.Month ||
                   ((DateTime.Now.Month == birthDayDate.Month) && (DateTime.Now.Day < birthDayDate.Day)))
                {
                    age--;
                }

                return age;
            }
        }
        public DateTime BirthDayDate
        {
            get
            {
                Console.WriteLine($"{birthDayDate.Date,-10:d}");
                return birthDayDate;
            }
            set
            {
                birthDayDate = value;
            }
        }


        public Rabbit(int year, int month, int day, EyeColors eyeColor, FurColors furColor, Gender gender) : base()
        {
            birthDayDate = new DateTime(year, month, day);
            this.rabbitEyeColor = eyeColor;
            this.rabbitFurColor = furColor;
            this.rabbitGender = gender;

        }
        public new List<string> Eat()
        {
            List<string> Food = new List<string>();
            Food.Add("carrots");
            Food.Add("fresh grass");
            Food.Add("cabbage");
            Console.WriteLine($"Rabbits like to eat:");
            foreach (var food in Food)
            {
                Console.WriteLine($"{food} ");
            }
            return Food;
        }
        public new void Sleep()
        {
            Console.WriteLine("{0} sleeps ...rabbitish :).", this.Name);
        }

        public Rabbit()
        {
        }

        public override string ToString()
        {

            return $"{this.Name} is a {this.RabbitGender.ToString().ToLower()} rabbit, it has {this.RabbitFurColor.ToString()} fur color and {this.RabbitEyeColor.ToString().ToLower()} eyes. It is {this.Age.ToString()} years old.";

        }
    }
}
