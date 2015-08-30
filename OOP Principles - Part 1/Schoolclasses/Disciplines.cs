using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolclasses
{
    class Disciplines
    {
        string name;
        int numLectures;
        int numExercises;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int NumLectures
        {
            get
            {
                return this.numLectures;
            }
            set
            {
                this.numLectures = value;
            }
        }
        public int NumExercises
        {
            get
            {
                return this.numExercises;
            }
            set
            {
                this.numExercises = value;
            }
        }

        public Disciplines(string name, int exerciseNumber, int lectureNumber)
        {
            this.Name = name;
            this.NumLectures = exerciseNumber;
            this.NumExercises = lectureNumber;
        }
        public List<string> Comment { get; set; }

        public void AddComment(string comment)
        {
            this.Comment.Add(comment);
        }

    }
}
