namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IRam : IComputerComponent, IRamBuilderDirector
{
    public int MemorySize { get; protected init;  }
    public int SupportedFreqVoltPairs { get; protected init; }
    public string AvailableProfiles { get; protected init; }
    public string FormFactor { get; protected init; }
    public string DdrVersion { get; protected init; }
    public double PowerConsumptionWatts { get; protected init; }
}