using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public  class Tomcat : Cat, ISound
    {
        public Tomcat(string name, double age)
            : base(name, age, 'M')
        {
        }
    
        public override void ProduceSound()
        {
            Console.WriteLine("Tomcat makes sound");
        }
    }
}
