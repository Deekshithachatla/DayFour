using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsContd
{
    internal class Employee
    {
        //constructor--- method with same name as that of class without any return type
        //defalut constructor
        public Employee() { }

        int _empid;
        string _ename;
        string _loc;

        //paramererised constructor

        public Employee(int empid, string name)
        {
            _empid = empid;
            _ename = name;
           

        }
        //paramererised constructor

        public Employee(int empid,string name,string loc) 
        {
            _empid = empid;
            _ename = name;
            _loc = loc;

        }

        //read only properties

        public string Details
        {
            get
            {
               string d= EmpId.ToString()+_ename+_loc;
                return d;
            }
        }
        public int EmpId
        { get { return _empid; } }
        public string EName
        { get { return _ename; } }

        public string Loc
        { get { return _loc; } }

    }
}
