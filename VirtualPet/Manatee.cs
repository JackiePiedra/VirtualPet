using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Manatee
    {
        private string name;
        private int age;
        private int hungerLevel;
        private int boredomLevel;
        private int sleepyLevel;
        private int happyLevel;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
        }

        public int HappyLevel
        {
            get { return happyLevel; }
            set
            {
                if (value < 0)
                {
                    happyLevel = 0;
                }
                else if (value > 100)
                {
                    happyLevel = 100;
                }
                else
                {
                    happyLevel = value;
                }
            }
        }

        public int BoredomLevel
        {
            get { return boredomLevel; }
            set
            {
                if (value < 0)
                {
                    boredomLevel = 0;
                }
                else if (value > 100)
                {
                    boredomLevel = 100;
                }
                else
                {
                    boredomLevel = value;
                }
            }
        }

        public int HungerLevel
        {
            get { return hungerLevel; }
            set
            {
                if (value < 0)
                {
                    hungerLevel = 0;
                }
                else if (value > 100)
                {
                    hungerLevel = 100;
                }
                else
                {
                    hungerLevel = value;
                }
            }
        }

        public int SleepyLevel
        {
            
            set
            {
                if (value < 0)
                {
                    sleepyLevel = 0;
                }
                else if (value > 100)
                {
                    sleepyLevel = 100;
                }
                else
                {
                    sleepyLevel = value;
                }
            }
            get { return sleepyLevel; }
        }

        public Manatee()
        {
            this.name = "Hugh";
            this.age = 2;
            this.hungerLevel = 50;
            this.boredomLevel = 50;
            this.sleepyLevel = 50;
            this.happyLevel = 50;
        }
        
        public void Eat()
        {
            if (this.hungerLevel < 50)
            {
                Console.WriteLine("\n\tNo thanks, I'm not really hungry.. --- "+Name);
            }
            else if (this.hungerLevel >= 50 && this.hungerLevel < 70)
            {
                this.hungerLevel -= 10;
                this.sleepyLevel += 10;
                //this.happyLevel += 2;
                this.boredomLevel += 10;
                Console.WriteLine("\n\tWhy thank you! I think I will have a snack! --- "+Name);
                Console.WriteLine("\nWhat do you want to feed Hugh?");
                Console.WriteLine("1. Apple \n2. Fish");
                int snack = int.Parse(Console.ReadLine());
                if(snack == 1 || snack ==2)
                {
                    Console.WriteLine("\n\tYummy! Thanks! --- "+Name);
                }
                else
                {
                    Console.WriteLine("\n\tHmm, no thanks! Maybe next time! --- "+Name);
                }
            }
            else
            {
                this.hungerLevel -= 10;
                this.sleepyLevel += 10;
                this.happyLevel += 5;
                this.boredomLevel += 10;
                Console.WriteLine("\n\tLobster Bisque --  my favorite!");
                Console.WriteLine("\tI was famished... but now I am pretty stuffed for a while! --- "+Name);
            }
        }

        public void Sleep()
        {
            if (this.sleepyLevel < 60)
            {
                Console.WriteLine("\n\tI'm bright eyed and bushy tailed, no time for napping! --- "+Name);
            }
            else if (this.sleepyLevel >= 60)
            {
                this.sleepyLevel -= 20;
                this.happyLevel -= 20; //he's a cranky sleeper
                this.boredomLevel += 10;
                this.hungerLevel += 10;
                Console.WriteLine("\n\tYaaawnn... Time for some Zzzz's --- "+Name);
            }
        }

        public void Play()
        {
            this.hungerLevel += 10;
            this.sleepyLevel += 10;
            this.happyLevel += 10;
            this.boredomLevel -= 10;
            Console.WriteLine("Fun! What do you want to play?");
            Console.WriteLine("1. Hide and seek");
            Console.WriteLine("2. Have a swimming race");
            int playAnswer = int.Parse(Console.ReadLine());
            switch(playAnswer)
            {
                case 1:
                    Console.WriteLine("\n\tI'll count to 10..");
                    Console.WriteLine("\t1, 2, 3, 4, 5, 6, 7, 8, 9, 10... Ready or not here I come!");
                    Console.WriteLine("\tI found you! That was fun! --- "+ Name );
                    break;
                case 2:
                    Console.WriteLine("\n\tOkay! On your mark, get set... GO!");
                    Console.WriteLine("\tI won!! --- " + Name);
                    break;
                default:
                    Console.WriteLine("\n\tOr we can just dance... Woo hoo! --- "+Name);
                    break;
            }
        }

    }
}
