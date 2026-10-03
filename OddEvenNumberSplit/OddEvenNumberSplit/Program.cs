using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumberSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if(i%2==0) even.Add(i);
                else odd.Add(i);
            }

            Console.Write("Odd list: ");

            for (int i = 0; i < odd.Count; i++)
            {
                Console.Write($"{odd[i]} ");
            }

            Console.Write("\nEven list: ");
            for (int i = 0;i < even.Count; i++)
            {
                Console.Write($"{even[i]} ");
            }

            Console.ReadLine();
        }
    }
}
