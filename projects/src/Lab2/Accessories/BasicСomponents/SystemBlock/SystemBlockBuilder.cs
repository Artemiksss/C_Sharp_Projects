namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public class SystemBlockBuilder : ISystemBlockBuilder
{
    private int _maximumLengthVideoCard;
    private int _maximumWidthVideoCard;
    private string? _supportedFormFactorsMotherboards;
    private int _width;
    private int _height;

    public SystemBlockBuilder SetMaximumLengthVideoCard(int maximumLengthVideoCard)
    {
        _maximumLengthVideoCard = maximumLengthVideoCard;
        return this;
    }

    public SystemBlockBuilder SetMaximumWidthVideoCard(int maximumWidthVideoCard)
    {
        _maximumWidthVideoCard = maximumWidthVideoCard;
        return this;
    }

    public SystemBlockBuilder SetSupportedFormFactorsMotherboards(string supportedFormFactorsMotherboards)
    {
        _supportedFormFactorsMotherboards = supportedFormFactorsMotherboards;
        return this;
    }

    public SystemBlockBuilder SetWidth(int width)
    {
        _width = width;
        return this;
    }

    public SystemBlockBuilder SetHeight(int height)
    {
        _height = height;
        return this;
    }

    public SystemBlock Build()
    {
        return new SystemBlock(
            _maximumLengthVideoCard,
            _maximumWidthVideoCard,
            _supportedFormFactorsMotherboards ?? throw new ComputerComponentNullException(),
            _width,
            _height);
    }
}