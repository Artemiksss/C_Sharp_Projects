namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;

public class XmpProfileBuilder : IXmpProfileBuilder
{
    private string? _timings;
    private double _voltage;
    private int _frequency;

    public XmpProfileBuilder SetTimings(string timings)
    {
        _timings = timings;
        return this;
    }

    public XmpProfileBuilder SetVoltage(double voltage)
    {
        _voltage = voltage;
        return this;
    }

    public XmpProfileBuilder SetFrequency(int frequency)
    {
        _frequency = frequency;
        return this;
    }

    public XmpProfile Build()
    {
        return new XmpProfile(
            _timings ?? throw new ComputerComponentNullException(),
            _voltage,
            _frequency);
    }
}