namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.MotherboardFormFactor;

public class MiniITX : IFormFactor
{
    private const int EATXWidth = 17;
    private const int EATXHeight = 17;
    private const int RamSlots = 2;
    private const int PciELanes = 1;
    private const int SataPorts = 2;
    public int Width => EATXWidth;
    public int Height => EATXHeight;
    public int CountRamSlots => RamSlots;
    public int CountPciELanes => PciELanes;
    public int CountSataPorts => SataPorts;
}