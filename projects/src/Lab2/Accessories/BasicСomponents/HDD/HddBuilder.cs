namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class HddBuilder : IHddBuilder
{
    private int _capacity;
    private int _spindleRotationSpeed;
    private int _powerConsumption;

    public HddBuilder SetCapacity(int capacity)
    {
        if (capacity > 0) _capacity = capacity;
        return this;
    }

    public HddBuilder SetSpindleRotationSpeed(int spindleRotationSpeed)
    {
        if (spindleRotationSpeed > 0) _capacity = spindleRotationSpeed;
        _spindleRotationSpeed = spindleRotationSpeed;
        return this;
    }

    public HddBuilder SetPowerConsumption(int powerConsumption)
    {
        if (powerConsumption > 0) _capacity = powerConsumption;
        _powerConsumption = powerConsumption;
        return this;
    }

    public Hdd Build()
    {
        return new Hdd(_capacity, _spindleRotationSpeed, _powerConsumption);
    }
}