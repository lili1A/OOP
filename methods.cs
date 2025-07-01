// method 
public string Mergename(string firstName, string lastName)
{
    string name = firstName + " " + lastName
    return name
}
// calling the method 
string fullname = Mergename(lastName: "Smith", firstName: "Suzanne");
// another approach 
string fullname = Mergename("Suzanne", "Smith");

// default arguements
private double CalculateTax(double price, double taxRate = 0.07) // default raxRate
{
    double tax = price * taxRate;
    return tax;
}

// calling the method 
double tax = CalculateTax(100.0) // no need to imput taxRate since it's default 
double tax = CalculateTax(100.0, 0.08) // overriding default parameter is allowed 

// get & set 
public bool GraduateEligibility
{
    get { return _EligibleToGraduate; }
} // read only 

public double FeesPayable
{
    get { return _FeesPayable; }
    set { _FeesPayable = value }
} // read & write 

public double Diameter
{
    get { return _diameter; }
    set { _diameter = value; }
}

// example usage 
public class Person 
{
    public string Name { get; set; }
}

Person p = new Person();
p.Name = "Alice"; // calls set
Console.WriteLine(p.Name); // calls get 

// event handlers - form class only 
private void btnClickMe_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hi");
    labelMyName.Text = "Liliia"
}

/* Create a Dog class that manages the dog name, color, breed and age. 
It should a have a constructor which accepts all these values for a dog object. 
All fields should be private but all properties must be read-write. 
It should have a method that returns all the field values in a single string.
 */

 Using System;
 
 public class Dog
 {
    // private fields
    private string name;
    private string color;
    private string breed;
    private int age;

    // public read-write properties 
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Color 
    {
        get { return color; }
        set { color = value; }
    }

    public string Breed 
    {
        get { return breed; }
        set { breed = value; }
    }

    public int Age 
    {
        get { retun age; }
        set { age = value; }
    }

    // constructor 
    public Dog(string name, string breed, int age)
    {
        this.name = name;
        this.color = color;
        this.breed = breed;
    }

    // returning all values as a single string
    public string GetDogDetails()
    {
        return $"Name: {Name}, Color: {Color}, Breed: {Breed}, Age: {Age}";
    }
 }

 // usage example 

class Program 
{
    static void Main()
    {
        Dog myDog = Dog("Buddy", "Brown", "Labrador", 4);
        Console.WriteLine(myDog.GetDogDetails());

        // modified property 
        myDog.Age = 5;
        Console.WriteLine("Updated Age: " + myDog.Age);
    }
}

// out parameters 
void GetDogInfo(out string name, out int age)
{
    name = "Buddy";
    age = 5
}

//usage
class Program 
{
    static vois Main()
    {
        string dogname;
        int dogAge;

        GetDogInfo(out dogName, out dogAge);
        Console.WriteLine($"Name: {dogname}, Age: {dogAge}")
    }
}
