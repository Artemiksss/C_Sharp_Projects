namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;

public interface IBiosBuilder
{
    public BiosBuilder SetTypeBios(string typeBios);
    public BiosBuilder SetVersion(string version);
    public BiosBuilder SetSupportedProcessors(string supportedProcessors);
    public Bios Build();
}