using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolclasses
{
    class Teacher:Person
    {
        private List<Disciplines> teachDisciplines;

        public List<Disciplines> TeachDisciplines
        {
            get
            {
                return new List<Disciplines>(this.teachDisciplines);
            }
        }
        public Teacher(string firstName, string lastName, params Disciplines[] disciplines)
            : base(firstName, lastName)
        {
            this.teachDisciplines = new List<Disciplines>();
            this.teachDisciplines.AddRange(disciplines);
        }
    }
}
