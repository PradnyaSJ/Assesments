using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class calPer
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

            double total = s1 + s2 + s3 + s4 + s4 + s5;

            double per = (total / 500) * 100;

            Console.WriteLine($"Total marks {total}");
            Console.WriteLine($"Percentage {per}%");




        }
    }
}
