using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ClsArithmatic
    {
        int Num1, Num2, Result;

        public int PNum1
        {
            set { Num1 = value; }
         }
        public int PNum2
        {
            set { Num2 = value; }
        }
        public int PResult
        {
            get { return Result; }
        }
        public void Add()
        {
            Result = Num1 + Num2;
        }
        public void Sub()
        {
            Result = Num1 - Num2;
        }
        public void Div()
        {
            Result = Num1 / Num2;
        }
    }
}
