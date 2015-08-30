using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        
        public Dog(string name, double age, char sex)
            : base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Dog makes sound");
        }
    }
}
