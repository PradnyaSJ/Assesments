﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments
{
    public class NegPos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            string result = (num > 0) ? "Positive" : (num < 0) ? "Negative" : "Zero";
            Console.WriteLine("The Number is:"+result);
        }
    }
}
