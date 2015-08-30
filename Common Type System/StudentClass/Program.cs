using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(
                   "Miro",
                   "Peshev",
                   "Goshov",
                   "5524887456",
                   "blv Vitosha 243",
                   "0896565689",
                   "theBoss@abv.bg",
                   "Math and Stuff",
                   Speciality.Math,
                   University.IIT,
                   Faculty.Math);
            Console.WriteLine("to string:" + student.ToString());
            var otherStudent = student.Clone();
            Console.WriteLine("Cloned student to string: " + otherStudent.ToString());
            Console.WriteLine(student == otherStudent);
            Console.WriteLine(student.Equals(student));
            Console.WriteLine(student.Equals(otherStudent));
            Console.WriteLine(student != otherStudent);
        }
    }
}
