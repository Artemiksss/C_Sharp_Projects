using Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.MotherboardFormFactor;

namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IMotherboardBuilder
{
    public MotherboardBuilder SetCpuSocket(string socket);
    public MotherboardBuilder SetPciELanes(int lanes);
    public MotherboardBuilder SetSataPorts(int ports);
    public MotherboardBuilder SetChipset(string chipset);
    public MotherboardBuilder SetDdrStandard(string ddrStandard);
    public MotherboardBuilder SetRamSlots(int slots);
    public MotherboardBuilder SetFormFactor(IFormFactor formFactor);
    public MotherboardBuilder SetBios(IBios bios);
    public Motherboard Build();
}