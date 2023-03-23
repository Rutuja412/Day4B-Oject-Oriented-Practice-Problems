using System;
using System.Collections.Generic;
using System.Text;

namespace Obect_Oriented_Practice_Problems
{
    internal class ReverseString
    {
        public static void ReverseWord()
        {
            Console.WriteLine("Enter a string");
            string word = Console.ReadLine();
            Console.WriteLine(word);
            string result = "";
            char[] Array = word.ToCharArray();
            for (int i=Array.Length-1; i>=0; i--)
            {
                result += Array[i];
            }
            Console.WriteLine(result);

        }
       
    }
}
