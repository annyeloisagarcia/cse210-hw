using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("7. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": manager.CreateGoalMenu(); break;
                case "2": manager.DisplayGoals(); break;
                case "3": manager.RecordEventMenu(); break;
                case "4": manager.SaveGoals("goals.txt"); break;
                case "5": manager.LoadGoals("goals.txt"); break;
                case "6": manager.ShowScore(); break;
                case "7": running = false; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }
}
