using Itmo.ObjectOrientedProgramming.Lab2.Accessories;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.BasicСomponents.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAssembler;

public class ComputerAssembler : IComputerAssembler
{
    public ComputerAssembler(ICpu cpu, IMotherboard motherboard, IGraphicAdapter graphicAdapter, IHdd? hdd, IPowerUnit powerUnit, IProcessorCoolingSystem processorCoolingSystem, IRam ram, ISsd? ssd, ISystemBlock systemBlock, Bios bios, IWiFiAdapter? wiFiAdapter, IXmpProfile? xmpProfile)
    {
        CurrentCpu = cpu;
        CurrentMotherboard = motherboard;
        CurrentGraphicAdapter = graphicAdapter;
        CurrentHdd = hdd;
        CurrentPowerUnit = powerUnit;
        CurrentProcessorCoolingSystem = processorCoolingSystem;
        CurrentRam = ram;
        CurrentSsd = ssd;
        CurrentSystemBlock = systemBlock;
        CurrentBios = bios;
        CurrentWiFiAdapter = wiFiAdapter;
        CurrentXmpProfile = xmpProfile;
    }

    public ICpu CurrentCpu { get; init; }
    public IMotherboard CurrentMotherboard { get; init; }
    public IGraphicAdapter? CurrentGraphicAdapter { get; init; }
    public IHdd? CurrentHdd { get; init; }
    public IPowerUnit CurrentPowerUnit { get; init; }
    public IProcessorCoolingSystem CurrentProcessorCoolingSystem { get; init; }
    public IRam CurrentRam { get; init; }
    public ISsd? CurrentSsd { get; init; }
    public ISystemBlock CurrentSystemBlock { get; init; }
    public Bios CurrentBios { get; init; }
    public IWiFiAdapter? CurrentWiFiAdapter { get; init; }
    public IXmpProfile? CurrentXmpProfile { get; init; }
    public IComputerAssemblerBuilder Direct()
    {
        var builder = new ComputerAssemblerBuilder();
        return builder.SetCpu(CurrentCpu)
            .SetMotherboard(CurrentMotherboard)
            .SetGraphicsAdapter(CurrentGraphicAdapter)
            .SetHdd(CurrentHdd)
            .SetPowerUnit(CurrentPowerUnit)
            .SetProcessorCoolingSystem(CurrentProcessorCoolingSystem)
            .SetRam(CurrentRam)
            .SetSsd(CurrentSsd)
            .SetSystemBlock(CurrentSystemBlock)
            .SetBios(CurrentBios)
            .SetWiFiAdapter(CurrentWiFiAdapter)
            .SetCXmpProfile(CurrentXmpProfile);
    }
}