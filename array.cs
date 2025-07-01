// declaring with size
int[] numbers = new int[5];

// declaring with initialisation 
int[] numbers = new int[] { 1, 2, 3, 4, 5 };
string[] fruits = new string[] { "apple", "banana", "orange" };

// shortcut 
int[] numbers = { 1, 2, 3, 4, 5 };
string[] fruits = { "apple", "banana", "orange" };


class Program
{
    static void Main()
    {
        string[] colors = { "Red", "Green", "Blue" };
        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine(colors[i]);
        }
    }
}
