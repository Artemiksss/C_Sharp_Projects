using Itmo.ObjectOrientedProgramming.Lab2.Accessories;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.BasicСomponents.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Inspector;

public interface IInspector
{
    public bool CheckingSockets(ICpu cpu, IMotherboard motherboard);
    public bool CheckingBios(IBios bios, IMotherboard motherboard);
    public bool CheckingTheHeatRelease(IProcessorCoolingSystem processorCoolingSystem, ICpu cpu);

    public bool VoltageCheck(IPowerUnit powerUnit, ICpu cpu, IRam ram, IGraphicAdapter? graphicAdapter, ISsd? ssd, IHdd? hdd, IWiFiAdapter? wiFiAdapter);
    public bool CheckingTheQuantity(IMotherboard? motherboard, ISsd? ssd, IGraphicAdapter? graphicAdapter);

    public bool CheckingSize(IMotherboard motherboard, IProcessorCoolingSystem processorCoolingSystem, IGraphicAdapter graphicAdapter, ISystemBlock systemBlock);
}