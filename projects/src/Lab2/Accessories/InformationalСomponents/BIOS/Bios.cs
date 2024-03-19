namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories.InformationalСomponents;

public class Bios : IBios
{
    private readonly ComponentCharacteristics _componentCharacteristics = new ComponentCharacteristics();
    public Bios(string typeBios, string version, string supportedProcessors)
    {
        TypeBios = typeBios;
        Version = version;
        SupportedProcessors = supportedProcessors;
        AddAllCharacteristicsToArray();
    }

    public string TypeBios { get; init; }
    public string Version { get; init; }
    public string SupportedProcessors { get; init; }
    public ComponentCharacteristics AllComponentCharacteristics => _componentCharacteristics;
    public void AddAllCharacteristicsToArray()
    {
        _componentCharacteristics.Add(TypeBios);
        _componentCharacteristics.Add(Version);
        _componentCharacteristics.Add(SupportedProcessors);
    }

    public BiosBuilder DeBuilder()
    {
        var builder = new BiosBuilder();
        return builder.SetTypeBios(TypeBios)
            .SetVersion(Version)
            .SetSupportedProcessors(SupportedProcessors);
    }
}