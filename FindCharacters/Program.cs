using System;

namespace FindCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterFinder finder = new CharacterFinder();

            Console.Write("Enter word(s): ");
            finder.WordsInput = Console.ReadLine();

            Console.Write("Enter character to find: ");
            finder.CharacterInput = Console.ReadLine().ToString()[0];

            Console.WriteLine("Number of '{0}' in entered word(s): {1}", finder.CharacterInput, finder.CharacterCount);

            Console.WriteLine("Program End.");  //Test github
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}