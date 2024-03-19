namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;

public class BiosBuilder : IBiosBuilder
{
    private string? _typeBios;
    private string? _version;
    private string? _supportedProcessors;

    public BiosBuilder SetTypeBios(string typeBios)
    {
        _typeBios = typeBios;
        return this;
    }

    public BiosBuilder SetVersion(string version)
    {
        _version = version;
        return this;
    }

    public BiosBuilder SetSupportedProcessors(string supportedProcessors)
    {
        _supportedProcessors = supportedProcessors;
        return this;
    }

    public Bios Build()
    {
        return new Bios(
            _typeBios ?? throw new ComputerComponentNullException(),
            _version ?? throw new ComputerComponentNullException(),
            _supportedProcessors ?? throw new ComputerComponentNullException());
    }
}