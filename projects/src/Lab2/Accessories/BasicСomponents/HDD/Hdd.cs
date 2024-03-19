namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class Hdd : IHdd
{
    private readonly ComponentCharacteristics _componentCharacteristics = new ComponentCharacteristics();
    public Hdd(int capacity, int spindleRotationSpeed, int powerConsumption)
    {
        Capacity = capacity;
        SpindleRotationSpeed = spindleRotationSpeed;
        PowerConsumption = powerConsumption;
    }

    public int Capacity { get; init; }
    public int SpindleRotationSpeed { get; init; }
    public int PowerConsumption { get; init; }
    public ComponentCharacteristics AllComponentCharacteristics => _componentCharacteristics;
    public void AddAllCharacteristicsToArray()
    {
        _componentCharacteristics.Add(Capacity);
        _componentCharacteristics.Add(SpindleRotationSpeed);
        _componentCharacteristics.Add(PowerConsumption);
    }

    public IHddBuilder DeBuilder()
    {
        var builder = new HddBuilder();
        return builder.SetCapacity(Capacity)
            .SetSpindleRotationSpeed(SpindleRotationSpeed)
            .SetPowerConsumption(PowerConsumption);
    }
}