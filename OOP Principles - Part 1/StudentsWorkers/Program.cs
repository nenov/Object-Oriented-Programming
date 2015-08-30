using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    class Program
    {
        //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
        static void Main(string[] args)
        {
            List<Student> studs = new List<Student>
            {
                new Student("Celine","Dion",6),
                new Student("Bruno","Mars",5),
                new Student("Calvin","Harris",4),
                new Student("Ellie","Gouldwin",3),
                new Student("Celine2","Dion2",4),
                new Student("Muse","TheGreat",5),
                new Student("Marian","Hill",3),
                new Student("Ivan","Ivanov",4),
                new Student("Georgi","Georgoev",4),
                new Student("Celin3e","Dio3n",2)
            };
            var sortedByGrade = studs.OrderBy(x => x.Grade);

            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            List<Worker> works = new List<Worker>
            {
                new Worker("Marin","Marinov",500,54),
                new Worker("Tsvetaan","Tsvetanov",200,23),
                new Worker("Pesho","Peshov",1000,23),
                new Worker("Dimitar","Dimitrov", 3452, 98),
                new Worker("Gabriel","Gabrielov", 444,67),
                new Worker("Ivaylo","Peshev", 600,65),
                new Worker("Hristo","Krystev", 734,34),
                new Worker("Artur","What",555,23),
                new Worker("Bibi","Tired", 456,54),
                new Worker("Last","Worker", 1,2)
            };
            var sortBySalary = works.OrderByDescending(x => x.MoneyPerHour());
            var concatGroups = sortedByGrade
                .Concat<Human>(sortBySalary)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);

            Console.WriteLine("Both groups concatenated and sorted by names");
            foreach (var person in concatGroups)
            {
                Console.WriteLine("{0,-9} {1, -10}", person.FirstName, person.LastName);
            }
        }
    }
}
