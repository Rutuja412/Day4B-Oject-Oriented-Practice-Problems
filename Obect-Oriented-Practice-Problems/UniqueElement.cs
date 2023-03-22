using System;
using System.Collections.Generic;
using System.Text;

namespace Obect_Oriented_Practice_Problems
{
    internal class UniqueElement
    {
        public static void CheckUniqueElement()
        {
            int[] items = { 2, 3, 5, 3, 7, 5,6,9 }; 
           foreach (int number in items)
            {
                Console.WriteLine(number);
            }
            
            Console.WriteLine("Unique array elements: ");  
  
            for(int i=0; i<items.Length;i++)  
            {  
                bool isDuplicate = false;  
                for(int j=0;j<i;j++)  
                {  
                    if(items[i] == items[j])  
                    {  
                        isDuplicate = true;  
                        break;  
                    }  
                }  
  
                if(!isDuplicate)  
                {  
                    Console.WriteLine(items[i]);  
                      
                }  
            }  
        }
    }
}
