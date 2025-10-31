using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }


        // Operator Overloading 
        // + 
        // Must BE : Public - Static

        // Binary Operator : + - * / %

        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = Left?.Real ?? 0 + Right?.Real ?? 0,
                Imag = Left?.Imag ?? 0 + Right?.Imag ?? 0

            };
        }

        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = Left?.Real ?? 0 - Right?.Real ?? 0,
                Imag = Left?.Imag ?? 0 - Right?.Imag ?? 0

            };
        }

        // Operator Overloading 
        // ++ --
        // Function  : Public - Static
        public static Complex operator ++(Complex complex)
        {

            if (complex is not null)
            {
                complex.Real++;
                return complex;
            }

            return new Complex();
        }
        public static Complex operator --(Complex complex)
        {

            if (complex is not null)
            {
                complex.Real--;
                return complex;
            }

            return new Complex();
        }



        // Comparsio Operation Binary : < > = ! ==
        // Must be Boolen 

        public static Boolean operator >(Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
                return Left.Imag > Right.Imag;
            return Left.Real > Right.Real;
        }

        public static Boolean operator <(Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
                return Left.Imag < Right.Imag;
            return Left.Real < Right.Real;
        }

        // User-Defind Casting Operator  
        // Complex  ---> String
        // Function  : Public - Static 

        // Implicit - Explicit 
        public static explicit operator string(Complex Complex)
            {
            return Complex.ToString();
            }

        public static explicit operator int (Complex Complex)
        {
            return 1;
        }

        public override string ToString()
        {
            return $"{Real} + {Imag} i ";
        }
    }
}
