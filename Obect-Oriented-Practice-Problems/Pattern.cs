using System;
using System.Collections.Generic;
using System.Text;

namespace Obect_Oriented_Practice_Problems
{
    internal class Pattern
    {
        public static void CreateReverseRightStarPattern()
        {
            Console.WriteLine("Enter number of * input");
            int n =Convert.ToInt32(Console.ReadLine());
            for (int row = n; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
