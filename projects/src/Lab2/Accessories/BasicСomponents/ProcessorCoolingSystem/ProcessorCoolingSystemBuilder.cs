namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class ProcessorCoolingSystemBuilder : IProcessorCoolingSystemBuilder
{
    private int _width;
    private int _height;
    private string? _supportedSockets;
    private int _tdp;

    public ProcessorCoolingSystemBuilder SetWidth(int width)
    {
        _width = width;
        return this;
    }

    public ProcessorCoolingSystemBuilder SetHeight(int height)
    {
        _height = height;
        return this;
    }

    public ProcessorCoolingSystemBuilder SetSupportedSockets(string? supportedSockets)
    {
        _supportedSockets = supportedSockets;
        return this;
    }

    public ProcessorCoolingSystemBuilder SetTdp(int tdp)
    {
        _tdp = tdp;
        return this;
    }

    public ProcessorCoolingSystem Build()
    {
        return new ProcessorCoolingSystem(
            _width,
            _height,
            _supportedSockets ?? throw new ComputerComponentNullException(),
            _tdp);
    }
}