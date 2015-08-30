using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person("myName", 34);
            Console.WriteLine(me);
            Person me2 = new Person("myotherName");
            Console.WriteLine(me2);
        }
    }
}
