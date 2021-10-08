using System;
using System.IO;

namespace TestCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int this_year = 2022;

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine("What year were you born?");
            int birth_year = Console.ReadLine();

            Console.WriteLine(name + " was born in " + birth_year);
            Console.WriteLine("That was " + " years ago.");

        // Ignore this for now
        // save the info in two separate files
        // place those files into one master folder
        // Now output.... "XX was born in XX.  That was XX years ago."
        }
    }
}
