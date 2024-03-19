using System;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.BasicСomponents.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Inspector;

public class Inspector : IInspector
{
    public bool CheckingSockets(ICpu cpu, IMotherboard motherboard)
    {
        if (cpu is null || motherboard is null) throw new ComputerComponentNullException("The sockets of the motherboard and processor are different.");
        return cpu.Socket == motherboard.CpuSocket;
    }

    public bool CheckingBios(IBios bios, IMotherboard motherboard)
    {
        if (bios == null || motherboard == null) throw new ComputerComponentNullException("Bios versions or types differ.");
        return bios.TypeBios == motherboard.Bios.TypeBios && bios.Version == motherboard.Bios.Version;
    }

    public bool CheckingTheHeatRelease(IProcessorCoolingSystem processorCoolingSystem, ICpu cpu)
    {
        if (processorCoolingSystem == null || cpu == null) throw new ComputerComponentNullException("Exceeded heat dissipation.");
        return processorCoolingSystem.Tdp >= cpu.Tdp;
    }

    public bool VoltageCheck(IPowerUnit powerUnit, ICpu cpu, IRam ram, IGraphicAdapter? graphicAdapter, ISsd? ssd, IHdd? hdd, IWiFiAdapter? wiFiAdapter)
    {
        if (cpu == null || ram == null || powerUnit == null) throw new ComputerComponentNullException("One of the main components matters null");

        if (((graphicAdapter == null && cpu.IntegratedGraphics == true) && (ssd != null && hdd == null)) && wiFiAdapter == null)
        {
            return cpu.PowerConsumption + ssd.PowerConsumption <= powerUnit.PeakLoad;
        }

        if (((graphicAdapter != null && cpu.IntegratedGraphics == false) && (ssd != null && hdd == null)) && wiFiAdapter == null)
        {
            return cpu.PowerConsumption + ssd.PowerConsumption + graphicAdapter.PowerConsumption <= powerUnit.PeakLoad;
        }

        if (((graphicAdapter != null && cpu.IntegratedGraphics == false) && (ssd == null && hdd != null)) && wiFiAdapter == null)
        {
            return cpu.PowerConsumption + hdd.PowerConsumption + graphicAdapter.PowerConsumption <= powerUnit.PeakLoad;
        }

        if (((graphicAdapter != null && cpu.IntegratedGraphics) && (ssd != null && hdd != null)) && wiFiAdapter != null)
        {
            return cpu.PowerConsumption + hdd.PowerConsumption + graphicAdapter.PowerConsumption + wiFiAdapter.PowerConsumption <= powerUnit.PeakLoad + 150;
        }

        throw new ComputerComponentNullException("Power exceeded.");
    }

    public bool CheckingTheQuantity(IMotherboard? motherboard, ISsd? ssd, IGraphicAdapter? graphicAdapter)
    {
        if (motherboard == null) return false;
        if ((ssd != null && graphicAdapter != null) && motherboard.PciELanes >= 2) return true;
        if (((ssd == null && graphicAdapter != null) || (ssd == null && graphicAdapter != null)) && motherboard.PciELanes >= 1) return true;
        return false;
    }

    public bool CheckingSize(IMotherboard? motherboard, IProcessorCoolingSystem? processorCoolingSystem, IGraphicAdapter? graphicAdapter, ISystemBlock? systemBlock)
    {
        if (motherboard == null || processorCoolingSystem == null || graphicAdapter == null || systemBlock == null) return false;
        if (motherboard.FormFactor != null)
        {
            if ((motherboard.FormFactor.Height < systemBlock.Height && graphicAdapter.Height < systemBlock.Height && processorCoolingSystem.Height <=
                systemBlock.Height) && motherboard.FormFactor.Width < systemBlock.Width && graphicAdapter.Width < systemBlock.Width && processorCoolingSystem.Height + motherboard.FormFactor.Width <=
                systemBlock.Height)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Power consumption is higher than available");
            }
        }

        Console.WriteLine("The components do not fit into the case.");
        return false;
    }
}