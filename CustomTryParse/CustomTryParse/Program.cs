using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            bool success = false;

            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number);
                success = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(success ? "Yay" : "Nah");

            Console.ReadLine(); */

            Console.Write("Enter a number: ");
            if(TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("Yey " + result);
            }
            else
            {
                Console.WriteLine("Oh no");
            }

            Console.ReadLine();
            
        }

        

        static bool TryParse(string input, out int result)
        {
            result = -1;
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
