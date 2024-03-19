using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.MotherboardFormFactor;

namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class Motherboard : IMotherboard
{
    private readonly ComponentCharacteristics _componentCharacteristics = new ComponentCharacteristics();
    public Motherboard(string cpuSocket, int pciELanes, int sataPorts, string chipset, string ddrStandard, int ramSlots, IFormFactor formFactor, IBios bios)
    {
        CpuSocket = cpuSocket;
        PciELanes = pciELanes;
        SataPorts = sataPorts;
        Chipset = chipset;
        DdrStandard = ddrStandard;
        RamSlots = ramSlots;
        FormFactor = formFactor;
        Bios = bios;
    }

    public string CpuSocket { get;  init; }
    public int PciELanes { get; init; }
    public int SataPorts { get; init; }
    public string Chipset { get; init; }
    public string DdrStandard { get; init; }
    public int RamSlots { get; init; }
    public IFormFactor FormFactor { get; init; }
    public IBios Bios { get; init; }
    public ComponentCharacteristics AllComponentCharacteristics => _componentCharacteristics;
    public void AddAllCharacteristicsToArray()
    {
        _componentCharacteristics.Add(CpuSocket);
        _componentCharacteristics.Add(PciELanes);
        _componentCharacteristics.Add(SataPorts);
        _componentCharacteristics.Add(Chipset);
        _componentCharacteristics.Add(DdrStandard);
        _componentCharacteristics.Add(RamSlots);
        _componentCharacteristics.Add(FormFactor);
        _componentCharacteristics.Add(Bios);
    }

    public IMotherboardBuilder DeBuilder()
    {
        var builder = new MotherboardBuilder();
        return builder.SetCpuSocket(CpuSocket)
            .SetPciELanes(PciELanes)
            .SetSataPorts(SataPorts)
            .SetChipset(Chipset)
            .SetDdrStandard(DdrStandard)
            .SetRamSlots(RamSlots)
            .SetFormFactor(FormFactor)
            .SetBios(Bios);
    }
}