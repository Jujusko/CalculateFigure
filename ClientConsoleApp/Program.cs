// See https://aka.ms/new-console-template for more information
using CalculateFigure;

Figure firstFigure = new Circle(0);
Figure secondFigure = new Triangle(1, 12, 3);

Console.WriteLine(firstFigure.GetSquare());
Console.WriteLine(secondFigure.GetSquare());
