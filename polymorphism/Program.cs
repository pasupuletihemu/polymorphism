using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLib.Add(199, 99);
            MyLib.Add(199, 1, 99);
            MyLib.Add("hemanth","hemu");
            MyLib.Add(999.18,76.98);
            Console.WriteLine(int.MaxValue);
            MyLib.Add(2147483648, 2147483649);
            MyLib.Add(19L, 29L);
            MyLib.Add(19.9f, 26.99f);

        }
    }
}
