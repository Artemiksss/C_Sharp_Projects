namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IProcessorCoolingSystem : IComputerComponent, IProcessorCoolingSystemDirector
{
    public int Width { get; protected init; }
    public int Height { get; protected init; }
    public string SupportedSockets { get; protected init; }
    public int Tdp { get; protected init; }
}