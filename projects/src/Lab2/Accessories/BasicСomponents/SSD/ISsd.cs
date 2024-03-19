namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface ISsd : IComputerComponent, ISsdBuilderDirector
{
    public string ConnectionOption { get; protected init; }
    public int Capacity { get; protected init; }
    public int MaximumOperatingSpeed { get; protected init; }
    public int PowerConsumption { get; protected init; }
}