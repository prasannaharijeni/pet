using System;
using System.Threading;

class Assignment1
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Virtual Pet Simulator!");

        // Pet Creation
        Console.Write("Enter pet type (e.g., cat, dog, rabbit): ");
        string petType = Console.ReadLine();
        Console.Write("Enter pet name: ");
        string petName = Console.ReadLine();

        // Pet Initialization
        int hunger = 5;
        int happiness = 5;
        int health = 5;

        Console.WriteLine($"You have a {petType} named {petName}.");

        //Initializing the loop for repeative actions
        while (true)
        {
            // To display Pet Stats

            Console.WriteLine($"\nPet Stats: Hunger: {hunger}/10 | Happiness: {happiness}/10 | Health: {health}/10");


            // User Interaction Menu
            Console.WriteLine("Choose an action: \n1. Feed\n2. Play\n3. Rest\n4. Exit");
            //Input option selected from the user
            string userInput = Console.ReadLine();
            
            }
        }

        }
}