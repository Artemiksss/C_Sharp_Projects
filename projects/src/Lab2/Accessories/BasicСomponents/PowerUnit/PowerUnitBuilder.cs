namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class PowerUnitBuilder : IPowerUnitBuilder
{
    private int _peakLoad;

    public PowerUnitBuilder SetPeakLoad(int peakLoad)
    {
        _peakLoad = peakLoad;
        return this;
    }

    public PowerUnit Build()
    {
        return new PowerUnit(_peakLoad);
    }
}