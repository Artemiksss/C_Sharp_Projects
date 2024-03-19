using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.MotherboardFormFactor;

namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IMotherboard : IComputerComponent, IMotherboardBuilderDirector
{
    public string CpuSocket { get;  protected init; }
    public int PciELanes { get; protected init; }
    public int SataPorts { get; protected init; }
    public string Chipset { get; protected init; }
    public string DdrStandard { get; protected init; }
    public int RamSlots { get; protected init; }
    public IFormFactor FormFactor { get; protected init; }
    public IBios Bios { get; protected init; }
}