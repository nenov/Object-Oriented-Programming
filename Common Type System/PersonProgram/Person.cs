using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonProgram
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        private int? age;

        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, byte age)
            : this(name)
        {
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Name: " + this.Name);

            if (this.Age == null)
            {
                result.AppendLine("Age: Not specified");
            }
            else
            {
                result.AppendLine("Age: " + this.Age);
            }

            return result.ToString();
        }
    }
}
