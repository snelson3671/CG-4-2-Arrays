using System;

namespace CG_4_2_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {   
            //put the following values into an integer array named numbers
            int[] numbers = new int[] { 1, 1, 2, 3, 5, 8 };

            //go through each element in the array
            //beginning with the first one, until you have reached the end 
            for (int i = 0; i < numbers.Length; i++)
            {
                //write each element on the console window
                Console.WriteLine(numbers[i]);
            }
            
            Console.ReadLine();
        }
    }
}
