namespace Lab1
{

public class Rectangle
{

    private double SIDE_a;
    private double SIDE_b;

    public Rectangle(double SIDE_a, double SIDE_b)
    {
        if (SIDE_a <= 0 || SIDE_b <= 0)
            throw new ArgumentException("Длины сторон не могут быть отрицательными или равны нулю.");
        this.SIDE_a = SIDE_a;
        this.SIDE_b = SIDE_b;
    }

    private double CalculateArea()
    {
        return SIDE_a * SIDE_b;
    }

    private double CalculatePerimeter()
    {
        return 2 * (SIDE_a + SIDE_b);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите сторону A: ");
        double SIDE_a = double.Parse(Console.ReadLine());

        Console.Write("Введите сторону B: ");
        double SIDE_b = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(SIDE_a, SIDE_b);
        Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
    }
}
}