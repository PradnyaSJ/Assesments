using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class findgratestcs
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            int greatest = num1;
            if (num2 > greatest)
            {
                greatest = num2;
            }
            if (num3 > greatest)
            {
                greatest = num3;
            }
            Console.WriteLine("The greatest no is:"+greatest);
        }
    }
}
