using System; 

public class Table 
{
    public string Model { get; set; }
    public string TopShape { get; set; }
    public double LongWidth { get; set; }
    public double ShortWidth { get; set; }
    public double Height { get; set; }
    public int LegsNumber { get; set; }
    public string TopMaterial { get; set; }
    public string LegMaterial { get; set; }
    public string Color { get; set; }

   public Table(string model, string topShape, double longWidth, double shortWidth, double height, int legsNumber, string topMaterial, string legMaterial, string color) 
   {
    Model = model;
    TopShape = topShape.ToLower();
    LongWidth = longWidth;
    ShortWidth = shortWidth;
    Height = height;
    LegsNumber = legsNumber;
    TopMaterial = topMaterial;
    LegMaterial = legMaterial;
    Color = color;
   }

   public void PrintDetails() 
   {
    Console.WriteLine($"Model: {Model}");
    Console.WriteLine($"Top shape: {TopShape}");
    Console.WriteLine($"Dimensions: {LongWidth}cm x {ShortWidth}cm");
    Console.WriteLine($"Height: {Height}cm");
    Console.WriteLine($"Legs: {LegsNumber}");
    Console.WriteLine($"Top Material: {TopMaterial}");
    Console.WriteLine($"Leg Material: {LegMaterial}");
    Console.WriteLine($"Color: {Color}");
   }

   public double GetTopArea()
   {
        switch (TopShape)
        {
            case "rectangle":
                return LongWidth * ShortWidth;

            case "oval":
                return Math.PI * (LongWidth / 2) * (ShortWidth / 2);

            case "round":
                double radius = LongWidth / 2; // assuming LongWidth is diameter
                return Math.PI * radius * radius;
            default:
                Console.WriteLine("Unknown shape. Cannot compute area.");
                return 0;
        }
   }
}

// usage example

class Program
{
    static void Main()
    {
        Table table = new Table("ModernX", "rectangle", 120, 60, 75, 4, "Wood", "Steel", "Black");
        table.PrintDetails();
        Console.WriteLine($"Top Area: {table.GetTopArea():F2} cm^2") // F - fixed-point numeric format, 2 - 2 digits after decimal point 
    }
}
