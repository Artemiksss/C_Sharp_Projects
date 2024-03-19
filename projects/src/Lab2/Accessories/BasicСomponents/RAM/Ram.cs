namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class Ram : IRam
{
    private readonly ComponentCharacteristics _componentCharacteristics = new ComponentCharacteristics();
    public Ram(int memorySize, int supportedFreqVoltPairs, string availableProfiles, string formFactor, string ddrVersion, double powerConsumptionWatts)
    {
        MemorySize = memorySize;
        SupportedFreqVoltPairs = supportedFreqVoltPairs;
        AvailableProfiles = availableProfiles;
        FormFactor = formFactor;
        DdrVersion = ddrVersion;
        PowerConsumptionWatts = powerConsumptionWatts;
        AddAllCharacteristicsToArray();
    }

    public int MemorySize { get; init;  }
    public int SupportedFreqVoltPairs { get; init; }
    public string AvailableProfiles { get; init; }
    public string FormFactor { get; init; }
    public string DdrVersion { get; init; }
    public double PowerConsumptionWatts { get; init; }

    public ComponentCharacteristics AllComponentCharacteristics => _componentCharacteristics;
    public void AddAllCharacteristicsToArray()
    {
        _componentCharacteristics.Add(MemorySize);
        _componentCharacteristics.Add(SupportedFreqVoltPairs);
        _componentCharacteristics.Add(AvailableProfiles);
        _componentCharacteristics.Add(FormFactor);
        _componentCharacteristics.Add(DdrVersion);
        _componentCharacteristics.Add(PowerConsumptionWatts);
    }

    public RamBuilder DeBuilder()
    {
        var builder = new RamBuilder();
        return builder.SetMemorySize(MemorySize)
            .SetSupportedFreqVoltPairs(SupportedFreqVoltPairs)
            .SetAvailableProfiles(AvailableProfiles)
            .SetFormFactor(FormFactor)
            .SetDdrVersion(DdrVersion)
            .SetPowerConsumption(PowerConsumptionWatts);
    }
}