using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public  class Kitten : Cat, ISound
    {
        public Kitten(string name, double age)
            : base(name, age, 'F')
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kitten makes sound");
        }
    }
}
