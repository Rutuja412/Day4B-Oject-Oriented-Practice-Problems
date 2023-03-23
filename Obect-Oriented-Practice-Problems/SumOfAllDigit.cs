using System;
using System.Collections.Generic;
using System.Text;

namespace Obect_Oriented_Practice_Problems
{
    internal class SumOfAllDigit
    {
        public static void CalculateSum()
        {
            int sum = 0;
            Console.WriteLine("Enter a number");
            int n=Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
               int digit= n % 10;
                sum= sum + digit;
                n = n / 10; 

            }
            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }
}
