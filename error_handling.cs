// try catch 

try 
{
    int x = int.Parse("abc"); // throws format exceptoin
}
catch (FormatException ex)
{
    Console.WriteLine("Invalid number format")
}

// checking for null/empty strings 
string input = Console.ReadLine();
if (string.IsNullOrEmpty(input)); // or use IsNullOrWhiteSpace()
{
    Console.WriteLine("Input cannot be empty");
}
else 
{
    Console.WriteLine("Your input: " + input);
}

// TryParse() for safer conversion 
int result;
bool sucess = int.TryParse(input, out result);
if (success)
{
    Console.WriteLine("Valid number: " + result)
}
else:
{
    Console.WriteLine("Invalid number")
}

// combined error handling 

string input = Console.ReadLine(); // reads user input as a string 

if (string.IsNullOrEmpty(input)) // checks if string is null or empty 
{
    Console.WriteLine("Empty input");
}
else 
{
    try
    {
        int number;
        if (int.TryParse(input, out number)) // attempts converting a string into an int 
        {
            Console.WriteLine("You've entered: " + number); // returns true if vald format
        }
        else
        {
            Console.WriteLine("Please write a valid nuber");
        }
    }
    catch (Exception ex)
    {
        console.WriteLine("Error " + ex.Message);
    }
}
