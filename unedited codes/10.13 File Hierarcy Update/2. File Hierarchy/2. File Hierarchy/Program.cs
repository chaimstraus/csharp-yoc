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
            int birth_year = Convert.ToInt32(Console.ReadLine() );

            Console.Write($"{name} was born in {birth_year}");
            Console.Write(" of the Common Era.");
            Console.WriteLine("That was " + (current_year - birth_year) + " years ago.");

            /* TUTORIAL:
             * Type Casting:    https://www.w3schools.com/cs/cs_type_casting.php
             *
             * Reading Lines of Files:   https://www.techiedelight.com/read-file-line-by-line-csharp/
             *
             * Working with Dates:  https://www.techiedelight.com/get-current-date-without-time-csharp/
             * localization:   https://docs.microsoft.com/en-us/dotnet/api/system.datetime.now?view=net-5.0
             *
             * Next Up:  We will save input data in two separate files
             * Create one master folder called "holder"
             * Inside holder, save the name and date info in .txt files called name.txt and date.txt
             * When the program runs, it will output ALL of the names, dates, and ages on record.
            */

            using (StreamWriter names = File.AppendText("data\\date.txt"))
            using (StreamWriter birth_years = File.AppendText("data\\name.txt"))
            using (StreamWriter output = File.AppendText("data\\output.txt"))
            {
                names.WriteLine(name);
                birth_years.WriteLine(birth_year);
                output.WriteLine($"{name} was born in {birth_year} of the Common Era. That was {current_year - birth_year} years ago.");
            }
        }
    }
}
