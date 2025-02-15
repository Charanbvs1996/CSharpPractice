using CSharpOOPSPractice;

#region "Challenge1: Implement Inheritance"

List<Shape> shapes = new List<Shape>
            {
                new Circle(),
                new Rectangle(),
                new Triangle1()
            };
foreach (var shape in shapes)
{
    shape.CalculateArea();
    Console.WriteLine(new string('-', 40)); // Separator line
}

#endregion

#region"Challenge2: Implement Interface"

Console.WriteLine("Select the shape for which you want to calculate the area: \n1. Circle\n2. Rectangle\n3. Triangle");
string? shapeSel = Console.ReadLine();
switch (shapeSel)
{
    case "1":
        IShape circle1 = new Circle1();
        circle1.CalculateArea();
        ((IPrintable)circle1).PrintArea();
        break;
    case "2":
        IShape rectangle1 = new Rectangle1();
        rectangle1.CalculateArea();
        ((IPrintable)rectangle1).PrintArea();

        break;
    case "3":
        IShape triangle = new Triangle();
        triangle.CalculateArea();
        ((IPrintable)triangle).PrintArea();
        break;
    default:
        Console.WriteLine("Invalid selection. Please select a valid shape.");
        break;
}

Console.WriteLine("\n✅ All shape calculations completed successfully!");
Console.ReadLine();

#endregion
