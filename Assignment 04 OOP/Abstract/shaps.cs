using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Abstract
{
    // Abstract Class : Partial Class [Not Fully Implemented Class]
    // Concert Class  : Fully Implemented Class
    internal abstract class shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }


        // Abstract Method
        public abstract double GetArea();

        // Make this method Absract


        // Abstract Proparty : Like Virtual Proparty With Out Implementation
        public abstract double Dim03 { get; }

        public void Print ()
        {
            Console.WriteLine("I am Shape");
        }

    }
}
