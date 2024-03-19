namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class SsdBuilder : ISsdBuilder
{
    private string? _connectionOption;
    private int _capacity;
    private int _maximumOperatingSpeed;
    private int _powerConsumption;

    public SsdBuilder SetConnectionOption(string connectionOption)
    {
        _connectionOption = connectionOption;
        return this;
    }

    public SsdBuilder SetCapacity(int capacity)
    {
        _capacity = capacity;
        return this;
    }

    public SsdBuilder SetMaximumOperatingSpeed(int maximumOperatingSpeed)
    {
        _maximumOperatingSpeed = maximumOperatingSpeed;
        return this;
    }

    public SsdBuilder SetPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public Ssd Build()
    {
        return new Ssd(
            _connectionOption ?? throw new ComputerComponentNullException(),
            _capacity,
            _maximumOperatingSpeed,
            _powerConsumption);
    }
}