using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number = 7;
            int length = 5;
            int[] result = new int[length];

            for (int i = 1; i <= length; i++) { 
                result[i-1] = number*i;
            }

            foreach (int item in result)
            {
                Console.Write($"{item} ");
            }


            Console.ReadLine();
        }
    }
}
