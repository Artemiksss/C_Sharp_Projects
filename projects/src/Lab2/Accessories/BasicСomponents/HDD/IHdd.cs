namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IHdd : IComputerComponent, IHddBuilderDirector
{
    public int Capacity { get; protected init; }
    public int SpindleRotationSpeed { get; protected init; }
    public int PowerConsumption { get; protected init; }
}