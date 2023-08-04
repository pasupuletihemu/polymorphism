using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class MyLib
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("int int" +"   "+(a+b));
        }
        public static void Add(int a, int b,int c)
        {
            Console.WriteLine("int int int" +"   "+ (a + b+c));
        }
        public static void Add(long a, long b)
        {
            Console.WriteLine("long long" +"   "+ (a + b));
        }
        public static void Add(float a, float b)
        {
            Console.WriteLine("float float" +"    "+ (a + b));
        }
        public static void Add(string a, string b)
        {
            Console.WriteLine("string string" +"   "+ (a + b));
        }
        public static void Add(double a, double b)
        {
            Console.WriteLine("double double" +"    "+ (a + b));
        }
    }
}
