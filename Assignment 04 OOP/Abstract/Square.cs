using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Abstract
{
    internal class Square : shape
    {
        public override double Dim03
        {
            get
            {
                return Dim02 * 4;
            }
        }
        public override double GetArea()
        {
            return Dim01 * Dim02;
        }
    }
}
