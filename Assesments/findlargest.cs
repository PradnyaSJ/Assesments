using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class findlargest
    {
        static void Main(string[] args)
        {
            
                Console.Write("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int max = (num1 > num2) ? num1 : num2;
                Console.WriteLine("The largest number is: " + max);
            }
        }
    }

    

