using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{
//Implement an extension method Substring(int index, int length) for the class StringBuilder 
//that returns new StringBuilder and has the same functionality as Substring in the class String.

    public static class Extensions
    {
        public static StringBuilder Substring ( this StringBuilder str, int index, int length)
        {
            string temp = str.ToString();
            StringBuilder newOne = new StringBuilder(temp.Substring(index, length));
            return newOne;
        }
    }
    class StringBuilderSubstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets test this!");
            Console.WriteLine("Creating a stringbuilder with text THISISTOOLARGE, and calling the subtring with index = 2 and lenght = 4");
            StringBuilder a = new StringBuilder("THISISTOOLARGE");
            Console.WriteLine(a.Substring(2,4));
        }
    }
}
