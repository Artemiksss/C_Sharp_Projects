namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.BasicСomponents.CPU;

public interface ICpu : IComputerComponent, ICpuBuilderDirector
{
    public double CoreFrequency { get; protected init; }
    public int NumberOfCores { get; protected init; }
    public string Socket { get; protected init; }
    public bool IntegratedGraphics { get; protected init; }
    public int SupportedMemoryFrequencies { get; protected init; }
    public int Tdp { get; protected init; }
    public int PowerConsumption { get; protected init; }
}