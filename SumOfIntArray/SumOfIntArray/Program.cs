using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfIntArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2};
            
            if(SumOfNumbers(numbers, out int sum)) Console.WriteLine($"Sum of nubmers in array: {sum}");
            else Console.WriteLine("Array is empty");

            Console.ReadLine();
        }

        static bool SumOfNumbers(int[] numbers, out int sum )
        {
            sum = 0;
            
            if (numbers.Length==0) return false;

            foreach (int number in numbers)
            {
                sum += number;
            }
            
            return true;
        }
    }
}
