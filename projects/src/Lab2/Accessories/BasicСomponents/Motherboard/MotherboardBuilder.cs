using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.MotherboardFormFactor;

namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class MotherboardBuilder : IMotherboardBuilder
{
    private string? _cpuSocket;
    private int _pciELanes;
    private int _sataPorts;
    private string? _baseChipset;
    private string? _ddrStandard;
    private int _ramSlots;
    private IFormFactor? _formFactor;
    private IBios? _bios;
    public MotherboardBuilder SetCpuSocket(string socket)
    {
        _cpuSocket = socket;
        return this;
    }

    public MotherboardBuilder SetPciELanes(int lanes)
    {
        _pciELanes = lanes;
        return this;
    }

    public MotherboardBuilder SetSataPorts(int ports)
    {
        _sataPorts = ports;
        return this;
    }

    public MotherboardBuilder SetChipset(string chipset)
    {
        _baseChipset = chipset;
        return this;
    }

    public MotherboardBuilder SetDdrStandard(string ddrStandard)
    {
        _ddrStandard = ddrStandard;
        return this;
    }

    public MotherboardBuilder SetRamSlots(int slots)
    {
        _ramSlots = slots;
        return this;
    }

    public MotherboardBuilder SetFormFactor(IFormFactor formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public MotherboardBuilder SetBios(IBios bios)
    {
        _bios = bios;
        return this;
    }

    public Motherboard Build()
    {
        return new Motherboard(
            _cpuSocket ?? throw new ComputerComponentNullException(),
            _pciELanes,
            _sataPorts,
            _baseChipset ?? throw new ComputerComponentNullException(),
            _ddrStandard ?? throw new ComputerComponentNullException(),
            _ramSlots,
            _formFactor ?? throw new ComputerComponentNullException(),
            _bios ?? throw new ComputerComponentNullException());
    }
}