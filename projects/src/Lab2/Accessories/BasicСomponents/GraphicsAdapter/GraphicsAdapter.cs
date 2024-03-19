namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class GraphicsAdapter : IGraphicAdapter
{
    private readonly ComponentCharacteristics _componentCharacteristics = new ComponentCharacteristics();
    public GraphicsAdapter(int width, int height, int countVideoMemory, int pciEVersion, int chipFrequency, int powerConsumption)
    {
        Width = width;
        Height = height;
        CountVideoMemory = countVideoMemory;
        PciEVersion = pciEVersion;
        ChipFrequency = chipFrequency;
        PowerConsumption = powerConsumption;
        AddAllCharacteristicsToArray();
    }

    public int Width { get; init; }
    public int Height { get; init; }
    public int CountVideoMemory { get; init; }
    public int PciEVersion { get; init; }
    public int ChipFrequency { get; init; }
    public int PowerConsumption { get; init; }
    public ComponentCharacteristics AllComponentCharacteristics => _componentCharacteristics;
    public void AddAllCharacteristicsToArray()
    {
        _componentCharacteristics.Add(Width);
        _componentCharacteristics.Add(Height);
        _componentCharacteristics.Add(CountVideoMemory);
        _componentCharacteristics.Add(PciEVersion);
        _componentCharacteristics.Add(ChipFrequency);
        _componentCharacteristics.Add(PowerConsumption);
    }

    public IGraphicsAdapterBuilder DeBuilder()
    {
        var builder = new GraphicsAdapterBuilder();
        return builder.SetWidth(Width)
            .SetHeight(Height)
            .SetCountVideoMemory(CountVideoMemory)
            .SetPciEVersion(PciEVersion)
            .SetChipFrequency(ChipFrequency)
            .SetPowerConsumption(PowerConsumption);
    }
}