using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to counter the words:");
            string str = Console.ReadLine();

            System.Text.StringBuilder sb = new System.Text.StringBuilder
                //("This is to test whether the extension method count can return a right answer or not");
                (str);

            int numberOfWords = sb.CountWords();

            Console.WriteLine("\nThe given string has " + numberOfWords + " words.");
            Console.ReadKey();
        }
    }
}
