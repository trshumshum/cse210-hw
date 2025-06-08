using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Exercise2 Project.");

        //get grade percentage from user
        Console.Write("Please give me your grade percenage: ");
        string GradeString = Console.ReadLine();

        //convert GradeString to GradeInt
        int GradeInt = int.Parse(GradeString);

        //calculate the grade, if they passed and assign GradeLetter
        string GradeLetter = "x";
        bool Passed = GradeInt >= 70;
        if (GradeInt >= 90) GradeLetter = "A";
        else if (GradeInt >= 80) GradeLetter = "B";
        else if (GradeInt >= 70) GradeLetter = "c";
        else if (GradeInt >= 60) GradeLetter = "D";
        else GradeLetter = "F";

        //print out grade letter
        Console.WriteLine($"Your Grade is: {GradeLetter} ");

        if (Passed)
            Console.Write("Congratulation you passed the Class!");
        else
            Console.Write("Sorry, you didn't pass. Keep trying.");


    }
}