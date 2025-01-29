public class Shape
{
    private string color { get; set; }
    private int x { get; set; }
    private int y;

    public Shape(string color, int x, int y)
    {
        this.color = color;
        this.x = x;
        this.y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Цвет: {color}, Координаты центра: ({x}, {y})");
    }
}

public class Circle : Shape
{
    public Circle(string color, int x, int y) 
        : base(color, x, y) { }
    
}

public class Triangle : Shape
{
    public Triangle(string color, int x, int y)
        : base(color, x, y) { }

}
public class Rectangle : Shape
{
    public Rectangle(string color, int x, int y)
        : base(color, x, y) { }

}

public class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle("Красный", 0, 0);
        Shape rectangle = new Rectangle("Синий", 2, 3);
        Shape triangle = new Triangle("Зелёный", -1, -1);

        circle.Display();

        rectangle.Display();

        triangle.Display();
    }
}