namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IPowerUnitBuilder
{
    public PowerUnitBuilder SetPeakLoad(int peakLoad);
    public PowerUnit Build();
}