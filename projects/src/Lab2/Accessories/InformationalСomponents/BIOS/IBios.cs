namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;

public interface IBios : IComputerComponent, IBiosBuilderDirector
{
    public string TypeBios { get; protected init; }
    public string Version { get; protected init; }
    public string SupportedProcessors { get; protected init; }
}