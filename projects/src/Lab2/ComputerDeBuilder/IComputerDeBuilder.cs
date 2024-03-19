using Itmo.ObjectOrientedProgramming.Lab2.Accessories;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.BasicСomponents.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerAssembler;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerDeBuilder;

public interface IComputerDeBuilder
{
    public IComputerAssembler ChangingProcessor(ICpu cpu);
    public IComputerAssembler ChangingMotherboard(IMotherboard motherboard);
    public IComputerAssembler ChangingGraphicAdapter(IGraphicAdapter graphicAdapter);
    public IComputerAssembler ChangingHdd(IHdd hdd);
    public IComputerAssembler ChangingPowerUnit(IPowerUnit powerUnit);
    public IComputerAssembler ChangingProcessorCoolingSystem(IProcessorCoolingSystem processorCoolingSystem);
    public IComputerAssembler ChangingRam(IRam ram);
    public IComputerAssembler ChangingSsd(ISsd ssd);
    public IComputerAssembler ChangingSystemBlock(ISystemBlock systemBlock);
    public IComputerAssembler ChangingBios(Bios bios);
    public IComputerAssembler ChangingWiFiAdapter(IWiFiAdapter wiFiAdapter);
    public IComputerAssembler ChangingCurrentXmpProfile(IXmpProfile xmpProfile);
}