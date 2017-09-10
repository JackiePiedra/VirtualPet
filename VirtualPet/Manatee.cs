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
        }

        public int BoredomLevel
        {
            get { return boredomLevel; }
        }

        public Manatee()
        {
            this.name = "Hugh";
            this.age = 2;
            this.hungerLevel = 0;
            this.boredomLevel = 0;
            this.sleepyLevel = 0;
            this.happyLevel = 100;
        }

        //hungry -- each time manatee is fed, -30 hungryLevel and +10 sleepyLevel and +10 happyLevel
        //boredom -- each time manatee sleeps, +40 boredomLevel. each manatee plays, -20 boredomLevel
        //sleeps -- each time manatee sleeps, +25 hungryLevel and +40 boredomLevel and +10 happyLevel
        //plays -- each time manatee plays, +40 hungryLevel and +30 happyLevel and +25 sleepyLevel

        public void Eat()
        {
            if (this.hungerLevel < 50)
            {
                Console.WriteLine("No thanks, I'm not really hungry..");
            }
            else if (this.hungerLevel >= 50 && this.hungerLevel > 75)
            {
                this.hungerLevel -= 10;
                this.sleepyLevel += 10;
                this.happyLevel += 10;
                Console.WriteLine("Why thank you! I think I will have a snack!");
            }
            else
            {
                this.hungerLevel -= 30;
                this.sleepyLevel += 10;
                this.happyLevel += 10;
                Console.WriteLine("I was famished... but now I am pretty stuffed for a while!");
            }
        }

        public void Sleep()
        {
            if (this.sleepyLevel < 80)
            {
                Console.WriteLine("I'm bright eyed and bushy tailed, no time for napping!");
            }
            else if (this.sleepyLevel >= 80)
            {
                this.sleepyLevel -= 40;
                this.happyLevel += 10;
                this.boredomLevel += 40;
                this.hungerLevel += 25;
                Console.WriteLine("Yaaawnn... Time for some Zzzz's");
            }
        }

        public void Play()
        {
            this.hungerLevel += 40;
            this.sleepyLevel += 20;
            this.happyLevel += 30;
        }

    }
}
