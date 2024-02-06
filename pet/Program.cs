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

    }
}