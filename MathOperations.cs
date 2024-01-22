using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_MethodOverloading_Hongfei
{
    public class MathOperations
    {
        //Add method 
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        //Method Overloadind, creating multiple methods with same method name
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Subtract(double a, double b, double c)
        {
            return a - b - c;
        }

        public int Multiply(int a , int b) { return a*b; }
        public double Multiply(double a, double b) { return a*b; }
        public double Multiply(double a, double b, double c) { return a*b*c; }

        public int Divide(int a, int b)
        {
            //To check if int b is zero
            if (b !=0)
            {
                return a/b;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }

        public double Divide(double a, double b)
        {
            if (b !=0)
            {
                return a/b;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }






    }
}
