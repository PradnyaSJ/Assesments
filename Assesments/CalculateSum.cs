using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
  public class CalculateSum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }

            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}
        
