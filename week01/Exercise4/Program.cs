using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;


        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to stop): ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }


        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }


        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");


        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");


        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum number is: {max}");
    }
}
