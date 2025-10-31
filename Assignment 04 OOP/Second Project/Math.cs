using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    internal class Math
    {
        #region 1.Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters. Call each method in Main ().

        //public int Add(int num1 , int num2)
        //{
        //    return num1 + num2;
        //}
        //public int Subtract(int num1 , int num2)
        //{
        //    return num1 - num2;
        //}
        //public int Multiply(int num1 , int num2)
        //{
        //    return num1 * num2;
        //}
        //public int Divide(int num1 , int num2)
        //{
        //    if (num2 == 0)
        //        return 0;
        //    return num1 / num2;
        //}





        #endregion
        #region 2. Modify the program so that you do not have to create an instance of class to call the four methods.
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            if (num2 == 0)
                return 0;
            return num1 / num2;
        }



        #endregion


    }
}
