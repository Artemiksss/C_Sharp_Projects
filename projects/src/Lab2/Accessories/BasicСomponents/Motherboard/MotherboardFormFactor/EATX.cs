namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.MotherboardFormFactor;

public class EATX : IFormFactor
{
    private const int EATXWidth = 30;
    private const int EATXHeight = 33;
    private const int RamSlots = 8;
    private const int PciELanes = 6;
    private const int SataPorts = 6;
    public int Width => EATXWidth;
    public int Height => EATXHeight;
    public int CountRamSlots => RamSlots;
    public int CountPciELanes => PciELanes;
    public int CountSataPorts => SataPorts;
}