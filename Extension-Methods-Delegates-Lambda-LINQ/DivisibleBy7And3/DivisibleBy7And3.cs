using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7And3
{
    //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
    //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
    class DivisibleBy7And3
    {

        static void Main(string[] args)
        {
            int[] nums = new int[]{52, 35, 21, 42};
            Console.WriteLine("Input is: 52,35,41,42");
            var firstResult = nums.Where(x => x % 7 == 0 && x % 3 == 0);
            Console.WriteLine("Result using Lambda:");
            Console.WriteLine(string.Join(", ", firstResult));
            var secondResult =
                from num in nums
                where num % 7 == 0 && num % 3 == 0
                select num;
            Console.WriteLine("Result using LINQ:");
            Console.WriteLine(string.Join(", ", secondResult));
        }
    }
}
