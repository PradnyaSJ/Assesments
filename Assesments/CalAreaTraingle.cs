using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class CalAreaTraingle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base length:");
            double baseL = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height:");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * baseL * height;
            Console.WriteLine($"Area of traingle {area}");
        }
    }
}
