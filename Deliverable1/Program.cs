using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool calculatingSammiches = true;
            double bread;
            double peanutButter;
            double jelly;
            double loavesOfBread;
            double jarsOfPeanutButter;
            double jarsOfJelly;
            bool wannaRestart;

            Console.WriteLine("Hello!");
            Console.WriteLine("Welcome to the PB&J Sammich Calculator.");

            while (calculatingSammiches)
            {
                Console.WriteLine("");
                Console.WriteLine("How many people are we making P B and J sandwiches for?");
                int sammiches = int.Parse(Console.ReadLine());

                if (sammiches >= 1)
                {
                    bread = sammiches * 2;
                    peanutButter = sammiches * 2;
                    jelly = sammiches * 4;

                    Console.WriteLine("");
                    Console.WriteLine("You'll need:");
                    Console.WriteLine($"\t{bread} slices of bread.");
                    Console.WriteLine($"\t{peanutButter} tablespoons of peanut butter.");
                    Console.WriteLine($"\t{jelly} teaspoons of jelly.");
                    Console.WriteLine("");
                    Console.WriteLine("Which is:");

                    loavesOfBread = (bread / 28);
                    loavesOfBread = Math.Ceiling(loavesOfBread);
                    if (loavesOfBread <= 1)
                    {
                        Console.WriteLine($"\t{loavesOfBread} loaf of bread.");

                    }
                    else
                    {
                        Console.WriteLine($"\t{loavesOfBread} loaves of bread.");
                    }

                    jarsOfPeanutButter = (peanutButter / 32);
                    jarsOfPeanutButter = Math.Ceiling(jarsOfPeanutButter);
                    if (jarsOfPeanutButter <= 1)
                    {
                        Console.WriteLine($"\t{jarsOfPeanutButter} jar of peanut butter.");

                    }
                    else
                    {
                        Console.WriteLine($"\t{jarsOfPeanutButter} jars of peanut butter.");
                    }

                    jarsOfJelly = (jelly / 48);
                    jarsOfJelly = Math.Ceiling(jarsOfJelly);
                    if (jarsOfJelly <= 1)
                    {
                        Console.WriteLine($"\t{jarsOfJelly} jar of jelly.");

                    }
                    else
                    {
                        Console.WriteLine($"\t{jarsOfJelly} jars of jelly.");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, friend. We've got to have at least one person we're making sammiches for to calculate.");
                }

                wannaRestart = true;
                while (wannaRestart == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to restart?");
                    Console.WriteLine("Enter 'Y' for YES to Restart, or 'N' for NO to Exit the program.");
                    string input = Console.ReadLine().ToLower();

                    if (input == "n" || input == "no")
                    {
                        wannaRestart = false;
                        calculatingSammiches = false;
                    }
                    else if (input == "y" || input == "yes")
                    {
                        wannaRestart = false;
                        calculatingSammiches = true;
                        Console.WriteLine("");
                        Console.WriteLine("More Sammich Calculations Comin' Your Way!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I'm Sorry, I didnt understand that response. Please try again.");
                        Console.WriteLine("");
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Thank you for using the PB&J Sammich Calculator!");
            Console.WriteLine("Goodbye ...");
            Console.WriteLine("");
        }
    }
}
