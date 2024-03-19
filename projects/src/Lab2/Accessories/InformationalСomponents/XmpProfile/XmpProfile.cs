namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;

public class XmpProfile : IXmpProfile
{
    private readonly ComponentCharacteristics _componentCharacteristics = new ComponentCharacteristics();
    public XmpProfile(string timings, double voltage, int frequency)
    {
        Timings = timings;
        Voltage = voltage;
        Frequency = frequency;
    }

    public string Timings { get; init; }
    public double Voltage { get;  init; }
    public int Frequency { get; init; }
    public ComponentCharacteristics AllComponentCharacteristics => _componentCharacteristics;
    public void AddAllCharacteristicsToArray()
    {
        _componentCharacteristics.Add(Timings);
        _componentCharacteristics.Add(Voltage);
        _componentCharacteristics.Add(Frequency);
    }

    public XmpProfileBuilder DeBuilder()
    {
        var builder = new XmpProfileBuilder();
        return builder.SetTimings(Timings)
            .SetVoltage(Voltage)
            .SetFrequency(Frequency);
    }
}