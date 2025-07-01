// if 
int age = 20;
if (age >= 18)
{
    Console.WriteLine("You are an adult");
}

// if-else
int age = 16;
if (age>= 18)
{
    Console.WriteLine("You can vote");
}
else 
{
    Console.WriteLine("You cannot vote")
}

//elif 
int score = 75
if (score>= 90)
{
    Console.WriteLine("A");
}
else if (score>= 80)
{
    Console.WriteLine("B");
}
else if (score>= 70)
{
    Console.WriteLine("C");
}
else 
{
    Console.WriteLine("F");
}

// nested if 
int age = 25;
bool hasID = true;

if (age >= 18)
{
    if (hasID)
    {
        Console.WriteLine("Can enter");
    }
    else
    {
        Console.WriteLine("Need ID");
    }
}
else 
{
    Console.WriteLine("Too young");
}

// switch 

int day = 3

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break
}
