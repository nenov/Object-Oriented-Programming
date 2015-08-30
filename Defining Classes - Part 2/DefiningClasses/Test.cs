using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    [Version("v. 2.10")]

    class Test
    {
        static void Main()
        {
            Console.WriteLine("First to test the paths:");
            Point3D a = new Point3D(2, -5, 3.5);
            Point3D b = new Point3D(-2, 25, 4.8);
            Console.WriteLine("Creating 2 point and print them:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("Here is the static start: " + Point3D.PrintZero());
            Console.WriteLine("The distance between these two points is: " + StatisClass.Distance(a, b));
            Console.WriteLine("Read 4 points from txt and displaying them:");
            Path myPath = new Path(PathStorage.LoadPath());
            Console.WriteLine(myPath[0].ToString());
            Console.WriteLine(myPath[1].ToString());
            Console.WriteLine(myPath[2].ToString());
            Console.WriteLine(myPath[3].ToString());
            Console.WriteLine("And now save them to output.txt");
            PathStorage.SavePath(myPath);
            Console.WriteLine();
            Console.WriteLine("Now to test the Generic list. Create new list with size 2 and add two itens");
            GenericList<int> list = new GenericList<int>(2);
            list.Add(85);
            list.Add(12);
            Console.WriteLine(list);
            Console.WriteLine("Add one more item and let the list expand:");
            list.Add(-5);
            Console.WriteLine(list);
            Console.WriteLine("Print element at index 2: " + list[2]);
            list.RemoveAt(1);
            Console.WriteLine("Remove elemect at index 1: " + list);
            list.InsertAt(1, 99);
            Console.WriteLine("Insert elemect at index 1: " + list);
            Console.WriteLine("99 is which what index in the list: " + list.IndexOf(99));
            Console.WriteLine("Smallest element in the list is: " + list.Min());
            Console.WriteLine("Biggest element in the list is: " + list.Max());

            list.Clear();
            Console.WriteLine("Clearing the list." + list);

            Console.WriteLine("Now to test the matrixes: creating two matrixes: { 4, 3 }, { 2, 1 } and { 2, 1 }, { 4, 3 }, and them executing the 3 operations:");
            Matrix<int> firstMatrix = new Matrix<int>(2, 2);
            Matrix<int> secondMatrix = new Matrix<int>(2, 2);
            int[,] sMatrix = new int[,] { { 4, 3 }, { 2, 1 } };
            int[,] cMatrix = new int[,] { { 2, 1 }, { 4, 3 } };
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    firstMatrix[row, col] = sMatrix[row, col];
                    secondMatrix[row, col] = cMatrix[row, col];
                }
            }
            Console.WriteLine("Addition:");
            Matrix<int> newOne = firstMatrix + secondMatrix;
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(newOne[row,col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Subtraction:");
            newOne = firstMatrix - secondMatrix;
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(newOne[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Multiplication:");
            newOne = firstMatrix * secondMatrix;
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(newOne[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Atributes:");
            Type type = typeof(Test);
            object[] attr = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attr)
            {
                Console.WriteLine(item.Version);
            }
        }

    }
}