using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight of a man: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("This person will weight {0}kg on the Moon.", weight * 0.17);
        }
    }
}
