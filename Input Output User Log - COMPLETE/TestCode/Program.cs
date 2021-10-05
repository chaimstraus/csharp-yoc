using System;
using System.IO;

namespace TestCode
{
    class Program
    {
        static void Main(string[] args)
        {
            const string namesFile = "holder.txt";

            Console.WriteLine("Enter username:");

            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);

            string recordValue = userName;

            using (StreamWriter sw = File.AppendText(namesFile))
            {
                sw.WriteLine(recordValue);
            }

            // string readText = File.ReadAllText("holder.txt"); // Read the contents of the file
            // Console.WriteLine(readText); // Output the content
            foreach (string name in File.ReadLines(namesFile))
            {
                Console.WriteLine("We've recorded the username " + name);
            }
        }
    }
}
