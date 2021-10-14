using System;
using System.IO;

namespace TestCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int this_year = Convert.ToInt32(DateTime.UtcNow.ToString("yyyy"));

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What year were you born?");
            int birth_year = Convert.ToInt32(  Console.ReadLine() );

            Console.Write("{0} was born in {1}" ,name, birth_year);
            Console.WriteLine(" of the Common Era.");
            Console.WriteLine("That was " + (this_year - birth_year) + " years ago.");

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
        }
    }
}
