using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolclasses
{
    class Student:Person
    {
        int classNumber;

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }
        
        public Student(string firstName, string lastName, int classNumber)
            : base(firstName, lastName)
        {
            this.ClassNumber = classNumber;
        }
    }
}
