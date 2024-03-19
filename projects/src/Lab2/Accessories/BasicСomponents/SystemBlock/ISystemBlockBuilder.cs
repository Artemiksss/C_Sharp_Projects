namespace Itmo.ObjectOrientedProgramming.Lab2.Accessories;

public interface ISystemBlockBuilder
{
    public SystemBlockBuilder SetMaximumLengthVideoCard(int maximumLengthVideoCard);
    public SystemBlockBuilder SetMaximumWidthVideoCard(int maximumWidthVideoCard);
    public SystemBlockBuilder SetSupportedFormFactorsMotherboards(string supportedFormFactorsMotherboards);
    public SystemBlockBuilder SetWidth(int width);
    public SystemBlockBuilder SetHeight(int height);
    public SystemBlock Build();
}