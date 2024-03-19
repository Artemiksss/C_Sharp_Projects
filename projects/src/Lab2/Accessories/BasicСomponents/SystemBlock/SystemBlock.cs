namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class SystemBlock : ISystemBlock
{
    private readonly ComponentCharacteristics _componentCharacteristics = new ComponentCharacteristics();
    public SystemBlock(int maximumLengthVideoCard, int maximumWidthVideoCard, string supportedFormFactorsMotherboards, int width, int height)
    {
        MaximumLengthVideoCard = maximumLengthVideoCard;
        MaximumWidthVideoCard = maximumWidthVideoCard;
        SupportedFormFactorsMotherboards = supportedFormFactorsMotherboards;
        Width = width;
        Height = height;
        AddAllCharacteristicsToArray();
    }

    public int MaximumLengthVideoCard { get; init; }
    public int MaximumWidthVideoCard { get; init; }
    public string SupportedFormFactorsMotherboards { get; init; }
    public int Width { get; init; }
    public int Height { get; init; }
    public ComponentCharacteristics AllComponentCharacteristics => _componentCharacteristics;

    public void AddAllCharacteristicsToArray()
    {
        _componentCharacteristics.Add(MaximumLengthVideoCard);
        _componentCharacteristics.Add(MaximumWidthVideoCard);
        _componentCharacteristics.Add(SupportedFormFactorsMotherboards);
        _componentCharacteristics.Add(Width);
        _componentCharacteristics.Add(Height);
    }

    public SystemBlockBuilder DeBuilder()
    {
        var builder = new SystemBlockBuilder();
        return builder.SetMaximumLengthVideoCard(MaximumLengthVideoCard)
            .SetMaximumWidthVideoCard(MaximumWidthVideoCard)
            .SetSupportedFormFactorsMotherboards(SupportedFormFactorsMotherboards)
            .SetWidth(Width)
            .SetHeight(Height);
    }
}
