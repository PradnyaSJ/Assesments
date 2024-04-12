using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class CalGrade
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks for subject1:");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks for subject2:");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks for subject3:");
            double s3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks for subject4:");
            double s4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter marks for subject5:");
            double s5 = Convert.ToDouble(Console.ReadLine());

            Double per = ((s1 + s2 + s3 + s4 + s5) * 100) / 500;
            Console.WriteLine($"percentage is {per}");

            if (per >= 75)
            {
                Console.WriteLine("Grade:First class with distinction");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Grade:First class");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Grade:second class");
            }
            else
            {
                Console.WriteLine("Grade:fail");
            }
        }
    }
}
