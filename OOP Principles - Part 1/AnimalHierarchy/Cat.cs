using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public  class Cat : Animal, ISound
    {
        public Cat(string name, double age, char sex)
            : base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cat makes sound");
        }
    }
}
