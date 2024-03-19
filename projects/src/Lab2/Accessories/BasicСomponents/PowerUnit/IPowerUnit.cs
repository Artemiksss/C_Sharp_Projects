namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IPowerUnit : IComputerComponent, IPowerUnitBuilderDirector
{
    public int PeakLoad { get; protected init; }
}