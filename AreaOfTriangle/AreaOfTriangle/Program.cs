
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATING AREA OF A TRIANGLE \n");

            float width = ReadFloat("width: ");
            float height = ReadFloat("height: ");

            float area = CalculateArea(width, height);

            Console.WriteLine($"Area: {area}");

            Console.ReadLine();
        }

        static float ReadFloat(string message)
        {
            Console.Write($"Enter {message}");
            return Convert.ToSingle(Console.ReadLine());
        }

        static float CalculateArea(float width, float height)
        {
            return (width * height) / 2;
            
        }
    }
}
