namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IHddBuilder
{
    public HddBuilder SetCapacity(int capacity);
    public HddBuilder SetSpindleRotationSpeed(int spindleRotationSpeed);
    public HddBuilder SetPowerConsumption(int powerConsumption);
    public Hdd Build();
}