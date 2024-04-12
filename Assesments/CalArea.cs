using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class CalArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius:");
            double radius = Convert.ToDouble(Console.ReadLine());

            double pi = 3.14;
            double area =pi* radius * radius;

            Console.WriteLine($"Area of circle {area} ");
        }
    }
}
