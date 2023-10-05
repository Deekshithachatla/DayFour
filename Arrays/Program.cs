using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first way of declarining an array
            int[] marks = { 10, 10, 20, 21 };
            int[] mark;
            for (int k = 0; k < 4; k++)
            {
                Console.WriteLine(marks[k]);
            }

            Console.WriteLine("==================================");

            //second way

            int[] marks2 = new int[4] { 100, 100, 200, 210 };
            int[] marks3 = new int[4];
            marks3[0] = 30;
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(marks2[j]);
            }
            Console.WriteLine("==================================");

            //third way

            Array a = Array.CreateInstance(typeof(int), 4);
            a.SetValue(10, 0);
            a.GetValue(0);
            //  object o = a.GetValue(0);
            int s = (int)a.GetValue(0);
            Console.WriteLine(s);
            Console.WriteLine("==============================");

            //one dimensional array
            int[] oneD = { 12, 1, 3, 14, 56 };
            PrintFirstValue(oneD);
            //two dimensional array
            int[,] twoD = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 11 } };

            PrintFirstValue(twoD);

            //three dimensional array
            // //first 2 means --2 rows
            ////second 2 means--2 columns
            ////thrid 3 means ---3  values

            int[,,] threeD = new int[2, 2, 3] { 
                       { { 1,2 ,5},{ 3,4,6} },
                         { { 7,8,9} ,{ 10,11,12 } }
                         };
            PrintFirstValue(threeD);

            Console.WriteLine("=================================================");

            int[] arr=new int[] {23,24,25,26}; 
            foreach(int im in arr)
            { Console.WriteLine(im); }

            Console.WriteLine("------------------------------");

            string[] names = new string[] { "dimpy", "cutie", "venky" };
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");

            object[] objects = new object[] { 1, "hima", 'a', 45.6, };
            foreach (var it in objects)
            {
                Console.WriteLine(it);
            }

            //implicitly typed variable
            //  by using var   re instantiate is not possible
            //cannot be reinstantiated by giving different types and also cannot be used 
            //as parameter type
            var p = "hello";
           // p = 5;
            var i = 78.5d;
            var d = new DateTime(2023, 04, 10);
            //the re instantiate is possible by using dynamic
            //Framework---3.5 and above
            //can be reinstantiated by giving different types and also can be used 
            //as parameter type
            //we better to use objects and dynamic to instantiate the variables 
            dynamic ms = "helllo";
            Console.WriteLine(ms);
            ms = 67;
            Console.WriteLine(ms);
            Console.WriteLine("==============================================");

            //jagged array array of arrays
            //in case if we dont know the no of elements in the each row

            int[][] ja= new int[5][];
            ja[0] = new int[5] { 1,2,3,4,5};
            ja[1] = new int[10] { 1,2,3,4,5,6,7,8,9,12};
            ja[2] = new int[2] { 1,2};

            foreach (var z in ja)
            {
                if (z != null)
                {
                    foreach (int y in z)
                    { Console.Write(y + "\t"); }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        static void PrintFirstValue(Array a)
        {
            Console.WriteLine(a.Rank);
            int[] indexers= new int[a.Rank];//by default index value 0 is considered

            Console.WriteLine($"first {a.GetValue(indexers)}");
        }
    }
}
