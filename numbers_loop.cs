/* Given an array below, write a C# code to implement a do-while loop to iterate through the elements of the array and calculate the sum of all positive integers.
int[] numbers = ( 5, -3, 8, -2, 5, 10, -7, 15 ); */

using System;

class Program 
{
    static void Main()
    {
        int[] numbers = { 5, -3, 8, -2, 5, 10, -7, 15 };
        int sum = 0;
        int i = 0; // loop starting counter 

        do 
        {
            if (number[i] > 0) // only positive numbers 
            {
                sum += numbers[i]; // adds current number to the sum 
            }
            i++ // moves to the next array
        } while (i < numbers.Length);

        Console.WriteLine("Sum of possible integers: " + sum)
    }
}
