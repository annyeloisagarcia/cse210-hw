using System;
using System.Collections.Generic;
 
class Program
{  
    static void Main(string[] args)
        {
                Reference ref1 = new Reference("1 Nephi", 3, 7);

                Scripture scripture = new Scripture(ref1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

                Console.WriteLine(scripture.GetDisplayText());

                scripture.HideRandomWords(3);
                Console.WriteLine(scripture.GetDisplayText());

                Console.WriteLine("Is completely hidden? " + scripture.IsCompletelyHidden());
        }
}
