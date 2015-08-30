using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    //Using delegates write a class Timer that can execute certain method at each t seconds.
    public delegate void RepeatDelegate(int t);

    class Timer
    {
        static void Main()
        {
            RepeatDelegate t = delegate(int time)
            {
                while (true)
                {
                    Thread.Sleep(time);
                    Console.WriteLine("{0}", DateTime.Now);
                }
            };
            t(1000);
        }
    }
}
