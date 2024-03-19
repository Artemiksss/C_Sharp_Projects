using Itmo.ObjectOrientedProgramming.Lab2.Accessories;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.BasicСomponents.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAssembler;

public interface IComputerAssembler
{
    public ICpu CurrentCpu { get; protected init; }
    public IMotherboard CurrentMotherboard { get; protected init; }
    public IGraphicAdapter? CurrentGraphicAdapter { get; protected init; }
    public IHdd? CurrentHdd { get; protected init; }
    public IPowerUnit CurrentPowerUnit { get; protected init; }
    public IProcessorCoolingSystem CurrentProcessorCoolingSystem { get; protected init; }
    public IRam CurrentRam { get; protected init; }
    public ISsd? CurrentSsd { get; protected init; }
    public ISystemBlock CurrentSystemBlock { get; protected init; }
    public Bios CurrentBios { get; init; }
    public IWiFiAdapter? CurrentWiFiAdapter { get; protected init; }
    public IXmpProfile? CurrentXmpProfile { get; protected init; }
    public IComputerAssemblerBuilder Direct();
}