namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class Ssd : ISsd
{
    private readonly ComponentCharacteristics _componentCharacteristics = new ComponentCharacteristics();

    public Ssd(string connectionOption, int capacity, int maximumOperatingSpeed, int powerConsumption)
    {
        ConnectionOption = connectionOption;
        Capacity = capacity;
        MaximumOperatingSpeed = maximumOperatingSpeed;
        PowerConsumption = powerConsumption;
        AddAllCharacteristicsToArray();
    }

    public string ConnectionOption { get; init; }
    public int Capacity { get; init; }
    public int MaximumOperatingSpeed { get; init; }
    public int PowerConsumption { get; init; }
    public ComponentCharacteristics AllComponentCharacteristics => _componentCharacteristics;

    public void AddAllCharacteristicsToArray()
    {
        _componentCharacteristics.Add(ConnectionOption);
        _componentCharacteristics.Add(Capacity);
        _componentCharacteristics.Add(MaximumOperatingSpeed);
        _componentCharacteristics.Add(PowerConsumption);
    }

    public SsdBuilder DeBuilder()
    {
        var builder = new SsdBuilder();
        return builder.SetConnectionOption(ConnectionOption)
            .SetCapacity(Capacity)
            .SetMaximumOperatingSpeed(MaximumOperatingSpeed)
            .SetPowerConsumption(PowerConsumption);
    }
}