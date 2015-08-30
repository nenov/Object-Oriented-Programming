using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolclasses
{
    class Class
    {
        string textIdentifier;
        List<Teacher> teachers;
        List<Student> students;

        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            set { this.textIdentifier = value; }
        }

        public Class(string textIdent, Teacher[] teachers, Student[] students)
        {
            this.TextIdentifier = textIdent;
            this.teachers = new List<Teacher>();
            this.teachers.AddRange(teachers);
            this.students = new List<Student>();
            this.students.AddRange(students);
        }

        public List<string> Comment { get; private set; }

        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        }
    }
}
