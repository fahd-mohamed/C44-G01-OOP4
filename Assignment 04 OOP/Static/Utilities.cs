using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Static
{
    internal class Utilities
    {

        public int X { get; set; }
        public int Y { get; set; }

        private static double pi = 3.14;



        // Static Methods : Class Member methods
        public static double CmToInch(double cm) 

        {
            return cm / 2.54; 
        }
        // 3.14
        public double PI
            { get
                {
                return pi;
                }
                
             
            }
    }

}
