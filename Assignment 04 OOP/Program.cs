namespace Assignment_04_OOP
{
    internal class Program
    {
        static void Main()
        {

            #region Abstraction
            //// 4. Abstraction : 
            //// abstract : C# Keyword [Class - methods - properties]
            //// abstract Class
            //// abstract Methods
            //// abstract Properties


            ////shape shape = new shape();
            //// NOT :  Can not Create Object From Abstract Class


            //Rectangle rectangle = new Rectangle() { Dim01 = 6 , Dim02 = 7 };

            ////rectangle.Dim03 = 10;
            //Console.WriteLine(rectangle.Dim03);
            //Console.WriteLine(rectangle.GetArea());
            //rectangle.Print();

            //Square square = new Square();
            //square.Dim02 = 6;
            //Console.WriteLine(square.Dim03);
            //square.Print(); 
            #endregion

            #region Interface Vs Abstraction

            #endregion

            #region Operator Overloading
            //// Operator Overloading 

            //// + - * % < > = || && !

            //// +

            ////int X = 1 + 2;
            ////string Y = "Hello" + "World";

            //// Complex Number : Real + Imag

            //// 4 + 3 i 
            //// 4 + 3 ت

            //Complex C01 = new Complex() { Imag=4 , Real = 5};
            //Complex C02 = new Complex() { Imag = 3, Real = 2 };


            ////Console.WriteLine(C01);
            ////Console.WriteLine(C02);

            ////Complex C03 = C01 + C02;

            ////Console.WriteLine(C03);


            //// ++ --
            //// Unary OPerator 

            ////int X = 10;
            ////X++;
            ////Console.WriteLine(X);

            ////C01++;
            ////Console.WriteLine(C01);

            //if (C01>C02)
            //{
            //    Console.WriteLine("C01 Greater Then C02");
            //}

            //else 
            //{
            //    Console.WriteLine("C01 Less Then C02");
            //} 
            #endregion

            #region User_Defined Casting Operator & Manual Mapping 

            ////double X = 10;

            ////int Y = (int) X;
            //// (int) CAsting Operator

            //Complex C01 = new Complex() { Real = 3 , Imag = 4 };

            ////string s = (string) C01;
            ////// (string) : Convert Complex Number to String 

            ////// operator overloading
            ////// User-Defind Casting Operator  
            ////Console.WriteLine(s);

            ////int X = C01;
            ////Console.WriteLine(X);

            ////int x = (int)new Complex() { Real = 3 ,Imag = 4 };

            //// Mapping : Convert From DataType To DataType 


            //// Code First
            //// DB First

            //// User [ID , Name , Email , Password , Phone ,CardNumber , Expeerdate]

            //// UserViewModel 
            ////UserDto
            ////[Name , Email , Phone ]

            //User user = new User(); // From DB 

            //// Mannual mapping   
            //UserDto userDto = new UserDto()
            //{
            //    Email = user.Email,
            //    Name = user.Name,
            //    phone = user.phone
            //};

            //// Castion Mapping

            //// Automapper : Mapping Automatic 
            #endregion

            #region Static

            //// Static : C# Keyword [Class - Methods - Property - constructor - attributes]
            //// Static Class
            //// Static Methods
            //// Static Property
            //// Static constructor
            //// Static attributes

            //Utilities utilities01 = new Utilities();
            //Utilities utilities02 = new Utilities();
            //Utilities utilities03 = new Utilities();


            ////Console.WriteLine(utilities01.CmToInch(5));
            ////Console.WriteLine(utilities02.CmToInch(5));
            ////Console.WriteLine(utilities03.CmToInch(5));


            //Console.WriteLine(Utilities.CmToInch(5));
            //Console.WriteLine(Utilities.CmToInch(5));
            //Console.WriteLine(Utilities.CmToInch(5));

            //Console.WriteLine(utilities01.PI); 
            #endregion

            #region Sealed

            //// Sealed : C# Keyword [Class - Methos Proparty]
            ////  
            #endregion

            #region Partial

            //// Partial 

            //Employee employee = new Employee(); 
            //employee.ID 
            #endregion
        }
    }
}
