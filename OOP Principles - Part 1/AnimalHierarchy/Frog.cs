using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public  class Frog : Animal, ISound
    {
        public Frog(string name, double age, char sex)
            : base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Frod makes sound");
        }
    }
}
