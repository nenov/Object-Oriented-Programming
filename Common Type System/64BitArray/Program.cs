using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 number1 = new BitArray64(7);
            BitArray64 number2 = new BitArray64(7);
            Console.WriteLine( number1);

            //Test indexer
            Console.WriteLine(number1[0]);
            number1[3] = 1;

            //Test Equals
            Console.WriteLine(number1 == number2);

            //Test "=="
            Console.WriteLine(number1.Equals(number2));

            //Test enumerator
            foreach (var item in number1)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            //Test GetHashCode
            Console.WriteLine(number1.GetHashCode());
            Console.WriteLine(number2.GetHashCode());
        }
    }
}
