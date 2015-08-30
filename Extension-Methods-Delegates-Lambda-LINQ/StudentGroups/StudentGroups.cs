using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    class StudentGroups
    {
        static void Main(string[] args)
        {
            List<Student> Class = new List<Student>
                                    {
                                      new Student("Celine","Dion","1111061","05388852558","Dion@gmail.com", new List<double>{5.5,2,4.2},5),
                                      new Student("Michael","Jackson","1111051","00159855524","Jackson@gmail.com", new List<double>{5.5,6,4.2},2),
                                      new Student("Bruno","Mars","1111051","0224112544","Bruno@gmail.com", new List<double>{6,6,2,2},2),
                                      new Student("Calvin","Harris","1111061","0532341125","Calvin@abv.bg", new List<double>{5.5,3,4.2},5)
                                  };
            Console.WriteLine("All of the students:");
            PrintStudents(Class.ToArray<Student>());

            var selected =
                from stud in Class
                where stud.GroupNumber == 2
                orderby stud.FirstName
                select stud;
            Console.WriteLine("Students from group 2 ordered by firstname using LINQ:");
            PrintStudents(selected.ToArray<Student>());

            Console.WriteLine("Students from group 2 ordered by firstname using Extention methods:");
            var selected2 = Class.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
            PrintStudents(selected2.ToArray<Student>());

            Console.WriteLine("Students that have email in abv.bg");
            var selectedEMails =
                from stud in Class
                where stud.Email.EndsWith("abv.bg")
                select stud;
            PrintStudents(selectedEMails.ToArray<Student>());

            Console.WriteLine("Students with phones in Sofia");
            var selectedEPhones =
                from stud in Class
                where stud.Tel.StartsWith("02")
                select stud;
            PrintStudents(selectedEPhones.ToArray<Student>());

            var anonymousClass = 
                from stud in Class
                where stud.Marks.Contains(6)
                select new
                        {
                            Fullname = stud.FirstName + " " + stud.LastName,
                            Marks = stud.Marks
                        };
            Console.WriteLine("Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.");
            foreach (var a in anonymousClass)
            {
                Console.WriteLine("Fullname: " + a.Fullname + ", Marks:" + string.Join(", ", a.Marks));
            }

            Console.WriteLine("\nWrite down a similar program that extracts the students with exactly two marks 2");
            var anonymousClass2 = Class.Where(st => st.Marks.Count(p => p == 2) == 2).
                Select(x => new
                {
                    Fullname = x.FirstName + " " + x.LastName,
                    Marks = x.Marks
                });
            foreach (var a in anonymousClass2)
            {
                Console.WriteLine("Fullname: " + a.Fullname + ", Marks:" + string.Join(", ", a.Marks));
            }
            Console.WriteLine("\nExtract all Marks of the students that enrolled in 2006");

            var marks2006 =
                from stud in Class
                where stud.Fn[4]=='0' && stud.Fn[5]=='6'
                select new
                {
                    Marks = stud.Marks
                };
            foreach (var a in marks2006)
            {
                Console.WriteLine("Marks:" + string.Join(", ", a.Marks));
            }

            Console.WriteLine("\nGrouped by GroupNumber");
            var Groups =
                from stud in Class
                group stud by stud.GroupNumber into newGroup
                orderby newGroup.Key
                select newGroup;
            foreach (var nameGroup in Groups)
            {
                Console.WriteLine("Group: {0}", nameGroup.Key);
                foreach (var student in nameGroup)
                {
                    Console.WriteLine("\t{0}, {1}", student.LastName, student.FirstName);
                }
            }
            Console.WriteLine();
            Class.ExtractGroups();
        }
        public static void PrintStudents(Student[] students)
        {
            foreach (var st in students)
            {
                Console.WriteLine(String.Format("Names: {0} Email: {1} FN: {2} Tel: {3} Group: {4}", (
                st.FirstName + " " + st.LastName),
                st.Email,
                st.Fn,
                st.Tel,
                st.GroupNumber));
            }
            Console.WriteLine("\n");
        }
    }

}
