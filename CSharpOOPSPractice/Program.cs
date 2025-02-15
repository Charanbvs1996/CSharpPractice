using CSharpOOPSPractice;

Circle circle = new Circle();
double radius = circle.GetUserInput("For what radius you want to calculate the area of circle?");
circle.CalculateArea(radius);
Rectangle rectangle = new Rectangle();
double length = rectangle.GetUserInput("Enter length for which you want to calculate the area of Rectangle?");
double breadth = rectangle.GetUserInput("Enter breadth for which you want to calculate the area of Rectangle?");
rectangle.CalculateArea(length, breadth);


