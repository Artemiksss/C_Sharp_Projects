namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class RamBuilder : IRamBuilder
{
    private int _memorySize;
    private int _supportedFreqVoltPairs;
    private string? _availableProfiles;
    private string? _formFactor;
    private string? _ddrVersion;
    private double _powerConsumptionWatts;
    public RamBuilder SetMemorySize(int size)
    {
        _memorySize = size;
        return this;
    }

    public RamBuilder SetSupportedFreqVoltPairs(int pairs)
    {
        _supportedFreqVoltPairs = pairs;
        return this;
    }

    public RamBuilder SetAvailableProfiles(string profiles)
    {
        _availableProfiles = profiles;
        return this;
    }

    public RamBuilder SetFormFactor(string formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public RamBuilder SetDdrVersion(string version)
    {
        _ddrVersion = version;
        return this;
    }

    public RamBuilder SetPowerConsumption(double watts)
    {
        _powerConsumptionWatts = watts;
        return this;
    }

    public Ram Build()
    {
        return new Ram(
            _memorySize,
            _supportedFreqVoltPairs,
            _availableProfiles ?? throw new ComputerComponentNullException(),
            _formFactor ?? throw new ComputerComponentNullException(),
            _ddrVersion ?? throw new ComputerComponentNullException(),
            _powerConsumptionWatts);
    }
}