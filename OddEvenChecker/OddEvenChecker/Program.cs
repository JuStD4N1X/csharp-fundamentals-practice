using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 2;

            int remainder = a % b;

            Console.WriteLine(remainder);

            a = 31;

            remainder = a % b;

            Console.WriteLine(remainder);

            Console.ReadLine();
        }
    }
}
