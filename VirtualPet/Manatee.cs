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
            //get { return happyLevel; }
            set
            {
                if(value < 0)
                {
                    happyLevel = 0;
                }
                else if(happyLevel >100)
                {
                    happyLevel = 100;
                }
                else
                {
                    happyLevel = value;
                }
            }
            get { return happyLevel; }
        }

        public int BoredomLevel
        {
            //get { return boredomLevel; }
            set
            {
                if(boredomLevel<0)
                {
                    value = 0;
                }
                else if(boredomLevel>100)
                {
                    value = 100;
                }
                else
                {
                    boredomLevel = value;
                }

            }
            get { return boredomLevel; }
        }

        public Manatee()
        {
            this.name = "Hugh";
            this.age = 2;
            this.hungerLevel = 0;
            this.boredomLevel = 0;
            this.sleepyLevel = 0;
            this.happyLevel = 50;
        }

        //hungry -- each time manatee is fed, -30 hungryLevel and +10 sleepyLevel and +10 happyLevel -- EAT
        //boredom -- each time manatee sleeps, +40 boredomLevel. each manatee plays, -20 boredomLevel
        //sleeps -- each time manatee sleeps, +25 hungryLevel and +40 boredomLevel and +10 happyLevel -- SLEEP
        //plays -- each time manatee plays, +40 hungryLevel and +30 happyLevel and +25 sleepyLevel -- PLAY

        public void Eat()
        {
            if (this.hungerLevel < 50)
            {
                Console.WriteLine("\n\tNo thanks, I'm not really hungry..");
            }
            else if (this.hungerLevel >= 50 && this.hungerLevel > 75)
            {
                this.hungerLevel -= 10;
                this.sleepyLevel += 10;
                this.happyLevel += 10;
                this.boredomLevel += 10;
                Console.WriteLine("\n\tWhy thank you! I think I will have a snack!");
                Console.WriteLine("\nWhat do you want to feed Hugh?");
                Console.WriteLine("1. Apple \n2. Fish");
                int snack = int.Parse(Console.ReadLine());
                if(snack == 1 || snack ==2)
                {
                    Console.WriteLine("\n\tYummy! Thanks!");
                }
                else
                {
                    Console.WriteLine("\n\tHmm, no thanks! Maybe next time!");
                }
            }
            else
            {
                this.hungerLevel -= 30;
                this.sleepyLevel += 10;
                this.happyLevel += 10;
                this.boredomLevel += 10;
                Console.WriteLine("\n\tLobster Bisque --  my favorite!");
                Console.WriteLine("\tI was famished... but now I am pretty stuffed for a while!");
            }
        }

        public void Sleep()
        {
            if (this.sleepyLevel < 80)
            {
                Console.WriteLine("\n\tI'm bright eyed and bushy tailed, no time for napping!");
            }
            else if (this.sleepyLevel >= 80)
            {
                this.sleepyLevel -= 50;
                this.happyLevel += 10;
                this.boredomLevel += 20;
                this.hungerLevel += 20;
                Console.WriteLine("\n\tYaaawnn... Time for some Zzzz's");
            }
        }

        public void Play()
        {
            this.hungerLevel += 40;
            this.sleepyLevel += 20;
            this.happyLevel += 30;
            this.boredomLevel -= 30;
            Console.WriteLine("Fun! What do you want to play?");
            Console.WriteLine("1. Hide and seek");
            Console.WriteLine("2. Do a swim race");
            int playAnswer = int.Parse(Console.ReadLine());
            switch(playAnswer)
            {
                case 1:
                    Console.WriteLine("\n\tI'll count to 10..");
                    Console.WriteLine("\t1, 2, 3, 4, 5, 6, 7, 8, 9, 10... Ready or not here I come!");
                    Console.WriteLine("\tI found you! That was fun!");
                    break;
                case 2:
                    Console.WriteLine("\n\tOkay! On your mark, get set... GO!");
                    Console.WriteLine("\tI won!!");
                    break;
                default:
                    Console.WriteLine("\n\tOr we can just dance... Woo hoo!");
                    break;
            }
        }

    }
}
