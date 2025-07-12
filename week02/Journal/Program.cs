// Creativity. I desined the program and added extra spaces to the console output to make it more readable.
// This program is a simple journal application that allows users to create, display, save, and load journal entries.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        Entry entry = new Entry();
       

        while (true)
        {
            Console.WriteLine("welcome to the Journal Program!");
            Console.WriteLine("");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("");
            Console.WriteLine("1. Entry");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
             Console.WriteLine("");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    entry._date = DateTime.Now.ToString("yyyy-MM-dd");
                    entry._prompText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"^ {entry._prompText}");
                    Console.Write("^ ");
                    entry._entryText = Console.ReadLine();
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("File saved.");
                    break;

                case "4":
                    Console.Write("Enter file name to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("File loaded.");
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }


        }
    }
}