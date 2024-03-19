using Itmo.ObjectOrientedProgramming.Lab2.Accessories.BasicСomponents.CPU;

namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.Builders;

public class CpuBuilder : ICpuBuilder
{
    private double _coreFrequency;
    private int _numberOfCores;
    private string? _socket;
    private bool _integratedGraphics;
    private int _supportedMemoryFrequencies;
    private int _tdp;
    private int _powerConsumption;

    public CpuBuilder SetCoreFrequency(double coreFrequency)
    {
        _coreFrequency = coreFrequency;
        return this;
    }

    public CpuBuilder SetNumberOfCores(int numberOfCores)
    {
        _numberOfCores = numberOfCores;
        return this;
    }

    public CpuBuilder SetSocket(string socket)
    {
        _socket = socket;
        return this;
    }

    public CpuBuilder SetIntegratedGraphics(bool integratedGraphics)
    {
        _integratedGraphics = integratedGraphics;
        return this;
    }

    public CpuBuilder SetSupportedMemoryFrequencies(int supportedMemoryFrequencies)
    {
        _supportedMemoryFrequencies = supportedMemoryFrequencies;
        return this;
    }

    public CpuBuilder SetTdp(int tdp)
    {
        _tdp = tdp;
        return this;
    }

    public CpuBuilder SetPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public Cpu Build()
    {
        return new Cpu(_coreFrequency, _numberOfCores, _socket ?? throw new ComputerComponentNullException(), _integratedGraphics, _supportedMemoryFrequencies, _tdp, _powerConsumption);
    }
}