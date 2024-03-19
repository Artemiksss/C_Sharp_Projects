namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IRamBuilder
{
    public RamBuilder SetMemorySize(int size);
    public RamBuilder SetSupportedFreqVoltPairs(int pairs);
    public RamBuilder SetAvailableProfiles(string profiles);
    public RamBuilder SetFormFactor(string formFactor);
    public RamBuilder SetDdrVersion(string version);
    public RamBuilder SetPowerConsumption(double watts);
    public Ram Build();
}