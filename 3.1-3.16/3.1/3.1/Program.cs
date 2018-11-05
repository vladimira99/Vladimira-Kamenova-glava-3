using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 23;
            bool even = number % 2 == 0 ? true : false;
            Console.WriteLine("{0} is even? {1}", number, even);
        }
    }
}
