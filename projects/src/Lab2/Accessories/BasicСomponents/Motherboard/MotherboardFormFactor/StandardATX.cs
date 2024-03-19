namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.MotherboardFormFactor;

public class StandardATX : IFormFactor
{
    private const int EATXWidth = 30;
    private const int EATXHeight = 24;
    private const int RamSlots = 4;
    private const int PciELanes = 6;
    private const int SataPorts = 6;
    public int Width => EATXWidth;
    public int Height => EATXHeight;
    public int CountRamSlots => RamSlots;
    public int CountPciELanes => PciELanes;
    public int CountSataPorts => SataPorts;
}