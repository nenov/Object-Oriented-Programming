using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    //Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    public static class Extensions
    {
        public static void ExtractGroups(this IEnumerable<Student> studs)
        {
            Console.WriteLine("\nGrouped by GroupNumber using extensions");
            var Groups =
                from stud in studs
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
        }
    }
    public class Student
    {
        string firstName;
        string lastName;
        string fn;
        string tel;
        string email;
        List<double> marks;
        int groupNumber;
        public Student(string firstName, string lastName, string fn, string tel, string email, List<double> marks, int groupnum)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Fn = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupnum;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
            }
        }

        public string Fn
        {
            get { return fn; }
            set
            {

                this.fn = value;
            }
        }
        public string Tel
        {
            get { return tel; }
            set { this.tel = value; }
        }
        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }
        public List<double> Marks
        {
            get { return marks; }
            set { this.marks = value; }
        }
        public int GroupNumber
        {
            get { return groupNumber; }
            set { this.groupNumber = value; }
        }
        
    }
}
