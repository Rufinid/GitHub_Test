public class CPU
{
    private string? Cores { get; set; }

    public CPU(string? Cores)
    {
        this.Cores = Cores;
    }
    public void Start()
    {
        Console.WriteLine($"CPU c {Cores} ядрами запущен");
    }
    public void Stop()
    {
        Console.WriteLine("");
    }
}
public class RAM
{
    private string Type { get; }
    public RAM(string type)
    {
        Type = type;
    }
    public void Load()
    {
        Console.WriteLine($"RAM {Type} загружена.");
    }
    public void Unload()
    {
        Console.WriteLine("RAM очищена.");
    }
}
public class GPU
{
    private string Model { get; }
    private int Memory { get; } 

    public GPU(string model, int memory)
    {
        Model = model;
        Memory = memory;
    }

    public void Start()
    {
        Console.WriteLine($"GPU {Model} с {Memory} памяти запущен.");
    }
    public void Stop()
    {
        Console.WriteLine($"GPU {Model} выключен.");
    }
}
public class Computer
{
    private CPU _cpu;
    private RAM _ram;
    private GPU _gpu;

    public Computer(CPU cpu, RAM ram, GPU gpu)
    {
        _cpu = cpu;
        _ram = ram;
        _gpu = gpu;
    }

    public void PowerOn()
    {
        Console.WriteLine("Включение компьютера.");
        _cpu.Start();
        _ram.Load();
        _gpu.Start();
        Console.WriteLine("Компьютер включен.");
    }
    public void PowerOff()
    {
        Console.WriteLine("Выключение компьютера.");
        _gpu.Stop();
        _ram.Unload();
        _cpu.Stop();
        Console.WriteLine("Компьютер выключен.");
    }
}
class Program
{
    static void Main()
    {
        var cpu = new CPU("Intel Core i7");
        var ram = new RAM("DDR4");
        var gpu = new GPU("NVIDIA RTX 3080", 10);
        var computer = new Computer(cpu, ram, gpu);

        computer.PowerOn();
        Console.WriteLine();
        computer.PowerOff();
    }
}