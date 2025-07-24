// Creativity: Prompt user to choose a verse
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.\n");

        Reference reference = new Reference("1 Nephi", 3, 7);

        Scripture scripture = new Scripture(reference,
            "And it came to pass that I, Nephi, said unto my father: " +
            "I will go and do the things which the Lord hath commanded, " +
            "for I know that the Lord giveth no commandments unto the children of men, " +
            "save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
        );

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to end.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are now hidden or you exited. Goodbye!");
    }
}
