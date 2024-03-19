using Itmo.ObjectOrientedProgramming.Lab2.Accessories;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.BasicСomponents.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComputerAssembler;

public interface IComputerAssemblerBuilder
{
    public ComputerAssemblerBuilder SetCpu(ICpu currentCpu);
    public ComputerAssemblerBuilder SetMotherboard(IMotherboard currentMotherboard);
    public ComputerAssemblerBuilder SetGraphicsAdapter(IGraphicAdapter? currentGraphicAdapter);
    public ComputerAssemblerBuilder SetHdd(IHdd? currentHdd);
    public ComputerAssemblerBuilder SetProcessorCoolingSystem(IProcessorCoolingSystem currentProcessorCoolingSystem);
    public ComputerAssemblerBuilder SetPowerUnit(IPowerUnit currentPowerUnit);
    public ComputerAssemblerBuilder SetRam(IRam currentRam);
    public ComputerAssemblerBuilder SetSsd(ISsd? currentSsd);
    public ComputerAssemblerBuilder SetSystemBlock(ISystemBlock currentSystemBlock);
    public ComputerAssemblerBuilder SetBios(Bios currentBios);
    public ComputerAssemblerBuilder SetWiFiAdapter(IWiFiAdapter? currentWiFiAdapter);
    public ComputerAssemblerBuilder SetCXmpProfile(IXmpProfile? currentXmpProfile);
    public ComputerAssembler Build();
}