using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        private string name;
        private double age;
        private char sex;
        public Animal(string nam,double age,char se)
        {
            this.Name = nam;
            this.Age = age;
            this.Sex = se;
        }
    
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public double Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }

        public char Sex
        {
            get
            {
                return sex;
            }
            set
            {
                this.sex = value;
            }
        }

        public abstract void ProduceSound();

        public static double AverageAge(Animal[] arr)
        {
            return arr.Average(x => x.Age);
        }
    }
}
