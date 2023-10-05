using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OppsContd
{
    internal class ArrayOfClass
    {
        static void Main(string[] args)
        {
            Dept[] lp = new Dept[2];//array object
            lp[0] = new Dept();
            lp[0].RAM = 1;
            lp[0].HD = 21;
            lp[0].Processor = "intel13";
            lp[0].Fingersensor = true;
            lp[0].Price = 44444440;

            lp[1] = new Dept();
            lp[1].RAM = 1;
            lp[1].HD = 21;
            lp[1].Processor = "intel15";
            lp[1].Fingersensor = true;
            lp[1].Price = 500;

            Console.WriteLine(lp[0].HD);
            Console.WriteLine(lp[0].RAM);
            Console.WriteLine(lp[0].Price);
            Console.WriteLine(lp[0].Processor);
            Console.WriteLine(lp[0].Fingersensor);

            Console.WriteLine("=======================================");

            Console.WriteLine(lp[1].HD);
            Console.WriteLine(lp[1].RAM);
            Console.WriteLine(lp[1].Price);
            Console.WriteLine(lp[1].Processor);
            Console.WriteLine(lp[1].Fingersensor);
            Console.ReadLine();
        }
       
    }
}
