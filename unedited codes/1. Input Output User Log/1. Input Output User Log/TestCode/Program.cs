using System;
using System.IO;

namespace TestCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");

            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);

            string recordValue = "We recorded the username " + userName;

            using (StreamWriter sw = File.AppendText("holder.txt"))
            {
                sw.WriteLine(recordValue);
            }
            string readText = File.ReadAllText("holder.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content
        }
    }
}
