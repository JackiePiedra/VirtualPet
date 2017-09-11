using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Manatee manatee = new Manatee();
            Console.WriteLine("Thank you for adopting a virtual pet! Let's meet him, shall we?");
            Console.WriteLine("\nMeet {0}!", manatee.Name);
            Console.WriteLine("He is a manatee from the waters of Florida and is {0} years old!", manatee.Age);
            Console.WriteLine("Did you want to change his name?\n1. Yes \n2. No");
            int nameChange = int.Parse(Console.ReadLine());
            if (nameChange == 1)
            {
                Console.WriteLine("What is his new name?");
                manatee.Name = Console.ReadLine();
                Console.WriteLine("\n{0}, huh? He likes it!", manatee.Name);
            }
            else if (nameChange == 2)
            {
                Console.WriteLine("Then {0} it is!", manatee.Name);
            }
            else
            {
                Console.WriteLine("I didn't understand that.. let's keep it at {0}.", manatee.Name);
            }

          
           
            
            Console.WriteLine("\nWhat is your name?");
            string ownerName = Console.ReadLine();

            Console.WriteLine("\nWell, {0} is so happy to meet you, {1}!", manatee.Name, ownerName);
            Console.WriteLine("Make sure {0} doesn't get too sleepy or hungry or bored!", manatee.Name);
            Console.WriteLine("You can always send {0} off to Sea World to live out the rest of his manatee days if you want..",manatee.Name);
            Console.WriteLine("\nLet's get started!");
            Console.ReadLine();
            Console.Clear();
          
            bool quit = true;
            do
            {
                Console.WriteLine("\n{0} the Manatee", manatee.Name);
                Console.WriteLine("\n\tHappy Level: {0}", manatee.HappyLevel);
                Console.WriteLine("\tBoredom Level: {0}", manatee.BoredomLevel);
                Console.WriteLine("\tHunger Level: {0}", manatee.HungerLevel);
                Console.WriteLine("\tSleepy Level: {0}", manatee.SleepyLevel);

                Console.WriteLine("\nWhat do you want to do with {0}?", manatee.Name);
                Console.WriteLine("1. Feed him");
                Console.WriteLine("2. Play with him");
                Console.WriteLine("3. Put him down for a nap");
                Console.WriteLine("4. Send him off to Sea World :(");
                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        manatee.Eat();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        manatee.Play();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        manatee.Sleep();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("\n\n\tThanks for everything, {0}, but I am off to Sea World now.. \n\n\t\t\tI'll miss you!", ownerName);
                        Console.WriteLine("");
                        quit = false;
                        break;
                    default:
                        Console.WriteLine("Hmmm... I don't think {0} wants to do that. Pick something else.", manatee.Name);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                }


            } while (quit);

            
        }
       
        
    }
}
