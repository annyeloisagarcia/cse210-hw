using System;

class Program
{
    static void Main(string[] args)
    {
    

        Console.WriteLine("What is the the grade percentage you received?");
        string answer = Console.ReadLine();
       int gradePercentage = int.Parse(answer);


        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";

        }
        else if (gradePercentage >= 70)
        {
            letter = "c";

        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
            
        }
        else
        {
            letter = "F";

        }
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
            
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }
        Console.WriteLine($"Your letter grade is {letter}.");  
    }
}