using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice

namespace DefiningClasses
{
    public class Path
    {
        private List<Point3D> paths = new List<Point3D>();

        public Path()
        {
            this.paths = new List<Point3D>();
        }
        public Path(List<Point3D> newpaths)
        {
            this.paths= newpaths;
        }
        public int Count
        {
            get
            {
                return this.paths.Count;
            }
        }
        public Point3D this[int index]
        {
            get
            {
                return this.paths[index];
            }
            set
            {
                this.paths[index] = value;
            }
        }
    }
    public static class PathStorage
    {
        public static void SavePath(Path lines)
        {
            StreamWriter stream = new StreamWriter(@"..\..\output.txt");
            stream.Flush();
            stream.Close();
            for (int i = 0; i < lines.Count; i++)
            {
                string line = string.Format("{0}|{1}|{2} \n", lines[i].X,lines[i].Y,lines[i].Z);
                File.AppendAllText(@"..\..\output.txt", line + Environment.NewLine);
            }
        }
        public static List<Point3D> LoadPath()
        {
            StreamReader reader = new StreamReader(@"..\..\input.txt");
            List<Point3D> paths = new List<Point3D>();
            using (reader)
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data =line.Split('|');
                    Point3D temp = new Point3D(double.Parse(data[0]), double.Parse(data[1]),double.Parse(data[2]));
                    paths.Add(temp);
                }
            }
            return paths;
        }
    }
}
