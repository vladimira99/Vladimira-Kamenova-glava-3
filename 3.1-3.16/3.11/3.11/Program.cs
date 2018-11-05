using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35, p = 6, i = 1, mask = i << p;
            Console.WriteLine((n & mask) != 0 ? "Third bit is 1" : "Third bit is 0");
        }
    }
}
