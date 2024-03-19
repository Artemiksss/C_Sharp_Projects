namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.MotherboardFormFactor;

public class MicroATX : IFormFactor
{
    private const int EATXWidth = 24;
    private const int EATXHeight = 24;
    private const int RamSlots = 2;
    private const int PciELanes = 3;
    private const int SataPorts = 4;
    public int Width => EATXWidth;
    public int Height => EATXHeight;
    public int CountRamSlots => RamSlots;
    public int CountPciELanes => PciELanes;
    public int CountSataPorts => SataPorts;
}