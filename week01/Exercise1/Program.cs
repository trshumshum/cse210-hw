using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Exercise1 Project.");

        //get first name 
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        //get last name 
        Console.Write("What is your last name: ");
        string last_name = Console.ReadLine();

        //display name in james bond fashion
        Console.WriteLine($"your name is {last_name}, {first_name} {last_name}.");

    }
}