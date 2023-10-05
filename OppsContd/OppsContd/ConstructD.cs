using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsContd
{
    internal class ConstructD
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();//0 or null
            Employee emp1 = new Employee(12, "rama", "vizag");
            Employee emp2 = new Employee(12, "suma");
            Employee emp3 = new Employee(empid: 21, loc: "palem", name: "giri");
            Console.WriteLine(emp1.EmpId);
            Console.WriteLine(emp1.EName);
            Console.WriteLine(emp1.Loc);
            Console.Write(emp1.Details);
            Console.ReadLine();
        }
    }
}
