using System;
using System.IO;

namespace TestCode
    {
    class Program
        {
        static void Main(string[] args)
            {

            int current_year = DateTime.Now.Year;

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What year were you born?");
            if(!int.TryParse(Console.ReadLine(), out int birth_year))
            {
                Console.WriteLine("Invalid value entered.");
                return;
            }

            int years_passed = current_year - birth_year;

            Console.WriteLine(name + " was born in " + birth_year);
            Console.WriteLine("That was " + years_passed + " years ago.");

            // Ignore this for now
            // save the info in two separate files
            using (StreamWriter names = File.AppendText("names.txt"))
            using (StreamWriter birth_years = File.AppendText("birth_years.txt"))
            {
                names.WriteLine(name);
                birth_years.WriteLine(birth_year);
            }

            string[] allNames = File.ReadAllLines("names.txt");
            string[] allBirthYears = File.ReadAllLines("birth_years.txt");

            for (int i = 0; i < allNames.Length; i += 1)
            {
                Console.WriteLine($"{allNames[i]} was born in {allBirthYears[i]}. That was {current_year - int.Parse(allBirthYears[i])} years ago.");
            }

            // place those files into one master folder
            // Now output.... "XX was born in XX.  That was XX years ago."
        }
    }
}
