using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Abstract
{
    // Concert Class Fully Implemented Class
    internal class Rectangle : shape /*Implement And Inhert From Shap*/
    {

        public override double GetArea()
        {
            return Dim01 * Dim02;
        }

        public override double Dim03
        {
            get
            {
                return (Dim01 + Dim02)*2;

            }
        }

    }
}
