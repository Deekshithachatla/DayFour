using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsContd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dept lp = new Dept();
            lp.RAM = 8;
            lp.HD = 121;
            lp.Processor = "intel13";
            lp.Fingersensor = true;
            lp.Price= 123;
            Console.WriteLine(lp.RAM);
            Console.WriteLine(lp.HD);
            Console.WriteLine(lp.Processor);
            Console.WriteLine(lp.Fingersensor);
            Console.WriteLine(lp.Price);
            Console.WriteLine("============================");

            Dept lp2 = new Dept();
            lp2.RAM = 16;
            lp2.HD = 456;
            lp2.Processor = "intel15";
            lp2.Fingersensor = false;
            lp2.Price = 3456;
            Console.WriteLine(lp2.RAM);
            Console.WriteLine(lp2.HD);
            Console.WriteLine(lp2.Processor);
            Console.WriteLine(lp2.Fingersensor);
            Console.WriteLine(lp2.Price);
            Console.ReadLine();
        }
    }
}
