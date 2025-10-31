using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4.Sealed
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public sealed override string ToString()
        {
            return base.ToString();
        }

        public sealed override void MyFun()
        {
            base.MyFun();
        }
    }
}
