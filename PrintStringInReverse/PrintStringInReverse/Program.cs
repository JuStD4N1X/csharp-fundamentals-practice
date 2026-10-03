using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PrintStringInReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }
            Console.WriteLine();
            for (int i = name.Length-1; i >= 0; i--) 
            {
                Console.Write(name[i]);
            }

            Console.ReadLine();
        }
    }
}
