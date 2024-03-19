namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IGraphicAdapter : IComputerComponent, IGraphicsAdapterBuilderDirector
{
    public int Width { get; protected init; }
    public int Height { get; protected init; }
    public int CountVideoMemory { get; protected init; }
    public int PciEVersion { get; protected init; }
    public int ChipFrequency { get; protected init; }
    public int PowerConsumption { get; protected init; }
}