namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IGraphicsAdapterBuilder
{
    public GraphicsAdapterBuilder SetWidth(int width);
    public GraphicsAdapterBuilder SetHeight(int height);
    public GraphicsAdapterBuilder SetCountVideoMemory(int countVideoMemory);
    public GraphicsAdapterBuilder SetPciEVersion(int pciEVersion);
    public GraphicsAdapterBuilder SetChipFrequency(int chipFrequency);
    public GraphicsAdapterBuilder SetPowerConsumption(int powerConsumption);
    public GraphicsAdapter Build();
}