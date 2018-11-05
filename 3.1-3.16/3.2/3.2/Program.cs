using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 36;
            bool divisible = number % 35 == 0 ? true : false;
            Console.WriteLine("{0} is divisible by both 5 and 7? {1}", number);
        }
    }
}
