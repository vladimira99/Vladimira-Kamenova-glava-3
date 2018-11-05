using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 45764;
            bool isSeven = (number / 100) % 10 == 7 ? true : false;
            Console.WriteLine("Third digit of {0} is 7", number);
        }
    }
}
