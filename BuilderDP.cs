using System;
namespace BuilderDP
{
// Product: Computer class representing the complex object being built
class Computer
{
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }
    public string GPU { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Computer Configuration - CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, GPU: {GPU}");
    }
}

// Builder interface defining the steps to build a Computer
interface IComputerBuilder
{
    void SetCPU();
    void SetRAM();
    void SetStorage();
    void SetGPU();
    Computer GetComputer();
}

// Concrete Builder implementing the steps to build a Computer
class OfficeComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();

    public void SetCPU()
    {
        computer.CPU = "Intel Core i5";
    }

    public void SetRAM()
    {
        computer.RAM = "8GB DDR4";
    }

    public void SetStorage()
    {
        computer.Storage = "256GB SSD";
    }

    public void SetGPU()
    {
        computer.GPU = "Integrated Graphics";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}

// Director class that manages the building process
class ComputerDirector
{
    public void Construct(IComputerBuilder builder)
    {
        builder.SetCPU();
        builder.SetRAM();
        builder.SetStorage();
        builder.SetGPU();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ComputerDirector director = new ComputerDirector();
        IComputerBuilder builder = new OfficeComputerBuilder();

        director.Construct(builder);
        Computer computer = builder.GetComputer();

        computer.DisplayInfo();
    }
}


}
