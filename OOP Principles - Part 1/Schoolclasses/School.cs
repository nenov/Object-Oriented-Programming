using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolclasses
{
    class School
    {
        List<Class> classes;

        public School(Class[] classes)
        {
            this.Classes = new List<Class>();
            this.Classes.AddRange(classes);
        }

        public List<Class> Classes
        {
            get { return this.classes; }
            set { this.classes = value; }
        }

    }
}
