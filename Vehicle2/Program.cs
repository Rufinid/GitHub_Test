public class Vehicle
{
    public virtual void Drive()
    {
        Console.WriteLine("Транспорт начал движение!");
    }
}

public class Car : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Автомобиль едет по дороге.");
    }
}

public class Bicycle : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Велосипед движется по велодорожке.");
    }
}

public class Boat : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Лодка плывет по воде.");
    }
}

public class Program
{
    static void Main()
    {
        Vehicle car = new Car();
        Vehicle bicycle = new Bicycle();
        Vehicle boat = new Boat();

        car.Drive();
        bicycle.Drive();
        boat.Drive();
    }
}