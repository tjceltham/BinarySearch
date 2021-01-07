using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 4, 7,9,56,78,150,345 };
            int num = 0;
            string numStr = "";
            Console.WriteLine("Enter the number you would like to search for");
            numStr = Console.ReadLine();
            num = Convert.ToInt32(numStr);

            // add a Binary search code here
            // Print out a message stating if the number is in the list and if it is 
            // in the list print out the index of the number
        }
    }
}
