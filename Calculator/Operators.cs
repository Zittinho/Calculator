using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Operators
    {
        public static int Plus (int n1, int n2) 
        {
            return n1 + n2; 
        }
        public static double Plus(double n1, double n2)
        {
            return n1 + n2;
        }
        public static int Minus(int n1, int n2)
        {
            return n1 - n2;
        }
        public static double Minus(double n1, double n2)
        {
            return n1 - n2;
        }
        public static int Mult(int n1, int n2)
        {
            return n1 * n2;
        }
        public static double Mult(double n1, double n2)
        {
            return n1 * n2;
        }
        public static int Del(int n1, int n2)
        {
            return n1 / n2;
        }
        public static double Del (double n1, double n2)
        {
            return n1 / n2;
        }
        public static Double Sqrt(int n1)
        {
            return Math.Sqrt(n1);
        }
        public static double Sqrt(double n1)
        {
            return Math.Sqrt(n1);
        }
        public static int Percent(int n1, int n2)
        {
            return n1 % n2;
        }
        public static double Percent(double n1, double n2)
        {
            return n1 % n2;
        }
    }
}
