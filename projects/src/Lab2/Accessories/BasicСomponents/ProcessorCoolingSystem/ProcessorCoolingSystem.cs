namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class ProcessorCoolingSystem : IProcessorCoolingSystem
{
    private readonly ComponentCharacteristics _componentCharacteristics = new ComponentCharacteristics();
    public ProcessorCoolingSystem(int width, int height, string supportedSockets, int tdp)
    {
        Width = width;
        Height = height;
        SupportedSockets = supportedSockets;
        Tdp = tdp;
        AddAllCharacteristicsToArray();
    }

    public int Width { get; init; }
    public int Height { get; init; }
    public string SupportedSockets { get; init; }
    public int Tdp { get; init; }
    public ComponentCharacteristics AllComponentCharacteristics => _componentCharacteristics;
    public void AddAllCharacteristicsToArray()
    {
        _componentCharacteristics.Add(Width);
        _componentCharacteristics.Add(Height);
        _componentCharacteristics.Add(SupportedSockets);
        _componentCharacteristics.Add(Tdp);
    }

    public IProcessorCoolingSystemBuilder DeBuilder()
    {
        var builder = new ProcessorCoolingSystemBuilder();
        return builder.SetWidth(Width)
            .SetHeight(Height)
            .SetSupportedSockets(SupportedSockets)
            .SetTdp(Tdp);
    }
}