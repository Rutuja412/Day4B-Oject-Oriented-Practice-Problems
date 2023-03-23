using System;

namespace Obect_Oriented_Practice_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Object Oriented Practice Problems");
            Console.WriteLine("Select given options");
            Console.WriteLine("1.Duplicate Element \n2.Unique Element\n3Frequency Of Element\n4 Find Max & Min\n5.Create Reverse Right Star Pattern ");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Duplicate Number");
                    DuplicateNumber.CheckDuplicate();
                    break;
                case 2:
                    UniqueElement.CheckUniqueElement();
                    break;
                case 3:
                    FrequencyOfElement.FindFrequency();
                    break;
                case 4:
                    FindMaxMin.FindMaximumMinimum();
                    break;
                case 5:
                    Pattern.CreateReverseRightStarPattern();
                    break;
            }
        }
    }
}
