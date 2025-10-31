using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Sealed
{
    internal class TypeA
    {
        public virtual int  X { get; set; }
        public virtual void MyFun() 
        {
            Console.WriteLine(" My Fun From TypeA");
        }
    }
}
