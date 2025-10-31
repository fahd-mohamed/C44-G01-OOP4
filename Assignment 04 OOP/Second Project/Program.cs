namespace Second_Project
{
    internal class Program
    {
        static void Main()
        {
            #region 1.Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters. Call each method in Main ().
            //Math math = new Math();

            //Console.WriteLine(math.Add(10, 5));
            //Console.WriteLine(math.Subtract(10, 5));
            //Console.WriteLine(math.Multiply(10, 5));
            //Console.WriteLine(math.Divide(10, 5));

            #endregion
            #region 2. Modify the program so that you do not have to create an instance of class to call the four methods.
            Console.WriteLine(Math.Add(10, 5));
            Console.WriteLine(Math.Subtract(10, 5));
            Console.WriteLine(Math.Multiply(10, 5));
            Console.WriteLine(Math.Divide(10, 5));
            #endregion

        }
    }
}
