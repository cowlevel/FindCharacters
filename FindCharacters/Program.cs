using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Enter word(s): ");
            input = Console.ReadLine();

            Console.WriteLine(input);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}