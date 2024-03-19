namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface ISystemBlock : IComputerComponent, ISystemBlockBuilderDirector
{
    public int MaximumLengthVideoCard { get; protected init; }
    public int MaximumWidthVideoCard { get; protected init; }
    public string SupportedFormFactorsMotherboards { get; protected init; }
    public int Width { get; protected init; }
    public int Height { get; protected init; }
}