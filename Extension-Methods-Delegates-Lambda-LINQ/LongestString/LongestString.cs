using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class LongestString
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "thisisaString", "short", "longlonglonglonglong", "a", "asasd" };
            Console.WriteLine("The strings are as follows:");
            Console.WriteLine(string.Join(", ",array));
            var longest =
                from str in array
                where str.Length == array.Max(p=>p.Length)
                select str;
            Console.WriteLine("The longest one is: " + longest.FirstOrDefault());
        }
    }
}
