using Itmo.ObjectOrientedProgramming.Lab2.Accessories;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.BasicСomponents.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAssembler;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerDeBuilder;

public class ComputerDeBuilder : IComputerDeBuilder
{
    private readonly ComputerAssembler.ComputerAssembler _computer;
    public ComputerDeBuilder(ComputerAssembler.ComputerAssembler computer)
    {
        _computer = computer;
    }

    public IComputerAssembler ChangingProcessor(ICpu cpu)
    {
        return _computer.Direct().SetCpu(cpu).Build();
    }

    public IComputerAssembler ChangingMotherboard(IMotherboard motherboard)
    {
        return _computer.Direct().SetMotherboard(motherboard).Build();
    }

    public IComputerAssembler ChangingGraphicAdapter(IGraphicAdapter graphicAdapter)
    {
        return _computer.Direct().SetGraphicsAdapter(graphicAdapter).Build();
    }

    public IComputerAssembler ChangingHdd(IHdd hdd)
    {
        return _computer.Direct().SetHdd(hdd).Build();
    }

    public IComputerAssembler ChangingPowerUnit(IPowerUnit powerUnit)
    {
        return _computer.Direct().SetPowerUnit(powerUnit).Build();
    }

    public IComputerAssembler ChangingProcessorCoolingSystem(IProcessorCoolingSystem processorCoolingSystem)
    {
        return _computer.Direct().SetProcessorCoolingSystem(processorCoolingSystem).Build();
    }

    public IComputerAssembler ChangingRam(IRam ram)
    {
        return _computer.Direct().SetRam(ram).Build();
    }

    public IComputerAssembler ChangingSsd(ISsd ssd)
    {
        return _computer.Direct().SetSsd(ssd).Build();
    }

    public IComputerAssembler ChangingSystemBlock(ISystemBlock systemBlock)
    {
        return _computer.Direct().SetSystemBlock(systemBlock).Build();
    }

    public IComputerAssembler ChangingBios(Bios bios)
    {
        return _computer.Direct().SetBios(bios).Build();
    }

    public IComputerAssembler ChangingWiFiAdapter(IWiFiAdapter wiFiAdapter)
    {
        return _computer.Direct().SetWiFiAdapter(wiFiAdapter).Build();
    }

    public IComputerAssembler ChangingCurrentXmpProfile(IXmpProfile xmpProfile)
    {
        return _computer.Direct().SetCXmpProfile(xmpProfile).Build();
    }
}