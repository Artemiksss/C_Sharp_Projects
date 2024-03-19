namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface IProcessorCoolingSystemBuilder
{
    public ProcessorCoolingSystemBuilder SetWidth(int width);
    public ProcessorCoolingSystemBuilder SetHeight(int height);
    public ProcessorCoolingSystemBuilder SetSupportedSockets(string supportedSockets);
    public ProcessorCoolingSystemBuilder SetTdp(int tdp);
    public ProcessorCoolingSystem Build();
}