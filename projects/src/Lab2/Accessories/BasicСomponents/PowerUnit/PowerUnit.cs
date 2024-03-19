namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class PowerUnit : IPowerUnit
{
    private readonly ComponentCharacteristics _componentCharacteristics = new ComponentCharacteristics();
    public PowerUnit(int peakLoad)
    {
        PeakLoad = peakLoad;
        AddAllCharacteristicsToArray();
    }

    public int PeakLoad { get; init; }
    public ComponentCharacteristics AllComponentCharacteristics => _componentCharacteristics;
    public void AddAllCharacteristicsToArray()
    {
        _componentCharacteristics.Add(PeakLoad);
    }

    public IPowerUnitBuilder DeBuilder()
    {
        var builder = new PowerUnitBuilder();
        return builder.SetPeakLoad(PeakLoad);
    }
}