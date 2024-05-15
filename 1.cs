using System;

public interface IShape
{
    double CalculateArea();
    string ShapeType { get; }
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public string ShapeType => "Circle";
}

public class Triangle : IShape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public double CalculateArea()
    {
        double p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public bool IsRightAngleTriangle()
    {
        return Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2) ||
               Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2) ||
               Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
    }

    public string ShapeType => "Triangle";
}

// Добавим пример использования
class Program
{
    static void Main()
    {
        Circle circle = new Circle { Radius = 5 };
        Triangle triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };

        Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");
        Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
        Console.WriteLine($"Является ли треугольник прямоугольным: {triangle.IsRightAngleTriangle()}");
    }
}
