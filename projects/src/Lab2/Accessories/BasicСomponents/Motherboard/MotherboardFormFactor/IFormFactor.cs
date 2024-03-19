namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.MotherboardFormFactor;

public interface IFormFactor
{
    public int Width { get; }
    public int Height { get; }
    public int CountRamSlots { get; }
    public int CountPciELanes { get; }
    public int CountSataPorts { get; }
}