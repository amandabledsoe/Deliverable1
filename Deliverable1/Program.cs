using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool calculatingSammiches = true;
            int bread;
            int peanutButter;
            int jelly;
            int loavesOfBread;
            int jarsOfPeanutButter;
            int jarsOfJelly;
            bool wannaRestart;

            Console.WriteLine("Hello!");
            Console.WriteLine("Welcome to the PB&J Sammich Calculator.");

            while (calculatingSammiches)
            {
                Console.WriteLine("");
                Console.WriteLine("How many people are we making P B and J sandwiches for?");
                int sammiches = int.Parse(Console.ReadLine());

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
                if (loavesOfBread <= 1) 
                {
                    loavesOfBread = 1;
                    Console.WriteLine($"\t{loavesOfBread} loaf of bread.");
                        
                }
                else
                {
                    Console.WriteLine($"\t{loavesOfBread} loaves of bread.");
                }

                jarsOfPeanutButter = (peanutButter / 32);
                if (jarsOfPeanutButter <= 1)
                {
                    jarsOfPeanutButter = 1;
                    Console.WriteLine($"\t{jarsOfPeanutButter} jar of peanut butter.");

                }
                else
                {
                    Console.WriteLine($"\t{jarsOfPeanutButter} jars of peanut butter.");
                }

                jarsOfJelly = (jelly / 48);
                if (jarsOfJelly <= 1)
                {
                    jarsOfJelly = 1;
                    Console.WriteLine($"\t{jarsOfJelly} jar of jelly.");

                }
                else
                {
                    Console.WriteLine($"\t{jarsOfJelly} jars of jelly.");
                }


                wannaRestart = true;
                while (wannaRestart == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to restart?");
                    Console.WriteLine("Enter 'Y' for YES to Restart, or 'N' for NO to Exit the program.");
                    string input = Console.ReadLine().ToLower();

                    if (input == "n")
                    {
                        wannaRestart = false;
                        calculatingSammiches = false;
                    }
                    else if (input == "y")
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
