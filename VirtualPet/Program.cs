﻿using System;
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
            Console.WriteLine("Welcome to virtual pet -- meet your new pet, Hugh Manatee!");
            Console.WriteLine("He is a manatee from the waters of Florida and is {0} years old!", manatee.Age);
            Console.WriteLine("\nWhat is your name?");
            string ownerName = Console.ReadLine();

            Console.WriteLine("Hugh is so happy to meet you, {0}! Let's get started..", ownerName);
            int userInput;
            do
            {
                Console.WriteLine("\n{0} the Manatee", manatee.Name);
                Console.WriteLine("\n\tHappy Level: {0}", manatee.HappyLevel);
                Console.WriteLine("\tBoredom Level: {0}", manatee.BoredomLevel);

                Console.WriteLine("\nWhat do you want to do with {0}?", manatee.Name);
                Console.WriteLine("1. Feed him");
                Console.WriteLine("2. Play with him");
                Console.WriteLine("3. Put him down for a nap");
                Console.WriteLine("4. Send him off to Sea World :(");
                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        manatee.Eat();
                        break;
                    case 2:
                        manatee.Play();
                        break;
                    case 3:
                        manatee.Sleep();
                        break;
                    case 4:
                        Console.WriteLine("Well it's been fun...");
                        break;
                    default:
                        Console.WriteLine("Hmmm... I don't think {0} wants to do that. Pick something else.", manatee.Name);
                        break;

                }


            } while (userInput != 4);

            Console.WriteLine("Thanks for everything, {0}, but I am off to Sea World now..", ownerName);


        }
        
    }
}
