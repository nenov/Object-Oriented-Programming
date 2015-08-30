using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    //Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
    //Use LINQ query operators.

    class FirstBeforeLast
    {
        public static void FindStudents(Student[] array)
        {
            var group =
                from stud in array
                where stud.FirstName[0] < stud.LastName[0]
                select stud;
            foreach( var stud in group)
            {
                Console.WriteLine(stud.FirstName + " " + stud.LastName);
            }
        }
        public static void AgeRange(Student[] array)
        {
            var group =
                from stud in array
                where stud.Age>=18 && stud.Age<=24
                select stud;
            foreach (var stud in group)
            {
                Console.WriteLine(stud.FirstName + " " + stud.LastName);
            }
        }
       
        static void Main(string[] args)
        {
            Student[] groups = new Student[]
                {
                    new Student("Celine", "Dion",14),
                    new Student("Celine", "Youknowwho",22),
                    new Student("Who", "Doctor",29)
                };
            Console.WriteLine("The entered names are Celine Dion(age 14), Celine Youknowwho(age 22), Who Doctor(age 29)");
            Console.WriteLine("Result:");
            FindStudents(groups);
            Console.WriteLine("Result for age:");
            AgeRange(groups);
            Console.WriteLine("Sorting using lambda expressions:");
            var sortedLambda =  groups.OrderByDescending(temp => temp.FirstName).ThenByDescending(temp => temp.LastName);
            foreach (var a in sortedLambda)
            {
                Console.WriteLine(a.FirstName +" " + a.LastName);
            }
            Console.WriteLine("Sorting using LINQ:");
            var sortedLINQ =
                from studs in groups
                orderby studs.FirstName descending, studs.LastName descending                
                select studs;
            foreach (var stud in sortedLINQ)
            {
                Console.WriteLine(stud.FirstName + " " + stud.LastName);
            }
        }
    }
}
