using System.Collections.Generic;

// declaring a list
List<int> numbers = new List<int>();
List<string> fruits = new List<string>();

// initializing with values
List<int> numbers = new List<int> { 1, 2, 3, 4, 5};
List<string> fruits = new List<string> { "apple", "banana", "orange"};

// adding elements 
numbers.Add(6);
fruits.Add("grape");

// accessing elements 
Console.WriteLine(numbers[0])
Console.WriteLine(fruits[2])

// removing elements 
fruits.Remove("banana"); // by value
numbers.RemoveAt(0); // by index 

// looping through list
foreach (string fruit in fruits)
{
   Console.WriteLine(fruit);
}

for (int i = 0; i < numbers,.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

// other methods 
fruits.Constrains("apple"); // returns True
numbers.Count; // length 
fruits.Clear(); // removes all elements 
numbers.Sort(); // asc sort 
numbers.Reverse() // desc sort 

// usage example 
using System;
using System.Collections.Generic;

class Program 
{
    static void Main()
    {
        List<string> fruits = new List<string> { "apple", "banana", "orange" };
        fruits.Add("grape");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("Total fruits: " + fruits.Count);
    }
}
