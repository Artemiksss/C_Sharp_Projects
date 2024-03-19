namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class GraphicsAdapterBuilder : IGraphicsAdapterBuilder
{
    private int _width;
    private int _height;
    private int _countVideoMemory;
    private int _pciEVersion;
    private int _chipFrequency;
    private int _powerConsumption;

    public GraphicsAdapterBuilder SetWidth(int width)
    {
        _width = width;
        return this;
    }

    public GraphicsAdapterBuilder SetHeight(int height)
    {
        _height = height;
        return this;
    }

    public GraphicsAdapterBuilder SetCountVideoMemory(int countVideoMemory)
    {
        _countVideoMemory = countVideoMemory;
        return this;
    }

    public GraphicsAdapterBuilder SetPciEVersion(int pciEVersion)
    {
        _pciEVersion = pciEVersion;
        return this;
    }

    public GraphicsAdapterBuilder SetChipFrequency(int chipFrequency)
    {
        _chipFrequency = chipFrequency;
        return this;
    }

    public GraphicsAdapterBuilder SetPowerConsumption(int powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public GraphicsAdapter Build()
    {
        return new GraphicsAdapter(_width, _height, _countVideoMemory, _pciEVersion, _chipFrequency, _powerConsumption);
    }
}