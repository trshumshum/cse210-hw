using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Exercise5 Project.");
        DisplayWelcome();
        string UserNameString = PromptUserName();
        int FavNumberInt = PromptUserNumber();
        int SquareRootInt = SquareNumber(FavNumberInt);
        DisplayResult(UserNameString, SquareRootInt);

    }

    //Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please Enter your name: ");
        string input = Console.ReadLine();
        return input;
    }

    //Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please Enter your favorite number: ");
        string InputString = Console.ReadLine();
        int input = int.Parse(InputString);
        return input;
    }

    //Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int FavNumber)
    {
        int input = FavNumber * FavNumber;
        return input;
    }

    //Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string Name, int SquaredNumber)
    {
        Console.Write($"{Name}, the square of your number is: {SquaredNumber}");
    }
}