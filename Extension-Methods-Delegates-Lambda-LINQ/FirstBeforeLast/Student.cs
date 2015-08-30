using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    public class Student
    {
        string firstName;
        string lastName;
        int age;
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
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

        public int Age
        {
            get { return age; }
            set
            {

                this.age = value;
            }
        }
    }
}
