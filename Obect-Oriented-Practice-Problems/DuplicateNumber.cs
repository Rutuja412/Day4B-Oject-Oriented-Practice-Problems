using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Obect_Oriented_Practice_Problems
{
    internal class DuplicateNumber
    {
        public static void CheckDuplicate()
        {
            int[] array = { 1,2,3,4,2,3 };
            foreach (int num in array)
            {

                Console.WriteLine(num);
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        Console.WriteLine("Duplicates numbers is :" + array[i]);
                     
                    }
                }

            }
           
        }
       
    }
}
