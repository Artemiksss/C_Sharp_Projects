using Itmo.ObjectOrientedProgramming.Lab2.Accessories.BasicСomponents.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Accessories.Builders;

namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class Cpu : ICpu
{
    private readonly ComponentCharacteristics _componentCharacteristics = new ComponentCharacteristics();
    public Cpu(double coreFrequency, int numberOfCores, string socket, bool integratedGraphics, int supportedMemoryFrequencies, int tdp, int powerConsumption)
    {
        CoreFrequency = coreFrequency;
        NumberOfCores = numberOfCores;
        Socket = socket;
        IntegratedGraphics = integratedGraphics;
        SupportedMemoryFrequencies = supportedMemoryFrequencies;
        Tdp = tdp;
        PowerConsumption = powerConsumption;
        AddAllCharacteristicsToArray();
    }

    public double CoreFrequency { get; init; }
    public int NumberOfCores { get; init; }
    public string Socket { get; init; }
    public bool IntegratedGraphics { get; init; }
    public int SupportedMemoryFrequencies { get; init; }
    public int Tdp { get; init; }
    public int PowerConsumption { get; init; }

    public ComponentCharacteristics AllComponentCharacteristics => _componentCharacteristics;

    public void AddAllCharacteristicsToArray()
    {
        _componentCharacteristics.Add(CoreFrequency);
        _componentCharacteristics.Add(NumberOfCores);
        _componentCharacteristics.Add(Socket);
        _componentCharacteristics.Add(IntegratedGraphics);
        _componentCharacteristics.Add(SupportedMemoryFrequencies);
        _componentCharacteristics.Add(Tdp);
        _componentCharacteristics.Add(PowerConsumption);
    }

    public ICpuBuilder DeBuilder()
    {
        var builder = new CpuBuilder();
        return builder.SetCoreFrequency(CoreFrequency)
            .SetNumberOfCores(NumberOfCores)
            .SetSocket(Socket)
            .SetIntegratedGraphics(IntegratedGraphics)
            .SetSupportedMemoryFrequencies(SupportedMemoryFrequencies)
            .SetTdp(Tdp)
            .SetPowerConsumption(PowerConsumption);
    }
}