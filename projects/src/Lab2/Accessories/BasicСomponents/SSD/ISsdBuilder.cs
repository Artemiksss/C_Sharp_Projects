namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface ISsdBuilder
{
    public SsdBuilder SetConnectionOption(string connectionOption);
    public SsdBuilder SetCapacity(int capacity);
    public SsdBuilder SetMaximumOperatingSpeed(int maximumOperatingSpeed);
    public SsdBuilder SetPowerConsumption(int powerConsumption);
    public Ssd Build();
}