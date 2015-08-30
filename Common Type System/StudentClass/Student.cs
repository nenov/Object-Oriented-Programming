using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    public enum University
    {
        AUBG,
        IIT,
        Stanford
    }

    public enum Speciality
    {
        IT,
        History,
        Math,
    }

    public enum Faculty
    {
        Math,
        History,
        Chemistry
    }
    public class Student: ICloneable, IComparable<Student>
    {

        private string firstName;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        private string middleName;

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        private string ssn;

        public string Ssn
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }
        private string address;

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        private string phone;

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        private string email;

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        private string course;
        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        private University uni;
        
        public University Uni
        {
            get { return this.uni; }
            set { this.uni = value; }
        }
        private Speciality spec;
        public Speciality Spec
        {
            get { return this.spec; }
            set { this.spec = value; }
        }

        private Faculty fac;
        public Faculty Fac
        {
            get { return this.fac; }
            set { this.fac = value; }
        }

        public Student(string first, string middle, string last, string ssn, string adress, string phone,
            string email, string course, Speciality spciality, University university, Faculty faculty)
        {
            this.FirstName = first;
            this.MiddleName = middle;
            this.LastName = last;
            this.Ssn = ssn;
            this.Address = adress;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.Spec = spciality;
            this.Uni = university;
            this.Fac = faculty;
        }

        public override string ToString()
        {
            return "First name:" + this.FirstName +
                "\nSecond name:" + this.MiddleName +
                "\nThird name:" + this.LastName +
                "\nSSN:" + this.Ssn +
                "\nAddress:" + this.Address +
                "\nPhone number:" + this.Phone +
                "\nEmail:" + this.Email +
                "\nCourse:" + this.Course +
                "\nSpeciality:" + this.Spec +
                "\nUniversity:" + this.Uni +
                "\nFaculty:" + this.Fac;
        }

        public override bool Equals(object obj)
        {
            Student other = (Student)obj;
            if (obj == null)
            {
                return false;
            }
            return this.FirstName == other.FirstName &&
               this.MiddleName == other.MiddleName &&
               this.LastName == other.LastName &&
               this.Address == other.Address &&
               this.Course == other.Course &&
               this.Email == other.Email &&
               this.Fac == other.Fac &&
               this.Phone == other.Phone &&
               this.Ssn == other.Ssn &&
               this.Uni == other.Uni &&
               this.Spec == other.Spec;
        }

        public static bool operator ==(Student a, Student b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !a.Equals(b);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 19;
                result = result * 7 + this.Ssn.GetHashCode();
                return result;
            }
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.Address, this.Phone,
                        this.Email, this.Course, this.Spec, this.Uni, this.Fac);
        }
        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) != 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            if (this.MiddleName.CompareTo(other.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            if (this.LastName.CompareTo(other.LastName) != 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            if (this.Ssn.CompareTo(other.Ssn) != 0)
            {
                return this.Ssn.CompareTo(other.Ssn);
            }
            return 0;
        }
    }
}
