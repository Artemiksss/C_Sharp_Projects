using Itmo.ObjectOrientedProgramming.Lab2.Accessories.Builders;

namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.BasicСomponents.CPU;

public interface ICpuBuilder
{
    public CpuBuilder SetCoreFrequency(double coreFrequency);
    public CpuBuilder SetNumberOfCores(int numberOfCores);
    public CpuBuilder SetSocket(string socket);
    public CpuBuilder SetIntegratedGraphics(bool integratedGraphics);
    public CpuBuilder SetSupportedMemoryFrequencies(int supportedMemoryFrequencies);
    public CpuBuilder SetTdp(int tdp);
    public CpuBuilder SetPowerConsumption(int powerConsumption);
    public Cpu Build();
}