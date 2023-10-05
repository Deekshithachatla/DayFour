using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsContd
{
    internal class Dept
    {
        //variable -backing variable
        int?_ram;

        //property /smart method
         //read and write properies
        public int? RAM {
            set
            {
               _ram = value;
            }
            get
            {
                return _ram;
            }
        }

       DateTime _mgfDt;

        public DateTime MgfDt
        {
            set { 
                _mgfDt= value;
                }
            get
            {
                return _mgfDt;
            }
        }


        //propfull then tab tab
        private bool _fingersensor;

        public bool Fingersensor
        {
            get { return _fingersensor; }
            set { _fingersensor = value; }
        }

        private Nullable<decimal> _price;

        public Nullable<decimal> Price
        {
            get
            {
                if (_price == 0)
                {
                  return  _price = 0;

                }
                else
                {
                    return _price;
                }
            }

            set {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("not a valid value");
                }
            }
        }




        int _hd;
        public int HD {
            set
            {
                if (value>0 )
                {
                    _hd = value;
                }
                else
                {
                    Console.WriteLine("not a valid value");
                }
              
            } 
            get 
            { 
                return _hd; 
            } 
        }

        string _processor;

        public string Processor {
            set {
                if (value != null)
                {
                    _processor = value;
                }
                else
                {
                    Console.WriteLine("not a valid value");
                }
               
            } 
            get
            { 
                return _processor; 
            }
        }  

    }
}
