using System;

namespace Variables_MadLib_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an adjective:");
            string adjective = Console.ReadLine();
            Console.WriteLine("Please enter a different adjective:");
            string adjective2 = Console.ReadLine();
            Console.WriteLine("Please enter a type of bird:");
            string typeOfBird = Console.ReadLine();
            Console.WriteLine("Please enter a room in a house:");
            string roomInAHouse = Console.ReadLine();
            Console.WriteLine("Please enter a past-tense verb:");
            string pastTenseVerb = Console.ReadLine();
            Console.WriteLine("Please enter a verb:");
            string verb = Console.ReadLine();
            Console.WriteLine("Please enter a relative's name:");
            string relativesName = Console.ReadLine();
            Console.WriteLine("Please enter a noun:");
            string noun = Console.ReadLine();
            Console.WriteLine("Please enter a liquid:");
            string typeOfLiquid = Console.ReadLine();
            Console.WriteLine("Please enter a verb that ends in -ing");
            string verbEndingInING = Console.ReadLine();
            Console.WriteLine("Please enter a plural body part:");
            string pluralPartOfTheBody = Console.ReadLine();
            Console.WriteLine("Please enter a plural noun:");
            string pluralNoun = Console.ReadLine();
            Console.WriteLine("Please enter a different verb that ends in -ing");
            string secondVerbEndingInING = Console.ReadLine();
            Console.WriteLine("Please enter a second noun:");
            string noun2 = Console.ReadLine();

            // Give values to the variables above by taking input from the user. Example-- string variableName = Console.ReadLine();
            // Be sure to prompt the user before each value is assigned. Example -- Console.WriteLine("Please give me an adjective.");
            
           
            // MadLib
            Console.WriteLine($"It was a {adjective}, cold November day, I woke up to the {adjective2} smell of {typeOfBird} roasting in the {roomInAHouse} downstairs.\nI {pastTenseVerb} down the stairs to see if I could help {verb} the dinner.\nMy mom said, 'See if {relativesName} needs a fresh {noun}.'\nSo I carried a tray of glasses full of {typeOfLiquid} into the {verbEndingInING} room.\nWhen I got there I couldn't believe my {pluralPartOfTheBody}! There were {pluralNoun} {secondVerbEndingInING} on the {noun2}!");
            
            // Run the application and see your story you've created

            
        }
    }
}
