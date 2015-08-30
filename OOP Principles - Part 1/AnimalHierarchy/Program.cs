using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    //Create arrays of different kinds of animals and calculate 
    //the average age of each kind of animal using a static method (you may use LINQ).
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = new Dog[] 
            {
                new Dog("Sharo",5,'F'),
                new Dog("Mimi",3,'M'),
                new Dog("Becks",3.4,'F')
            };
            Frog[] frogs = new Frog[]
            {
                new Frog("BiBI", 13, 'F'),
                new Frog("Katya", 15, 'M'),
                new Frog("Kolio", 5, 'M'),
                new Frog("Niki", 10, 'M')
            };

            Cat[] cats = new Cat[] 
            {
                new Cat("Ass", 3, 'F'),
                new Cat("Hand", 5, 'F'),
                new Cat("Head", 1, 'F'),
                new Cat("Leg", 7, 'M')
            };

            Kitten[] kittens = new Kitten[]
            {
                new Kitten("Malcho", 1),
                new Kitten("Palcho", 2),
                new Kitten("Shalco", 1)
            
            };

            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat("Gosho", 5),
                new Tomcat("Mitko", 4),
                new Tomcat("Pesho", 8)
            };
            Console.WriteLine("Average age of the dogs: {0:F2}", Animal.AverageAge(dogs));
            Console.WriteLine("Average age of the frogs: {0:F2}",Animal.AverageAge(frogs));
            Console.WriteLine("Average age of the cats: {0:F2}",Animal.AverageAge(cats));
            Console.WriteLine("Average age of the kittens: {0:F2}", Animal.AverageAge(kittens));
            Console.WriteLine("Average age of the tomcats: {0:F2}",Animal.AverageAge(tomcats));
        }
    }
}
