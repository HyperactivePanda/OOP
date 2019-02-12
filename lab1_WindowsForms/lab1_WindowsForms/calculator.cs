using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_WindowsForms
{
    class calculator
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Div(int num1, int num2)
        {
                return num1 / num2;
        }

        public static Double Div(Double num1, Double num2) 
        {
            if (num2 == 0)
                throw new System.DivideByZeroException();
            else
            return num1 / num2;
        }

        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }

        public static Double Equally(Double num1, Double num2)
        {
            return num1 = num2;
        }

        public static int Div2(int num1, int num2)
        {
            return num1 % num2;
        }
    }
}
