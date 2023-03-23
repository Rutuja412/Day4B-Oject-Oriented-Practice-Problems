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
        public static void CreateRectanglaStarPattern()
        {
            Console.WriteLine("Enter Length of rectangle ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write(" ");

            for (int i = 1; i <= b; i++)
            {
                for (int j = 1; j <= l; j++)
                {
                    if (i == 1 || i == b || j == 1 || j == l)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n ");
            }
        }
    }
    
}
