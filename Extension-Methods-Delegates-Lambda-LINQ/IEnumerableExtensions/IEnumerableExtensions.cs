using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    //Implement a set of extension methods for IEnumerable<T> 
    //that implement the following group functions: sum, product, min, max, average.
    public static class Extensions
    {
        public static T sum<T> (this IEnumerable<T> temp)
        {
            T result = (dynamic)0;
            foreach( T item in temp)
            {
                result += (dynamic)item;
            }
            return result;
        }
        public static T product<T>(this IEnumerable<T> temp)
        {
            T result = (dynamic)1;
            foreach (T item in temp)
            {
                result *= (dynamic)item;
            }
            return result;
        }
        public static T min<T>(this IEnumerable<T> temp)
        {
            return temp.Min();
        }
        public static T max<T>(this IEnumerable<T> temp)
        {
            return temp.Max();
        }
        public static T average<T>(this IEnumerable<T> temp)
        {
            return (dynamic)temp.sum() / temp.Count();
        }
    }
    class IEnumerableExtensions
    {
       
        static void Main(string[] args)
        {
            IEnumerable<double> numbers = new double[] { 5.5, -536.5, 52 , 0};
            Console.WriteLine("The input is as follows:5.5, -536.5, 52 , 0" );
            Console.WriteLine("Sum: {0}", numbers.sum());
            Console.WriteLine("Product: {0}", numbers.product());
            Console.WriteLine("Min: {0}", numbers.min());
            Console.WriteLine("Max: {0}", numbers.max());
            Console.WriteLine("Average: {0}", numbers.average());
        }
    }
}
