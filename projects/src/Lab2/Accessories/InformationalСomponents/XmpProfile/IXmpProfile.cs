namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;

public interface IXmpProfile : IComputerComponent, IXmpProfileBuilderDirector
{
    public string Timings { get;  protected init; }
    public double Voltage { get; protected init; }
    public int Frequency { get; protected init; }
}