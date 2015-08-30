using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    class Worker:Human
    {
        double weekSalary;
        double workHoursPerDay;

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }
        public double MoneyPerHour()
        {
            return this.WeekSalary / (5d * WorkHoursPerDay);
        }

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
    }
}
