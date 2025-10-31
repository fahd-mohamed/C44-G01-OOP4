namespace First_Project
{
    internal class Program
    {
        static void Main()
        {
            #region 3.Run All Required Constructors to Produce this output:
            //Duration D1 = new Duration(1, 10, 15);
            //Output: Hours: 1, Minutes :10, Seconds :15

            //Duration D1 = new Duration(3600);
            //Output: Hours: 1, Minutes :0, Seconds :0

            //Duration D1 = new Duration(7800);
            //Output: Hours: 2, Minutes :10, Seconds :0

            //Duration D1 = new Duration(666);
            ///Output: Minutes :11, Seconds :6

            //Console.WriteLine(D1);

            #endregion

            #region 4.Implement All required Operators overloading’s to enable this Code:
            Duration D1 = new Duration(1, 10, 15);
            //Hours: 1, Minutes :10, Seconds :15

            Duration D2 = new Duration(3600);
            //Hours: 1, Minutes :0, Seconds :0

            Duration D3 = new Duration(7800);
            //Hours: 2, Minutes :10, Seconds :0
            #region D3=D1+D2

            //D3 = D1 + D2;
            //Console.WriteLine(D3);
            //2h , 10 m 15 S
            #endregion

            #region D3 = D1 + 7800
            //D3 = D1 + 7800;
            //Console.WriteLine(D3);
            //3h , 20 m 15s
            #endregion

            #region D3=666+D3
            //D3 = 666 + D3;
            //Console.WriteLine(D3);
            //2h , 21m , 6s 
            #endregion

            #region D3 = ++D1 (Increase One Minute)

            //D3 = ++D1;
            //Console.WriteLine(D3);
            #endregion

            #region D3 = --D2 (Decrease One Minute)
            //D3 = --D2;
            //Console.WriteLine(D3);
            #endregion

            #region If(D1>D2) 
            //if (D1 > D2)
            //{
            //    Console.WriteLine("D1>D2");
            //}
            //else
            //{
            //    Console.WriteLine("D1<D2");
            //}
            #endregion

            #region D1= D1 - D2
            //D1 = D1 - D2;
            //Console.WriteLine(D1);
            #endregion

            #region If(D1<=D2)
            //if (D1 <= D2)
            //{
            //    Console.WriteLine("D1 <= D2");
            //}
            //else
            //{
            //    Console.WriteLine("D1 >= D2");

            //}
            #endregion

            #region If(D1)

            // Duration D1 = new Duration();
            //if (D1)
            //    Console.WriteLine(D1);
            //else
            //    Console.WriteLine(new Duration());
            #endregion

            #region DateTime Obj = (DateTime)D1
            DateTime obj = (DateTime)D1;
            Console.WriteLine(obj);

            #endregion

            #endregion
        }
    }
}
